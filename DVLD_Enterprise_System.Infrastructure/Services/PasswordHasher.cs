using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace DVLD_Enterprise_System.Infrastructure.Services;

public class PasswordHasher : IPasswordHasher
{
    // 1. نقوم باستدعاء الأداة الرسمية والآمنة المدمجة في ASP.NET Core الخاصة بـ Identity
    private readonly Microsoft.AspNetCore.Identity.PasswordHasher<User> _hasher = new();

    // 2. دالة التشفير: تُستدعى عند إنشاء مستخدم جديد أو تغيير كلمة المرور
    public string HashPassword(User user, string password)
    {
        // تأخذ كائن المستخدم وكلمة المرور العادية، وتُنتج نصاً مشفراً طويلاً (Hash) يحتوي بداخله على الـ Salt الآمن
        return _hasher.HashPassword(user, password);
    }

    // 3. دالة التحقق: تُستدعى حصرياً عند محاولة تسجيل الدخول (Login)
    public bool VerifyPassword(User user, string hashedPassword, string providedPassword)
    {
        // تقارن كلمة المرور التي كتبها المستخدم حالياً مع الـ Hash القديم المخزن في الداتابेस
        var result = _hasher.VerifyHashedPassword(user, hashedPassword, providedPassword);

        // ترجع True إذا طابقت تماماً، أو False إذا كانت خاطئة
        return result == PasswordVerificationResult.Success;
    }
}
