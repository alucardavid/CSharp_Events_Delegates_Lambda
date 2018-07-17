namespace ByteBank.Agencias.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ByteBank : DbContext
    {
        public ByteBank()
            : base("name=ByteBank")
        {
        }

        public virtual DbSet<Agencia> Agencias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agencia>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<Agencia>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Agencia>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Agencia>()
                .Property(e => e.Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<Agencia>()
                .Property(e => e.Telefone)
                .IsUnicode(false);
        }
    }
}
