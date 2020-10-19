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
    [TestFixture]
    public class AddIssueTests : TestBase
    {
        [Test, Order(7)]
        [Obsolete]
        public void AdicionarProblema()
        {
            string statusCodeEsperado = "OK";

            AddIssueRequest addIssueRequest = new AddIssueRequest();
            addIssueRequest.setJsonBody();
            IRestResponse<dynamic> response = addIssueRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}