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
    public class FindIssuesMonitoredByMeTests : TestBase
    {
        [Test, Order(20)]
        [Obsolete]
        public void BuscarProblemasMonitoradosPorMim()
        {
            string byMe = "monitored";
            string statusCodeEsperado = "OK";

            FindIssuesMonitoredByMeRequest findIssuesMonitoredByMeRequest = new FindIssuesMonitoredByMeRequest(byMe);

            IRestResponse<dynamic> response = findIssuesMonitoredByMeRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}