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
    public class FindProjectNotFoundTests : TestBase
    {
        [Test]
        [Obsolete]
        public void BuscarProjetoQueNãoExiste()
        {
            string id = "100";
            string statusCodeEsperado = "NotFound";

            FindProjectNotFoundRequest findProjectNotFoundRequest = new FindProjectNotFoundRequest(id);

            IRestResponse<dynamic> response = findProjectNotFoundRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}