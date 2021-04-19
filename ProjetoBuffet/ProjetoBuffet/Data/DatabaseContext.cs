using Microsoft.EntityFrameworkCore;
using ProjetoBuffet.Models.Buffet.Cliente;
using ProjetoBuffet.Models.Buffet.Evento;

namespace ProjetoBuffet.Data
{
        public class DatabaseContext : DbContext
        {
                public DbSet<ClienteEntity> Clientes { get; set; }
                public DbSet<EventoEntity> Eventos { get; set; }
                
                public DatabaseContext(DbContextOptions<DatabaseContext> options)
                :base(options)
                {
                }
        }
}