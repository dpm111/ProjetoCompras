namespace Compras.Tests.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CabecalhoOrdemDeCompras
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CabecalhoOrdemDeCompras()
        {
            DetalhesDoPedidoes = new HashSet<DetalhesDoPedidoes>();
        }

        [Key]
        public int PedidoDaCompraID { get; set; }

        public byte NumeroRevisao { get; set; }

        public byte Status { get; set; }

        public int EmpregadoId { get; set; }

        public DateTime DataEnvio { get; set; }

        public decimal SubTotal { get; set; }

        public decimal TaxAmt { get; set; }

        public decimal Frete { get; set; }

        public decimal TotalDevido { get; set; }

        public DateTime DataModificacao { get; set; }

        public DateTime? DataDespachada { get; set; }

        public int CodigoFornecedor { get; set; }

        public int? Fornecedor_UnidadeDeNegocioID { get; set; }

        public int? MetodoDeEnvio_MetodoEnvioID { get; set; }

        public virtual Fornecedors Fornecedors { get; set; }

        public virtual MetodoDeEnvios MetodoDeEnvios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalhesDoPedidoes> DetalhesDoPedidoes { get; set; }
    }
}
