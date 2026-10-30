# ==========================================
# المرحلة الأولى: بناء المشروع (Build Stage)
# ==========================================
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# نسخ كل ملفات المشروع والـ Solution بالكامل لضمان رؤية جميع الطبقات المرتبطة (Clean Architecture)
COPY . .

# استعادة الحزم البرمجية وبناء طبقة الـ API
RUN dotnet restore "DVLD_Enterprise_System.API/DVLD_Enterprise_System.API.csproj"
RUN dotnet publish "DVLD_Enterprise_System.API/DVLD_Enterprise_System.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

# ==========================================
# المرحلة الثانية: التشغيل النهائي والخفيف (Runtime Stage)
# ==========================================
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
EXPOSE 8080

# نسخ الملفات النهائية الجاهزة فقط من المرحلة السابقة
COPY --from=build /app/publish .

# تشغيل الـ API فور إقلاع الحاوية
ENTRYPOINT ["dotnet", "DVLD_Enterprise_System.API.dll"]
