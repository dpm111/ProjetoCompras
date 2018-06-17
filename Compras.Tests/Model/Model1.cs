namespace Compras.Tests.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Context")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<CabecalhoOrdemDeCompras> CabecalhoOrdemDeCompras { get; set; }
        public virtual DbSet<DetalhesDoPedidoes> DetalhesDoPedidoes { get; set; }
        public virtual DbSet<Fornecedors> Fornecedors { get; set; }
        public virtual DbSet<MetodoDeEnvios> MetodoDeEnvios { get; set; }
        public virtual DbSet<ProdutoFornecedors> ProdutoFornecedors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CabecalhoOrdemDeCompras>()
                .HasMany(e => e.DetalhesDoPedidoes)
                .WithOptional(e => e.CabecalhoOrdemDeCompras)
                .HasForeignKey(e => e.CabecalhoOrdemCompra_PedidoDaCompraID);

            modelBuilder.Entity<Fornecedors>()
                .HasMany(e => e.CabecalhoOrdemDeCompras)
                .WithOptional(e => e.Fornecedors)
                .HasForeignKey(e => e.Fornecedor_UnidadeDeNegocioID);

            modelBuilder.Entity<MetodoDeEnvios>()
                .HasMany(e => e.CabecalhoOrdemDeCompras)
                .WithOptional(e => e.MetodoDeEnvios)
                .HasForeignKey(e => e.MetodoDeEnvio_MetodoEnvioID);
        }
    }
}
