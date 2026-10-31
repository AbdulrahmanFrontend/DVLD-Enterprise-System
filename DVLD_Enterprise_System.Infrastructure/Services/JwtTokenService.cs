using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Domain.Entities;
using DVLD_Enterprise_System.Domain.Enums;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DVLD_Enterprise_System.Infrastructure.Services;

public class JwtTokenService : IJwtTokenService
{
    private readonly IConfiguration _configuration;

    public JwtTokenService(IConfiguration configuration)
    {
        _configuration = configuration; // لقراءة المفتاح السري والإعدادات من ملف appsettings.json
    }

    public string GenerateToken(User user)
    {
        // 1. جلب إعدادات الـ JWT والمفتاح السري من الإعدادات
        var jwtSettings = _configuration.GetSection("Jwt");
        var secretKey = jwtSettings["Key"] ?? throw new InvalidOperationException("Key is missing");
        var key = Encoding.UTF8.GetBytes(secretKey);

        // 2. تجهيز الـ Claims (وهي البيانات أو "الأملاك" التي سيتم تضمينها داخل البطاقة)
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.UserID.ToString()), // تخزين رقم المستخدم الفريد
            new Claim(ClaimTypes.Name, user.UserName),                      // تخزين اسم المستخدم
            new Claim("PersonID", user.PersonID.ToString()),                // تخزين رقم الشخص المرتبط بجدول People
            new Claim("Permissions", ((int)user.Permissions).ToString())    // تخزين رقم الصلاحيات (Bitwise)
        };

        // 3. تحديد الأدوار (Roles) لتسهيل حماية الـ Endpoints لاحقاً
        if ((int)user.Permissions == -1 || ((int)user.Permissions & (int)Permissions.ManageUsers) != 0)
        {
            claims.Add(new Claim(ClaimTypes.Role, "Admin"));
        }
        else
        {
            claims.Add(new Claim(ClaimTypes.Role, "Employee"));
        }

        // 4. تصميم وصف الـ Token (مدة الصلاحية، الجهات المصدرة، والتوقيع الرقمي)
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddHours(2), // صلاحية البطاقة ساعتان فقط لأسباب أمنية
            Issuer = jwtSettings["Issuer"],       // الجهة المصدرة للسيرفر
            Audience = jwtSettings["Audience"],   // الجهة المستهلكة

            // التوقيع الرقمي (Signature): دمج البيانات بالمفتاح السري باستخدام خوارزمية HMAC-SHA256 لمنع أي تلاعب
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };

        // 5. توليد النص النهائي المكون من ثلاثة أجزاء (Header.Payload.Signature) وإرجاعه كـ String
        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}
