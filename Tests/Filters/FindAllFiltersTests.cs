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
    public class FindAllFiltersTests : TestBase
    {
        [Test]
        [Obsolete]
        public void BuscarTodosOsFiltrosExistentes()
        {
            var filters = "filters";
            var statusCodeEsperado = "OK";

            FindAllFiltersRequest findAllFiltersRequest = new FindAllFiltersRequest(filters);

            IRestResponse<dynamic> response = findAllFiltersRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}