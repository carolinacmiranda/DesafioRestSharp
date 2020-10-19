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
    public class AddIssueIncompleteDescriptionTests : TestBase
    {
        [Test]
        [Obsolete]
        public void AdicionarProblemaSemDescrição()
        {
            string statusCodeEsperado = "BadRequest";

            AddIssueRequest addIssueRequest = new AddIssueRequest();
            addIssueRequest.setJsonBodyIncompleteDescription();
            IRestResponse<dynamic> response = addIssueRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}