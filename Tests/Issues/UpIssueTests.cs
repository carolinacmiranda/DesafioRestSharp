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
    public class UpIssueTests : TestBase
    {
        [Test, Order(12)]
        [Obsolete]
        public void AtualizarProblemaExistente()
        {
            string statusCodeEsperado = "OK";

            UpIssueRequest upIssueRequest = new UpIssueRequest();
            upIssueRequest.setJsonBody();
            IRestResponse<dynamic> response = upIssueRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}