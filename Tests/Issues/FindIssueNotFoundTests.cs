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
    public class FindIssueNotFoundTests : TestBase
    {
        [Test]
        [Obsolete]
        public void BuscarProblemaQueNãoExiste()
        {
            string id = "1000";
            string statusCodeEsperado = "NotFound";

            FindIssueNotFoundRequest findIssueNotFoundRequest = new FindIssueNotFoundRequest(id);

            IRestResponse<dynamic> response = findIssueNotFoundRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}