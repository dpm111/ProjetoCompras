using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoCompras.Models
{
    public class MetodoDeEnvio
    {
        [Key]
        public int MetodoEnvioID { get; set; }
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        public decimal MetodoBase { get; set; }
        public decimal MetodoRate { get; set; }
        public Guid rowguid { get; set; }
        public DateTime DataModificacao { get; set; }
        public virtual List<CabecalhoOrdemDeCompras> CabecalhoOrdemCompra { get; set; }
    }
}