using Microsoft.EntityFrameworkCore;
using ProjetoBuffet.Models.Buffet.Cliente;

namespace ProjetoBuffet.Data
{
        public class DatabaseContext : DbContext
        {
                public DbSet<ClienteEntity> Clientes { get; set; }
                
                public DatabaseContext(DbContextOptions<DatabaseContext> options)
                :base(options)
                {
                }
        }
}