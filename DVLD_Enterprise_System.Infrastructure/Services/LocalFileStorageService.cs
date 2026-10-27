using DVLD_Enterprise_System.Application.Interfaces;

namespace DVLD_Enterprise_System.Infrastructure.Services;

public class LocalFileStorageService : IFileStorageService
{
    public async Task<string> SaveFileAsync(Stream stream, string fileName, string folderName)
    {
        if (stream == null || stream.Length == 0) return string.Empty;

        // إنشاء اسم فريد للملف لمنع التعارض
        var uniqueFileName = $"{Guid.NewGuid()}_{fileName}";

        // استخدام مجلد التشغيل الحالي (الذي سيكون مشروع الـ API عند تشغيل التطبيق)
        var basePath = Directory.GetCurrentDirectory();

        // إذا كان التشغيل يتم من مجلد آخر، نتأكد من توجيه المسار لمشروع الـ API أو مجلد الـ wwwroot العام
        var uploadFolder = Path.Combine(basePath, "wwwroot", folderName);

        if (!Directory.Exists(uploadFolder))
        {
            Directory.CreateDirectory(uploadFolder);
        }

        var filePath = Path.Combine(uploadFolder, uniqueFileName);

        using (var fileStream = new FileStream(filePath, FileMode.Create))
        {
            await stream.CopyToAsync(fileStream);
        }

        // إرجاع المسار النسبي لتخزينه في قاعدة البيانات
        return Path.Combine(folderName, uniqueFileName).Replace("\\", "/");
    }

    public void DeleteFile(string filePath)
    {
        if (string.IsNullOrEmpty(filePath)) return;

        var basePath = Directory.GetCurrentDirectory();
        var fullPath = Path.Combine(basePath, "wwwroot", filePath);

        if (File.Exists(fullPath))
        {
            File.Delete(fullPath);
        }
    }
}
