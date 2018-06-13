using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoCompras.Models
{
    public class Fornecedor
    {
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
        public virtual List<CabecalhoOrdemDeCompras> CabecalhoOrdemCompra { get; set; }
    }
}