using blog_api.Models;
using Microsoft.EntityFrameworkCore;

namespace blog_api.Database;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options) 
{
    DbSet<User> Users {get; set;}
    DbSet<UserPersona> UserPersonas {get; set;}
    DbSet<Post> Posts {get; set;}
    DbSet<PostLocalized> PostLocalizeds {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasQueryFilter(item => item.IsDeleted == false);
        modelBuilder.Entity<UserPersona>().HasQueryFilter(item => item.IsDeleted == false);
        modelBuilder.Entity<Post>().HasQueryFilter(item => item.IsDeleted == false);
        modelBuilder.Entity<PostLocalized>().HasQueryFilter(item => item.IsDeleted == false);

        base.OnModelCreating(modelBuilder);
    }
}