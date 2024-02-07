
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp5;
public class Connection : DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<UserImage> UserImages { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=K-405-5\SQLEXPRESS; 
                                      Initial Catalog=StepBook;
                                      Integrated Security=true;
                                      TrustServerCertificate=Yes;");
    }
}

