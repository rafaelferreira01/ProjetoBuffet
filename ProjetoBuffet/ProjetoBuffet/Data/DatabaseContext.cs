using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetoBuffet.Models.Acesso;
using ProjetoBuffet.Models.Buffet.Cliente;
using ProjetoBuffet.Models.Buffet.Evento;

namespace ProjetoBuffet.Data
{
        public class DatabaseContext : IdentityDbContext<Usuario, Papel, Guid>
        {
                public DbSet<ClienteEntity> Clientes { get; set; }
                public DbSet<EventoEntity> Eventos { get; set; }
                
                public DatabaseContext(DbContextOptions<DatabaseContext> options)
                :base(options)
                {
                }
        }
}