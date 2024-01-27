namespace Mataa.Data;


    public class MataaDbContext : IdentityDbContext<AppUser>
    {
    public MataaDbContext() : base() { }
    public MataaDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<AppUser> AppUsers { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseMySQL("server=localhost;port=3306;user=Ibrahem;password=123456;database=Clam;Convert Zero Datetime=True;");
        optionsBuilder.UseSqlServer("Server=localhost;Database=mataa;Encrypt=False;Trusted_Connection=True;");
    }

}
 
