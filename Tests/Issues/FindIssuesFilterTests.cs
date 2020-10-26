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
    public class FindIssuesFilterTests : TestBase
    {
        [Test, Order(17)]
        [Obsolete]
        public void BuscarFiltroDeProblemasExistentes()
        {
            string id = "1";
            string statusCodeEsperado = "OK";

            FindIssuesFilterRequest findIssuesFilterRequest = new FindIssuesFilterRequest(id);

            IRestResponse<dynamic> response = findIssuesFilterRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}