using System;
using System.Collections.Generic;
using Compras.Tests.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Collections.Specialized;
using System.Text;
using System.IO;

namespace Compras.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private Model1 db = new Model1();
        [TestMethod]
        public void TestMethod1()
        {
            //teste POST
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8084/pessoas");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"nome\":\"jabuna\"," +
                              "\"sobrenome\":\"chacha\"}";

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }
    }
}
