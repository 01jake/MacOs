using Gym.Shared.Modelos;
using Microsoft.EntityFrameworkCore;

namespace GymBlazor.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
