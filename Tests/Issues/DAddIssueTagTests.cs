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
    public class DAddIssueTagTests : TestBase
    {
        [Test, Order(13)]
        [Obsolete]
        public void DesanexarTagNoProblema()
        {
            string statusCodeEsperado = "Created";

            DAddIssueTagRequest daddIssueTagRequest = new DAddIssueTagRequest();
            daddIssueTagRequest.setJsonBody();
            IRestResponse<dynamic> response = daddIssueTagRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}