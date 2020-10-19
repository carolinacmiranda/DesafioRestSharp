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
    public class AddProjectVersionIncompleteTests : TestBase
    {
        [Test]
        [Obsolete]
        public void AdicionarVersãoSemNomeEmProjeto()
        {
            string statusCodeEsperado = "BadRequest";

            AddProjectVersionIncompleteRequest addProjectVersionIncompleteRequest = new AddProjectVersionIncompleteRequest();
            addProjectVersionIncompleteRequest.setJsonBodyIncomplete();
            IRestResponse<dynamic> response = addProjectVersionIncompleteRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}