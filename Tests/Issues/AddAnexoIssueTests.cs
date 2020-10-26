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
    public class AddAnexoIssueTests : TestBase
    {
        [Test, Order(9)]
        [Obsolete]
        public void AdicionarAnexoNoProblema()
        {
            string statusCodeEsperado = "Created";

            AddAnexoIssueRequest addAnexoIssueRequest = new AddAnexoIssueRequest();
            addAnexoIssueRequest.setJsonBody();
            IRestResponse<dynamic> response = addAnexoIssueRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}