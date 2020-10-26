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
    public class AddIssueTagTests : TestBase
    {
        [Test, Order(8)]
        [Obsolete]
        public void AnexarTagNoProblema()
        {
            string statusCodeEsperado = "Created";

            AddIssueTagRequest addIssueTagRequest = new AddIssueTagRequest();
            addIssueTagRequest.setJsonBody();
            IRestResponse<dynamic> response = addIssueTagRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}