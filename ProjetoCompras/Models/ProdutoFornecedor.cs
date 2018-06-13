using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoCompras.Models
{
    public class ProdutoFornecedor
    {
        [Key]
        public int ProdutoID { get; set; }
        public int UnidadeDeNegocioID { get; set; }
        public int TempoMedio { get; set; }
        public decimal PrecoMedio { get; set; }
        public int QtdOrdemMin { get; set; }
        public int QtdOrdemMax { get; set; }
        [StringLength(3)]
        public string MediaUnitaria { get; set; }
        public DateTime DataModificacao { get; set; }
        public decimal? CustoRecebimento { get; set; }
        public DateTime? DataUltimoRecebimento { get; set; }
        public int? OnOrderQuantidade { get; set; }
    }
}