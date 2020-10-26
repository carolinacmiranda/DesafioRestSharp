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
    public class FindAllIssuesTests : TestBase
    {
        [Test, Order(15)]
        [Obsolete]
        public void BuscarTodosOsProblemasExistentes()
        {
            string page_size = "1";
            string page = "8";
            string statusCodeEsperado = "OK";

            FindAllIssuesRequest findAllIssuesRequest = new FindAllIssuesRequest(page_size, page);

            IRestResponse<dynamic> response = findAllIssuesRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}