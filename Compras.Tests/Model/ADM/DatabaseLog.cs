using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Tests.Model
{
    class DatabaseLog
    {
        public int databaseLogID { get; set; }
        public string horaPostagem { get; set; }
        public string usuarioDB { get; set; }
        public string evento { get; set; }
        public string schemaTB { get; set; }
        public string objeto { get; set; }
        public string tsql { get; set; }
        public string xmlarq { get; set; }
    }
}
