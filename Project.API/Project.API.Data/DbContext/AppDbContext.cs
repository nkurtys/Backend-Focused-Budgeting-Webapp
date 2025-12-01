namespace Project.API.Data.DbContext;

using Microsoft.EntityFrameworkCore;
using Project.API.Data.Entities;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseNpgsql("Host=127.0.0.1;Port=5432;Database=mydb;Username=myuser;Password=mypassword");
}
