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
    public class FindIssuesNotToMeTests : TestBase
    {
        [Test, Order(21)]
        [Obsolete]
        public void BuscarProblemasNaoAtribuidos()
        {
            string notToMe = "unassigned";
            string statusCodeEsperado = "OK";

            FindIssuesNotToMeRequest findIssuesNotToMeRequest = new FindIssuesNotToMeRequest(notToMe);

            IRestResponse<dynamic> response = findIssuesNotToMeRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}