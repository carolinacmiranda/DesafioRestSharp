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
    public class AddProjectVersionAlreadyTests : TestBase
    {
        [Test]
        [Obsolete]
        public void AdicionarVersãoJáExistenteEmProjeto()
        {
            string statusCodeEsperado = "BadRequest";

            AddProjectVersionAlreadyRequest addProjectVersionAlreadyRequest = new AddProjectVersionAlreadyRequest();
            addProjectVersionAlreadyRequest.setJsonBody();
            IRestResponse<dynamic> response = addProjectVersionAlreadyRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}