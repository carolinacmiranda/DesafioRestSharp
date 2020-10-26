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
    public class FindIssuesReportedByMeTests : TestBase
    {
        [Test, Order(19)]
        [Obsolete]
        public void BuscarProblemasRelatadosPorMim()
        {
            string byMe = "reported";
            string statusCodeEsperado = "OK";

            FindIssuesReportedByMeRequest findIssuesReportedByMeRequest = new FindIssuesReportedByMeRequest(byMe);

            IRestResponse<dynamic> response = findIssuesReportedByMeRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}