using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Tests.Model.Produtos
{
    class Produto
    {
        public String ProdutoID { get; set; }
        public String Nome { get; set; }
        public String NumeroProduto { get; set; }
        public String MakeFlag { get; set; }
        public String FinishedGoodsFlag { get; set; }
        public String Cor { get; set; }
        public String Tamanho { get; set; }
        public String LinhaProduto { get; set; }
        public String DiasManufatura { get; set; }
        public String Classe { get; set; }
        public String Estilo { get; set; }
        public String DataModificacao { get; set; }
    }
}
