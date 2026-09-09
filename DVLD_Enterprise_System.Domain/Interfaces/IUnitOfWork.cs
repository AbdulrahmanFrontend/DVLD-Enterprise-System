using DVLD_Enterprise_System.Domain.Entities;

namespace DVLD_Enterprise_System.Domain.Interfaces;

/// <summary>
/// UNIT OF WORK PATTERN.
///
/// WHY DOES THIS EXIST?
/// Imagine an operation like "Approve a Detained License Release": you need to
/// (1) update the DetainedLicense row (IsReleased = true), AND
/// (2) update the Application row (status = Completed)
/// ...in the SAME database transaction. If step 1 succeeds but step 2 fails,
/// your data becomes inconsistent.
///
/// The Unit of Work groups multiple repository operations together and exposes
/// a single SaveChangesAsync() that commits ALL of them at once (EF Core's
/// DbContext already behaves like a Unit of Work internally — this interface
/// simply exposes that idea to the rest of the app without leaking EF Core itself).
///
/// USAGE EXAMPLE (later, in the Application layer):
///   var app = await _unitOfWork.Applications.GetByIdAsync(id);
///   app.ApplicationStatus = ApplicationStatus.Completed;
///   _unitOfWork.Applications.Update(app);
///   await _unitOfWork.SaveChangesAsync();   // <-- ONE call commits everything.
/// </summary>
public interface IUnitOfWork : IDisposable
{
    IGenericRepository<Country> Countries { get; }
    IGenericRepository<Person> People { get; }
    IGenericRepository<User> Users { get; }
    IGenericRepository<ApplicationType> ApplicationTypes { get; }
    IGenericRepository<Application> Applications { get; }
    IGenericRepository<LicenseClass> LicenseClasses { get; }
    IGenericRepository<LocalDrivingLicenseApplication> LocalDrivingLicenseApplications { get; }
    IGenericRepository<Driver> Drivers { get; }
    IGenericRepository<License> Licenses { get; }
    IGenericRepository<DetainedLicense> DetainedLicenses { get; }
    IGenericRepository<InternationalLicense> InternationalLicenses { get; }
    IGenericRepository<TestType> TestTypes { get; }
    IGenericRepository<TestAppointment> TestAppointments { get; }
    IGenericRepository<Test> Tests { get; }

    /// <summary>
    /// Commits every pending Add/Update/Remove made through the repositories above,
    /// in a single database transaction. Returns the number of affected rows.
    /// </summary>
    Task<int> SaveChangesAsync();
}
