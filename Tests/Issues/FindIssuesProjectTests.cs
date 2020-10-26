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
    public class FindIssuesProjectTests : TestBase
    {
        [Test, Order(16)]
        [Obsolete]
        public void BuscarProblemasParaUmProjeto()
        {
            string id = "0";
            string statusCodeEsperado = "OK";

            FindIssuesProjectRequest findIssuesProjectRequest = new FindIssuesProjectRequest(id);

            IRestResponse<dynamic> response = findIssuesProjectRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}