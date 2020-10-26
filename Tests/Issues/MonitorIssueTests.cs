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
    public class MonitorIssueTests : TestBase
    {
        [Test, Order(11)]
        [Obsolete]
        public void MonitorarProblemaExistente()
        {
            string id = "12";
            string statusCodeEsperado = "Created";

            MonitorIssueRequest monitorIssueRequest = new MonitorIssueRequest(id);

            IRestResponse<dynamic> response = monitorIssueRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}