namespace Project.API.Data.DbContext;

using Microsoft.EntityFrameworkCore;
using Entities;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; } //initialisation of the SQL Table

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseNpgsql("Host=127.0.0.1;Port=5432;Database=mydb;Username=myuser;Password=mypassword");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // User table configuration
        modelBuilder.Entity<User>(entity =>
        {
            // Make email unique
            entity.HasIndex(u => u.Email).IsUnique();

            // Set required fields + max lengths
            entity.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(255);
        });
    }


}
