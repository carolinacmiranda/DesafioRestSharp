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
    public class DelIssueNoteCopyTests : TestBase
    {
        [Test, Order(22)]
        [Obsolete]
        public void DeletarCopiaDaNota()
        {
            string issue_id = "20";
            string relationship_id = "1";
            string statusCodeEsperado = "OK";

            DelIssueNoteCopyRequest delIssueNoteCopyRequest = new DelIssueNoteCopyRequest(issue_id, relationship_id);

            IRestResponse<dynamic> response = delIssueNoteCopyRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}