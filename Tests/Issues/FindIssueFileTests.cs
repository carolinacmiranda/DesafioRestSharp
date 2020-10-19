using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests.Issues;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Tests.Issues
{    
    [TestFixture]
    public class FindIssueFileTests : TestBase
    {
        [Test, Order(14)]
        [Obsolete]
        public void BuscarProblemaExistenteComArquivo()
        {
            string issue_id = "12";
            string file_id = "5";
            string statusCodeEsperado = "OK";

            FindIssueFileRequest findIssueFileRequest = new FindIssueFileRequest(issue_id, file_id);

            IRestResponse<dynamic> response = findIssueFileRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}