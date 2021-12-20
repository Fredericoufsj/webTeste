using Microsoft.EntityFrameworkCore;

namespace webTeste.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Voo> voos { get; set; }
        public DbSet<Contato> contatos { get; set; }
    }
    
}
