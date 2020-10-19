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
    public class DelIssueNoteCopyNotFoundTests : TestBase
    {
        [Test]
        [Obsolete]
        public void DeletarCopiaDaNotaQueNãoExiste()
        {
            string issue_id = "22";
            string relationship_id = "0";
            string statusCodeEsperado = "BadRequest";

            DelIssueNoteCopyNotFoundRequest delIssueNoteCopyNotFoundRequest = new DelIssueNoteCopyNotFoundRequest(issue_id, relationship_id);

            IRestResponse<dynamic> response = delIssueNoteCopyNotFoundRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}