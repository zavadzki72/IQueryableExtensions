using Microsoft.EntityFrameworkCore;
using TeamAPI.Models;

namespace TeamAPI
{
    public class TeamDbContext : DbContext
    {
        public TeamDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Team> Teams { get; set; }
    }
}
