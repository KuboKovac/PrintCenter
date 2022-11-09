using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API;

public class UserContext: DbContext
{
    public DbSet<User> User { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data source=user.db");
}