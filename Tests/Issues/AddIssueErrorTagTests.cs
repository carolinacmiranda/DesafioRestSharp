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
    public class AddIssueErrorTagTests : TestBase
    {
        [Test]
        [Obsolete]
        public void AnexarTagComErroNoProblema()
        {
            string statusCodeEsperado = "BadRequest";

            AddIssueErrorTagRequest addIssueErrorTagRequest = new AddIssueErrorTagRequest();
            addIssueErrorTagRequest.setJsonBodyError();
            IRestResponse<dynamic> response = addIssueErrorTagRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}