using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Tests.Pages
{    
    [TestFixture]
    public class FindIssuePageTests : TestBase
    {
        [Test, Order(29)]
        [Obsolete]
        public void BuscarPagina()
        {
            string id = "25";
            string statusCodeEsperado = "OK";

            FindIssuePageRequest findIssuePageRequest = new FindIssuePageRequest(id);

            IRestResponse<dynamic> response = findIssuePageRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}