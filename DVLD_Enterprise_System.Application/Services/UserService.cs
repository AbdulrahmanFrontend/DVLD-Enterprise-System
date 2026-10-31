using DVLD_Enterprise_System.Application.DTOs.Users;
using DVLD_Enterprise_System.Application.Exceptions;
using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DVLD_Enterprise_System.Application.Services;

public class UserService : IUserService
{
    private readonly IAppDbContext _context;
    private readonly IPasswordHasher _passwordHasher;
    private readonly IJwtTokenService _jwtTokenService;

    public UserService(
        IAppDbContext context,
        IPasswordHasher passwordHasher,
        IJwtTokenService jwtTokenService)
    {
        _context = context;
        _passwordHasher = passwordHasher;
        _jwtTokenService = jwtTokenService;
    }

    public async Task<AuthResponseDto> LoginAsync(
        LoginRequestDto dto,
        CancellationToken cancellation = default)
    {
        // 1. البحث عن المستخدم في جدول Users
        var user = await _context.Users
            .FirstOrDefaultAsync(u => u.UserName == dto.UserName, cancellation);

        if (user == null)
            throw new UnauthorizedAccessException("Username is incorrect!");

        // 2. التحقق هل الحساب مفعل أم محظور (IsActive)
        if (!user.IsActive)
            throw new BusinessRuleException("This account is not active!");

        // 3. التحقق من صحة كلمة المرور (PasswordHash)
        var isPasswordValid = _passwordHasher.VerifyPassword(
            user, 
            user.PasswordHash, 
            dto.Password);

        if (!isPasswordValid)
            throw new UnauthorizedAccessException("Password is incorrect!");

        // 4. توليد الـ JWT Token إذا نجح كل شيء
        var token = _jwtTokenService.GenerateToken(user);

        return new AuthResponseDto
        {
            Token = token,
            UserName = user.UserName,
            ExpiresAt = DateTime.UtcNow.AddHours(2)
        };
    }

    public async Task<int> CreateUserAsync(
        CreateUserDto dto,
        CancellationToken cancellation = default)
    {
        // التأكد من أن الشخص موجود في جدول People أولاً
        var personExists = await _context.People.AnyAsync(
            p => p.PersonID == dto.PersonID,
            cancellation);

        if (!personExists)
            throw new NotFoundException(nameof(Person), dto.PersonID);

        // التأكد أن الشخص ليس لديه حساب مستخدم مسبقاً (علاقة 1 لـ 1)
        var userExistsForPerson = await _context.Users.AnyAsync(
            u => u.PersonID == dto.PersonID,
            cancellation);
        if (userExistsForPerson)
            throw new ConflictException("That Person is already user!");

        var user = new User
        {
            PersonID = dto.PersonID,
            UserName = dto.UserName,
            IsActive = true,
            Permissions = dto.Permissions
        };

        // تشفير كلمة المرور قبل الحفظ
        user.PasswordHash = _passwordHasher.HashPassword(user, dto.PasswordHash);

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return user.UserID;
    }
}
