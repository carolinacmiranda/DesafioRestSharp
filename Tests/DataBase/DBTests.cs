using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.DBSteps;
using RestSharpNetCoreTemplate.Helpers;
using RestSharpNetCoreTemplate.Requests.Projects;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace RestSharpNetCoreTemplate.Tests.DataBase
{
    [TestFixture]
    public class DBTests : TestBase

    {

        [SetUp]
        public void BeforeTest()
        {
            ProjectsDBSteps.AddNewProject("22");
        }
        
        [Test]
        [Obsolete]
        public void ValidarProjetoDB()
        {

            string statusEsperado = "OK";
            string id = "22";
            string description = "Mantis.  Report problems with the actual bug tracker here. (Do not remove this account)";
            
            FindProjectRequest findProjectRequest = new FindProjectRequest(id);
            RestSharp.IRestResponse<dynamic> response = findProjectRequest.ExecuteRequest();

            string descriptionResposta = response.Data["projects"][0]["description"];

            Assert.AreEqual(statusEsperado, response.StatusCode.ToString());
            Assert.AreEqual(description, descriptionResposta);
            
        }        
    }
}
