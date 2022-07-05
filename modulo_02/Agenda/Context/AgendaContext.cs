using Agenda.Models;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }


        //Relacionamento
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contato>().ToTable("contato");

            modelBuilder.Entity<Contato>()
                .HasOne(e =>e.Endereco)
                .WithMany(e=> e.Contatos)
                .HasForeignKey(e=> e.Endereco_Id);

            modelBuilder.Entity<Endereco>()
                .HasOne(e => e.UF)
                .WithMany(e => e.Enderecos)
                .HasForeignKey(e=>e.UF_Id);



            modelBuilder.Entity<Usuario>().ToTable("usuario");

        }

        //Definir comunicação com as tabela(s) do banco de dados;
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Endereco> Endereco { get; set; }

        public DbSet<UF> UF { get; set; }

        
    }
}
