namespace Compras.Tests.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fornecedors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fornecedors()
        {
            CabecalhoOrdemDeCompras = new HashSet<CabecalhoOrdemDeCompras>();
        }

        [Key]
        public int UnidadeDeNegocioID { get; set; }

        public int CodigoUnidadeDeNegocio { get; set; }

        [StringLength(15)]
        public string NumeroDaConta { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public byte ClasseCredito { get; set; }

        public bool PreferidoFornecedorStatus { get; set; }

        public bool FlagAtivo { get; set; }

        public DateTime DataModificacao { get; set; }

        public string ComprasWebServiceURL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CabecalhoOrdemDeCompras> CabecalhoOrdemDeCompras { get; set; }
    }
}
