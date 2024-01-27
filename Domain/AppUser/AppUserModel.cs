namespace Domain.AppUser;

 public class AppUserOutputModelSimple
{
    public int Id { get; set; } 
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public bool IsActive { get; set; }
}

public class AppUserFilterModel
{
    public string? Name { get; set; }
    public string? LastName { get; set; } 
    public bool? IsActive { get; set; }

}

