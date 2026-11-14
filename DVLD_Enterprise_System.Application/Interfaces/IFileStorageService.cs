namespace DVLD_Enterprise_System.Application.Interfaces;

public interface IFileStorageService
{
    Task<string> SaveFileAsync(Stream stream, string fileName, string folderName);
    void DeleteFile(string filePath);
}
