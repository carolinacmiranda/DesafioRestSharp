using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Tests.Config
{   
    [TestFixture]
    public class FindConfigTests : TestBase
    {
        [Test]
        [Obsolete]
        public void BuscarConfiguracao()
        {
            var csv = "csv_separator";
            var statusCodeEsperado = "OK";

            FindConfigRequest findConfigRequest = new FindConfigRequest(csv);

            IRestResponse<dynamic> response = findConfigRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}