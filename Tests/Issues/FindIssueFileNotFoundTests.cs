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
    public class FindIssueFileNotFoundTests : TestBase
    {
        [Test]
        [Obsolete]
        public void BuscarProblemaExistenteComArquivoInexistente()
        {
            string issue_id = "1";
            string file_id = "100";
            string statusCodeEsperado = "OK";

            FindIssueFileNotFoundRequest findIssueFileNotFoundRequest = new FindIssueFileNotFoundRequest(issue_id, file_id);

            IRestResponse<dynamic> response = findIssueFileNotFoundRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}