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
    public class AddUserIncompleteTests : TestBase
    {
        [Test]
        [Obsolete]
        public void AdicionarUsuarioIncompleto()
        {
            string statusCodeEsperado = "BadRequest";

            AddUserRequest addUserRequest = new AddUserRequest();
            addUserRequest.setJsonBodyIncomplete();
            IRestResponse<dynamic> response = addUserRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}