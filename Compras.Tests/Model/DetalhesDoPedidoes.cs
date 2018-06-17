namespace Compras.Tests.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DetalhesDoPedidoes
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

        public int? CabecalhoOrdemCompra_PedidoDaCompraID { get; set; }

        public virtual CabecalhoOrdemDeCompras CabecalhoOrdemDeCompras { get; set; }
    }
}
