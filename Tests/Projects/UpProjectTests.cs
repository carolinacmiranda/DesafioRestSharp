using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpNetCoreTemplate.Tests.Projects
{
    [TestFixture]
    public class UpProjectTests : TestBase
    {
        [Test, Order(5)]
        [Obsolete]
        public void AtualizarProjetoExistente()
        {
            string statusCodeEsperado = "OK";

            UpProjectRequest upProjectRequest = new UpProjectRequest();
            upProjectRequest.setJsonBody();
            IRestResponse<dynamic> response = upProjectRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}