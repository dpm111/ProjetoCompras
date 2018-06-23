using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Tests.Model.RecursosHumanos
{
    class Funcionario
    {
        public String Documento { get; set; }
        public String rowguid { get; set; }
        public String IdLogin { get; set; }
        public String OrganizacaoNode { get; set; }
        public int OrganizacaoNivel { get; set; }
        public String PostoDeTrabalho { get; set; }
        public String DataNascimento { get; set; }
        public String StatusRelacionamento { get; set; }
        public String Sexo { get; set; }
        public int DataContratacao { get; set; }
        public Boolean AssalariadoFlag { get; set; }
        public int HorasFerias { get; set; }
        public int HorasLicencaMedica { get; set; }
        public int EntidadeDeNegocio { get; set; }
        public Boolean TrabalhandoFlag { get; set; }
        public int LinhaGuia { get; set; }
        public String DataModificacao { get; set; }
    }
}
