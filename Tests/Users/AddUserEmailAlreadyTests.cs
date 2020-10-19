using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpNetCoreTemplate.Tests.Users
{
    [TestFixture]
    public class AddUserEmailAlreadyTests : TestBase
    {
        [Test]
        [Obsolete]
        public void AdicionarUsuarioComEmailExistente()
        {
            string statusCodeEsperado = "BadRequest";

            AddUserRequest addUserRequest = new AddUserRequest();
            addUserRequest.setJsonBodyUserEmail();
            IRestResponse<dynamic> response = addUserRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}