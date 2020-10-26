using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests.Issues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpNetCoreTemplate.Tests.Issues
{
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class AddIssueIncompleteSummaryTests : TestBase
    {
        [Test]
        [Obsolete]
        public void AdicionarProblemaSemSumário()
        {
            string statusCodeEsperado = "BadRequest";

            AddIssueRequest addIssueRequest = new AddIssueRequest();
            addIssueRequest.setJsonBodyIncompleteSummary();
            IRestResponse<dynamic> response = addIssueRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}