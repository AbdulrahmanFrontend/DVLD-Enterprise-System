namespace DVLD_Enterprise_System.Domain.Entities;

/// <summary>
/// A Person becomes a "Driver" the first time they are granted any license.
/// This lets the system track someone's full driving history (licenses,
/// detentions, international licenses) under a single DriverID, even if that
/// person submits many separate Applications over the years.
/// </summary>
public class Driver
{
    public int DriverID { get; set; }
    public int PersonID { get; set; }
    public int CreatedByUserID { get; set; }
    public DateTime CreatedDate { get; set; }

    public Person Person { get; set; } = null!;
    public User CreatedByUser { get; set; } = null!;
}
