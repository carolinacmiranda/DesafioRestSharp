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
    public class AddAnexoErrorIssueTests : TestBase
    {
        [Test]
        [Obsolete]
        public void AdicionarAnexoComErroNoProblema()
        {
            string statusCodeEsperado = "BadRequest";

            AddAnexoErrorIssueRequest addAnexoErrorIssueRequest = new AddAnexoErrorIssueRequest();
            addAnexoErrorIssueRequest.setJsonBodyError();
            IRestResponse<dynamic> response = addAnexoErrorIssueRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}