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
    public class AddProjectTests : TestBase
    {
        [Test, Order(3)]
        [Obsolete]
        public void AdicionarProjeto()
        {
            string statusCodeEsperado = "OK";

            AddProjectRequest addProjectRequest = new AddProjectRequest();
            addProjectRequest.setJsonBody();
            IRestResponse<dynamic> response = addProjectRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}