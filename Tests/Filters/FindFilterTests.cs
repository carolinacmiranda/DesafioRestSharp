using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Tests.Filters
{   
    [TestFixture]
    public class FindFilterTests : TestBase
    {
        [Test]
        [Obsolete]
        public void BuscarFiltroExistente()
        {
            var id = "3";
            var statusCodeEsperado = "OK";

            FindFilterRequest findFilterRequest = new FindFilterRequest(id);

            IRestResponse<dynamic> response = findFilterRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}