using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoCompras.Models
{
    public class DetalhesDoPedido
    {
        [Key]
        public int DetalhesPedidoID { get; set; }
        public DateTime DataVencimento { get; set; }
        public short QtdOrdem { get; set; }
        public int ProdutoID { get; set; }
        public decimal PrecoUnidade { get; set; }
        public decimal LinhaTotal { get; set; }
        public decimal QtdRecebido { get; set; }
        public decimal QtdRejeitado { get; set; }
        public decimal StockedQty { get; set; }
        public DateTime DataModificacao { get; set; }
        public CabecalhoOrdemDeCompras CabecalhoOrdemCompra { get; set; }
    }
}