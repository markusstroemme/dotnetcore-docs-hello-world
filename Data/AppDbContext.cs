using Microsoft.EntityFrameworkCore;

namespace dotnetcoresample.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<CounterState> CounterStates => Set<CounterState>();
}