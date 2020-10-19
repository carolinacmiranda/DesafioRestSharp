using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using RestSharpNetCoreTemplate.Requests.Users;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using RestSharp;
using System.Collections;

namespace RestSharpNetCoreTemplate.Tests.DDT

{
    [TestFixture]
    public class DataDrivenUsersTests : TestBase
    {
        AddUserRequest addUserRequest = new AddUserRequest();
        public static IEnumerable CadastrarUsuariosProvider()
        {
        return GeneralHelpers.ReturnCSVData(GeneralHelpers.ReturnProjectPath() + "Resources/TestData/CadastrarUsuarios.csv");
        }

        [Test, TestCaseSource("CadastrarUsuariosProvider")]
        [Obsolete]
        public void CadastrarUsuariosDDT(ArrayList testData)
        {
            string statusCodeEsperado = "BadRequest";

            string username = testData[0].ToString();
            string password = testData[1].ToString();
            string realName = testData[2].ToString();
            string email = testData[3].ToString();

            addUserRequest.setJsonBody();

            IRestResponse<dynamic> response = addUserRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}

