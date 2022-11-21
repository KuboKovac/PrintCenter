using API.Models;

namespace API;

public class UserContext: DbContext
{
    public UserContext(DbContextOptions<UserContext> options) : base(options)
    {
        
    }

    public DbSet<User> Users => Set<User>();
} 