using API.Models;

namespace API;

public class PrintCenterDbContext : DbContext
{
    public PrintCenterDbContext(DbContextOptions<PrintCenterDbContext> options) : base(options) { }

    public DbSet<User> Users => Set<User>();
    public DbSet<OrderHistory> Orderhistory => Set<OrderHistory>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<ProductBrand> ProductBrands => Set<ProductBrand>();
    public DbSet<ProductCategory> ProductCategories => Set<ProductCategory>();
} 