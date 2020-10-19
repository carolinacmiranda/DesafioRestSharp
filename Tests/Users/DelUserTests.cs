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
    public class DelUserTests : TestBase
    {
        [Test, Order(2)]
        [Obsolete]
        public void DeletarUsuarioExistente()
        {
            string id = "2";
            string statusCodeEsperado = "NoContent";

            DelUserRequest delUserRequest = new DelUserRequest(id);

            IRestResponse<dynamic> response = delUserRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}