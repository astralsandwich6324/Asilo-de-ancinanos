using Microsoft.EntityFrameworkCore;
using Asilo_de_ancianos.Components.Models;

namespace Asilo_de_ancianos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> CollecionUsuarios { get; set; }
    }
}
