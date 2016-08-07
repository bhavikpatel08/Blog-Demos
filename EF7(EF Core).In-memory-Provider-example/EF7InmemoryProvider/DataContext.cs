using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;

namespace EF7InmemoryProvider
{
public class DataContext : DbContext
{
    public DbSet<Employee> Employee { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        base.OnConfiguring(options);
    }
}
}
