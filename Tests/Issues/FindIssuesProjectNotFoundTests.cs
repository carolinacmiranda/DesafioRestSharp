using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests.Issues;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Tests.Issues
{   
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class FindIssuesProjectNotFoundTests : TestBase
    {
        [Test]
        [Obsolete]
        public void BuscarProblemasParaUmProjetoQueNãoExiste()
        {
            string id = "100";
            string statusCodeEsperado = "NotFound";

            FindIssuesProjectNotFoundRequest findIssuesProjectNotFoundRequest = new FindIssuesProjectNotFoundRequest(id);

            IRestResponse<dynamic> response = findIssuesProjectNotFoundRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}