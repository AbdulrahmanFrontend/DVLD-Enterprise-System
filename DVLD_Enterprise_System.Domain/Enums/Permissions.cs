namespace DVLD_Enterprise_System.Domain.Enums;

[Flags]
public enum Permissions : int
{
    None = 0,
    ManagePeople = 1,      // 1 << 0 (إدارة الأشخاص)
    ManageUsers = 2,       // 1 << 1 (إدارة المستخدمين)
    ManageDrivers = 4,     // 1 << 2 (إدارة السائقين)
    ManageApplications = 8,// 1 << 3 (إدارة الطلبات والركخص)
    All = -1               // المدير الشامل يمتلك كل الصلاحيات
}
