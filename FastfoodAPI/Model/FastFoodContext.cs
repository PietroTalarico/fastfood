using Microsoft.EntityFrameworkCore;

namespace FastFoodAPI.Model
{
    public class FastFoodContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Piatto> Piatto { get; set; }
        public FastFoodContext(DbContextOptions<FastFoodContext> options) : base(options)
        {

        }
    }
}
