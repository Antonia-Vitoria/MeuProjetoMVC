using Microsoft.EntityFrameworkCore;
namespace LHPet.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto>Options) : base(Options)
        {
            
        }
        public DbSet<Cliente> Cliente { get; set; }
    }
}
