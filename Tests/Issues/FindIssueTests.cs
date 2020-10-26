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
    public class FindIssueTests : TestBase
    {
        [Test, Order(10)]
        [Obsolete]
        public void BuscarProblemaExistente()
        {
            string id = "12";
            string statusCodeEsperado = "OK";

            FindIssueRequest findIssueRequest = new FindIssueRequest(id);

            IRestResponse<dynamic> response = findIssueRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}