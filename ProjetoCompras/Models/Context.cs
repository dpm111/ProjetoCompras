namespace ProjetoCompras.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<CabecalhoOrdemDeCompras> CabecalhoOrdemDeCompras { get; set; }
        public virtual DbSet<DetalhesDoPedido> DetalhesDoPedidos { get; set; }
        public virtual DbSet<Fornecedor> Fornecedores { get; set; }
        public virtual DbSet<MetodoDeEnvio> MetodoDeEnvios { get; set; }
        public virtual DbSet<ProdutoFornecedor> ProdutoFornecedores { get; set; }
    }
}
