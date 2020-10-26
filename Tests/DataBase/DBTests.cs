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
            ProjectsDBSteps.AddNewProject("30");
        }
        
        [Test]
        [Obsolete]
        public void ValidarProjetoDB()
        {
            string statusEsperado = "OK";
            string id = "30";
            
            FindProjectDBRequest findProjectDBRequest = new FindProjectDBRequest(id);
            RestSharp.IRestResponse<dynamic> response = findProjectDBRequest.ExecuteRequest();

            Assert.AreEqual(statusEsperado, response.StatusCode.ToString());
            
        } 

        [TearDown]
        public void AfterTest()
        {
            ProjectsDBSteps.DeleteNewProject();
        }       
    }
}
