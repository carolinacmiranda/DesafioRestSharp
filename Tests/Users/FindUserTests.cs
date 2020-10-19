using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Tests.Users
{    
    [TestFixture]
    public class FindUserTests : TestBase
    {
        [Test, Order(1)]
        [Obsolete]
        public void BuscarUsuarioExistente()
        {
            string me = "me";
            string statusCodeEsperado = "OK";

            FindUserRequest findUserRequest = new FindUserRequest(me);

            IRestResponse<dynamic> response = findUserRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}

