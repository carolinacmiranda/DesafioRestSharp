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
    public class FindIssuesToMeTests : TestBase
    {
        [Test, Order(18)]
        [Obsolete]
        public void BuscarProblemasAtribuidosaMim()
        {
            string toMe = "assigned";
            string statusCodeEsperado = "OK";

            FindIssuesToMeRequest findIssuesToMeRequest = new FindIssuesToMeRequest(toMe);

            IRestResponse<dynamic> response = findIssuesToMeRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}