using CRUDMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDMVC.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Agencia> Agencias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-T41O7MH; Initial Catalog=CRUDMVC; Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(table => 
            {
                table.ToTable("Clientes");
                table.HasKey(prop => prop.idCliente);
                table.Property(prop => prop.nome).HasMaxLength(255).IsRequired();
                table.Property(prop => prop.cpf).HasColumnType("char(11)").IsRequired();
                table.Property(prop => prop.rg).HasColumnType("char(14)").IsRequired();
                table.Property(prop => prop.endereco).HasMaxLength(255).IsRequired();
            });
            modelBuilder.Entity<Destino>(table =>
            {
                table.ToTable("Destinos");
                table.HasKey(prop => prop.idDestino);
                table.Property(prop => prop.endereco).HasMaxLength(255).IsRequired();
                table.Property(prop => prop.nome).HasMaxLength(255).IsRequired();
                table.Property(prop => prop.preco).IsRequired();
                table.Property(prop => prop.qtdVagas).IsRequired();
            });
            modelBuilder.Entity<Agencia>(table =>
            {
                table.ToTable("Agencias");
                table.HasKey(prop => prop.idAgencia);
                table.Property(prop => prop.cnpj).HasColumnType("char(14)").IsRequired();
                table.Property(prop => prop.endereco).HasMaxLength(255).IsRequired();
                table.Property(prop => prop.telefone).HasColumnType("char(15)").IsRequired();
                table.Property(prop => prop.email).HasMaxLength(255).IsRequired();
            });
        }
    }
}