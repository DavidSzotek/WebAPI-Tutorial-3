using Microsoft.EntityFrameworkCore;
using WebAPI_Tutorial_3.Models;

namespace WebAPI_Tutorial_3.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Backpack> Backpacks { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Faction> Factions { get; set; }
    }
}
