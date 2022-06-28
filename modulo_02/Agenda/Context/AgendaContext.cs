using Agenda.Models;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contato>().ToTable("contato");
            modelBuilder.Entity<Usuario>().ToTable("usuario");
        }

        //Definir comunicação com as tabela(s) do banco de dados;
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
