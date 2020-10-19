using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests.Projects;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Tests.Projects
{    
    [TestFixture]
    public class FindProjectTests : TestBase
    {
        [Test, Order(4)]
        [Obsolete]
        public void BuscarProjetoExistente()
        {
            string id = "10";
            string statusCodeEsperado = "OK";

            FindProjectRequest findProjectRequest = new FindProjectRequest(id);

            IRestResponse<dynamic> response = findProjectRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}