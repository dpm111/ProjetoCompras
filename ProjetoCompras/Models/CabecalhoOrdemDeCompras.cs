using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoCompras.Models
{
    public class CabecalhoOrdemDeCompras
    {
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
        public Fornecedor Fornecedor { get; set; }
        public List<DetalhesDoPedido> DetalhesPedidos { get; set; }
    }
}