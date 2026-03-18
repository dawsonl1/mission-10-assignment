using Microsoft.EntityFrameworkCore;

namespace backend.data;

public class BowlerDbContext : DbContext
{
    public BowlerDbContext(DbContextOptions<BowlerDbContext> options) : base(options)
    {
    }
    
    public DbSet<Bowler> Bowlers { get; set; }
    public DbSet<Team> Teams { get; set; }
}