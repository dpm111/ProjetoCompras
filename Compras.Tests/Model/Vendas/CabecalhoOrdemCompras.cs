using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Tests.Model.Vendas
{
    class CabecalhoOrdemCompras
    {
        public int id { get; set; }
        public int PedidoDaCompraID { get; set; }
        public byte NumeroRevisao { get; set; }
        public byte Status { get; set; }
        public int EmpregadoId { get; set; }
        public string DataEnvio { get; set; }
        public string SubTotal { get; set; }
        public string TaxAmt { get; set; }
        public string Frete { get; set; }
        public string TotalDevido { get; set; }
        public string DataModificacao { get; set; }
        public string DataDespachada { get; set; }
        public int CodigoFornecedor { get; set; }
        public int Fornecedor_UnidadeDeNegocioID { get; set; }
        public int MetodoDeEnvio_MetodoEnvioID { get; set; }
    }
}
