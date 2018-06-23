using System;
using System.Collections.Generic;
using Compras.Tests.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.IO;
using System.Web;
using System.Web.Script.Serialization;
using Microsoft.CSharp;
using System.Reflection;
using Compras.Tests.Model.Produtos;
using Compras.Tests.Model.RecursosHumanos;
using Compras.Tests.Model.Vendas;

namespace Compras.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private Model1 db = new Model1();
        [TestMethod]
        public void TestMethod1()
        {
            //Métodos GET
            #region GET 
            #region Pessoas
            //    #region comentar
            //    string responseString = string.Empty;
            //    using (var webClient = new WebClient())
            //    {
            //        responseString = webClient.DownloadString("http://localhost:8082/entidadeDeNegocio");
            //    }
            //    string texto = responseString.Replace("{\r\n  \"_embedded\" : {\r\n    \"entidadeDeNegocio\" : ", "").Replace("\r\n  },\r\n  \"_links\" : {\r\n    \"self\" : {\r\n      \"href\" : \"http://localhost:8082/entidadeDeNegocio\"\r\n    },\r\n    \"profile\" : {\r\n      \"href\" : \"http://localhost:8082/profile/entidadeDeNegocio\"\r\n    }\r\n  }\r\n}", "");
            //    JavaScriptSerializer serializer = new JavaScriptSerializer();
            //    var jsonObject = serializer.Deserialize<dynamic>(texto);

            //    List<EntidadeDeNegocio> entidades = new List<EntidadeDeNegocio>();
            //    foreach (var value in jsonObject)
            //    {
            //        int i = 0;
            //        EntidadeDeNegocio entidade = new EntidadeDeNegocio();
            //        //dentro de um objeto acessando cada item            
            //        foreach (KeyValuePair<string, object> entry in value)
            //        {
            //            if (i == 0)
            //                entidade.rowguid = entry.Value as string;
            //            else if (i == 1)
            //                entidade.Businessentityid = entry.Value.ToString();
            //            else if (i == 2)
            //            {
            //                entidade.DataModificacao = entry.Value as string;
            //            }
            //            else
            //                continue;
            //            i++;
            //        }
            //        entidades.Add(entidade);
            //    }        
            //}   

            //    #endregion comentar
            #endregion Pessoas
            #region Produtos
            #region comentar
            #region UnidadeMedida
            string responseString = string.Empty;
            using (var webClient = new WebClient())
            {
                responseString = webClient.DownloadString("http://localhost:8083/unidademedidas");
            }
            string texto = responseString.Replace("{\r\n  \"_embedded\" : {\r\n    \"unidademedidas\" : ", "").Replace("\r\n  },\r\n  \"_links\" : {\r\n    \"self\" : {\r\n      \"href\" : \"http://localhost:8083/unidademedidas\"\r\n    },\r\n    \"profile\" : {\r\n      \"href\" : \"http://localhost:8083/profile/unidademedidas\"\r\n    }\r\n  }\r\n}", "");
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var jsonObject = serializer.Deserialize<dynamic>(texto);

            List<UnidadeMedida> unidadeMedidas = new List<UnidadeMedida>();
            foreach (var value in jsonObject)
            {
                int i = 0;
                UnidadeMedida u = new UnidadeMedida();
                //dentro de um objeto acessando cada item            
                foreach (KeyValuePair<string, object> entry in value)
                {
                    if (i == 0)
                        u.DataModificacao = entry.Value as string;
                    else if (i == 1)
                        u.Nome = entry.Value as string;
                    else
                        continue;
                    i++;
                }
                unidadeMedidas.Add(u);
            }
        

            #endregion UnidadeMedida
            #region produto
        //string responseString = string.Empty;
        //    using (var webClient = new WebClient())
        //    {
        //        responseString = webClient.DownloadString("http://localhost:8083/produtos");
        //    }
        //    string texto = responseString.Replace("{\r\n  \"_embedded\" : {\r\n    \"produtos\" : ", "").Replace("\r\n  },\r\n  \"_links\" : {\r\n    \"self\" : {\r\n      \"href\" : \"http://localhost:8083/produtos\"\r\n    },\r\n    \"profile\" : {\r\n      \"href\" : \"http://localhost:8083/profile/produtos\"\r\n    }\r\n  }\r\n}", "");
        //    JavaScriptSerializer serializer = new JavaScriptSerializer();
        //    var jsonObject = serializer.Deserialize<dynamic>(texto);

        //    List<Produto> produtos = new List<Produto>();
        //    foreach (var value in jsonObject)
        //    {
        //        int i = 0;
        //        Produto produto = new Produto();
        //        //dentro de um objeto acessando cada item            
        //        foreach (KeyValuePair<string, object> entry in value)
        //        {
        //            if (i == 0)
        //                produto.ProdutoID = entry.Value as string;
        //            else if (i == 1)
        //                produto.DiasManufatura = entry.Value as string;
        //            else if (i == 2)
        //                produto.DataModificacao = entry.Value as string;
        //            else if (i == 3)
        //                produto.Nome = entry.Value as string;
        //            else if (i == 4)
        //                produto.NumeroProduto = entry.Value as string;
        //            else if (i == 5)
        //                produto.MakeFlag = entry.Value as string;
        //            else if (i == 6)
        //                produto.Tamanho = entry.Value as string;
        //            else if (i == 7)
        //                produto.Cor = entry.Value as string;
        //            else if (i == 8)
        //                produto.LinhaProduto = entry.Value as string;
        //            else if (i == 9)
        //                produto.Estilo = entry.Value as string;
        //            else if (i == 10)
        //                produto.Classe = entry.Value as string;
        //            else if (i == 11)
        //                produto.FinishedGoodsFlag = entry.Value as string;
        //            else
        //                continue;
        //            i++;
        //        }
        //        produtos.Add(produto);
        //    }
            #endregion produto
            #endregion comentar
            #endregion Produtos
            #region RH
            //#region comentar
            //string responseString = string.Empty;
            //using (var webClient = new WebClient())
            //{
            //    responseString = webClient.DownloadString("http://localhost:8084/recursoshumanos");
            //}
            //string texto = responseString.Replace("{\r\n  \"_embedded\" : {\r\n    \"recursoshumanos\" : ", "").Replace("\r\n  },\r\n  \"_links\" : {\r\n    \"self\" : {\r\n      \"href\" : \"http://localhost:8084/recursoshumanos\"\r\n    },\r\n    \"profile\" : {\r\n      \"href\" : \"http://localhost:8084/profile/recursoshumanos\"\r\n    }\r\n  }\r\n}", "");
            //JavaScriptSerializer serializer = new JavaScriptSerializer();
            //var jsonObject = serializer.Deserialize<dynamic>(texto);

            //List<Funcionario> funcionarios = new List<Funcionario>();
            //foreach (var value in jsonObject)
            //{
            //    int i = 0;
            //    Funcionario funcionario = new Funcionario();
            //    //dentro de um objeto acessando cada item            
            //    foreach (KeyValuePair<string, object> entry in value)
            //    {
            //        if (i == 0)
            //            funcionario.rowguid = entry.Value as string;
            //        else if (i == 1)
            //            funcionario.EntidadeDeNegocio = (int)entry.Value;
            //        else if (i == 2)
            //            funcionario.OrganizacaoNivel = (int)entry.Value;
            //        else if (i == 3)
            //            funcionario.StatusRelacionamento = entry.Value as string;
            //        else if (i == 4)
            //            funcionario.HorasLicencaMedica = (int)entry.Value;
            //        else if (i == 5)
            //            funcionario.AssalariadoFlag = (bool)entry.Value;
            //        else if (i == 6)
            //            funcionario.TrabalhandoFlag = (bool)entry.Value;
            //        else if (i == 7)
            //            funcionario.Documento = entry.Value as string;
            //        else if (i == 8)
            //            funcionario.DataContratacao = (int)entry.Value;
            //        else if (i == 9)
            //            funcionario.DataNascimento = entry.Value as string;
            //        else if (i == 10)
            //            funcionario.PostoDeTrabalho = entry.Value as string;
            //        else if (i == 11)
            //            funcionario.IdLogin = entry.Value as string;
            //        else if (i == 12)
            //            funcionario.HorasFerias = (int)entry.Value;
            //        else if (i == 13)
            //            funcionario.Sexo = entry.Value as string;
            //        else if (i == 14)
            //            funcionario.OrganizacaoNode = entry.Value as string;
            //        else if (i == 15)
            //            funcionario.DataModificacao = entry.Value as string;
            //        else
            //            continue;
            //        i++;
            //    }
            //    funcionarios.Add(funcionario);
            //}

            //#endregion comentar
            #endregion RH
            #endregion GET 
            //Métodos POST
            #region POST            
            #region Vendas
            //#region comentar
            //var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8085/vendas");
            //httpWebRequest.ContentType = "application/json";
            //httpWebRequest.Method = "POST";

            //using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            //{
            //    CabecalhoOrdemCompras ca = new CabecalhoOrdemCompras();
            //    ca.id = 3;
            //    ca.MetodoDeEnvio_MetodoEnvioID = 2;
            //    ca.NumeroRevisao = 4;
            //    ca.PedidoDaCompraID = 2;
            //    ca.Status = 1;
            //    ca.SubTotal = "99,80";
            //    ca.TaxAmt = "axt";
            //    ca.TotalDevido = "100,00";
            //    var jSerializer = new JavaScriptSerializer();
            //    string jsonString = jSerializer.Serialize(ca);
            //    //string json = "{\"nome\":\"fefefegggggg\"," +
            //    //           "\"sobrenome\":\"chagggggcha\"}";

            //    streamWriter.Write(jsonString);
            //    streamWriter.Flush();
            //    streamWriter.Close();
            //}

            //var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            //{
            //    var result = streamReader.ReadToEnd();
            //}
            //#endregion comentar
            #endregion Vendas
            #region Administrativo
            //#region comentar
            //#region DatabaseLog
            //var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8081/databaselog");
            //httpWebRequest.ContentType = "application/json";
            //httpWebRequest.Method = "POST";

            //using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            //{
            //    DatabaseLog dblog = new DatabaseLog();
            //    dblog.databaseLogID = 2;
            //    dblog.evento = "TesteEvento";
            //    dblog.horaPostagem = "18:40";
            //    dblog.objeto = "TesteUnitTest";
            //    dblog.schemaTB = "DatabaseLog";
            //    dblog.tsql = "select test from test";
            //    dblog.usuarioDB = "User";
            //    dblog.xmlarq = "<XML>";
            //    var jSerializer = new JavaScriptSerializer();
            //    string jsonString = jSerializer.Serialize(dblog);
            //    streamWriter.Write(jsonString);
            //    streamWriter.Flush();
            //    streamWriter.Close();
            //}
            //var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            //{
            //    var result = streamReader.ReadToEnd();
            //}
            //#endregion DatabaseLog
            //#region errorLog
            //var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8081/errorlog");
            //httpWebRequest.ContentType = "application/json";
            //httpWebRequest.Method = "POST";

            //using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            //{
            //    ErrorLog elog = new ErrorLog();
            //    elog.estadoDoErro = "fjenjenfjefnef";
            //    elog.linhaErro = "18";
            //    elog.mensagemErro = "kefmkegkengkengk";
            //    elog.nome = "fegegeg";
            //    elog.procedimentoErro = "efjefjefj";
            //    elog.numeroErro = "150";
            //    elog.procedimentoErro = "sair e entrar novamente";
            //    elog.severidade = "grave";
            //    elog.tempoErro = "15 dias";
            //    var jSerializer = new JavaScriptSerializer();
            //    string jsonString = jSerializer.Serialize(elog);
            //    streamWriter.Write(jsonString);
            //    streamWriter.Flush();
            //    streamWriter.Close();
            //}
            //var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            //{
            //    var result = streamReader.ReadToEnd();
            //}
            //#endregion errorLog
            //#endregion comentar
            #endregion Administrativo
            #endregion POST
        }
    }
}
