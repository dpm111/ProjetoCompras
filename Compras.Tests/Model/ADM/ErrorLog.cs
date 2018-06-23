using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Tests.Model
{
    class ErrorLog
    {
        public int erroId { get; set; }
        public string tempoErro { get; set; }
        public string nome { get; set; }
        public string numeroErro { get; set; }
        public string severidade { get; set; }
        public string estadoDoErro { get; set; }
        public string procedimentoErro { get; set; }
        public string linhaErro     { get; set; }
        public string mensagemErro { get; set; }
    }
}
