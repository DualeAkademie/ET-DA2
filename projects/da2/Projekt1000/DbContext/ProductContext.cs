using Microsoft.EntityFrameworkCore;
using Projekt1000.DbModel;

namespace Projekt1000.DbContext;
public class ProductContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DbSet<Product>? Products { get; set; }
    public DbSet<Category>? Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=products.db");
}
