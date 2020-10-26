using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests.Projects;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Tests.Projects
{  
    [Parallelizable(ParallelScope.All)]  
    [TestFixture]
    public class FindAllProjectsTests : TestBase
    {
        [Test, Order(6)]
        [Obsolete]
        public void BuscarTodosOsProjetosExistentes()
        {
            string projects = "projects";
            string statusCodeEsperado = "OK";

            FindAllProjectsRequest findAllProjectsRequest = new FindAllProjectsRequest(projects);

            IRestResponse<dynamic> response = findAllProjectsRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}