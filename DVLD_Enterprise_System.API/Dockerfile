# المرحلة الأولى: بناء المشروع (Build Stage)
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# نسخ ملف المشروع واستعادة الحزم
توافقية الملفات الأساسية
COPY ["DVLD_Enterprise_System.API.csproj", "./"]
RUN dotnet restore "DVLD_Enterprise_System.API.csproj"

# نسخ باقي الكود وبناء النسخة النهائية للإنتاج
COPY . .
RUN dotnet publish "DVLD_Enterprise_System.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

# المرحلة الثانية: التشغيل النهائي والخفيف (Runtime Stage)
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
EXPOSE 8080

# نسخ ملفات النشر فقط من المرحلة السابقة
COPY --from=build /app/publish .

# تشغيل الـ API فور إقلاع الحاوية
ENTRYPOINT ["dotnet", "DVLD_Enterprise_System.API.dll"]