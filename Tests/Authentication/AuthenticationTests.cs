using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpNetCoreTemplate.Tests.Authentication
{
    [TestFixture]
    public class AuthenticationTests : TestBase
    {
        [Test]
        [Obsolete]
        public void Test_Authentication()
        {
            string statusCodeEsperado = "OK";

            AuthenticationRequest authenticationRequest = new AuthenticationRequest();
            authenticationRequest.setJsonBody();
            IRestResponse<dynamic> response = authenticationRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}