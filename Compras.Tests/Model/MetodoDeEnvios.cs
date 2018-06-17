namespace Compras.Tests.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MetodoDeEnvios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MetodoDeEnvios()
        {
            CabecalhoOrdemDeCompras = new HashSet<CabecalhoOrdemDeCompras>();
        }

        [Key]
        public int MetodoEnvioID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        public decimal MetodoBase { get; set; }

        public decimal MetodoRate { get; set; }

        public Guid rowguid { get; set; }

        public DateTime DataModificacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CabecalhoOrdemDeCompras> CabecalhoOrdemDeCompras { get; set; }
    }
}
