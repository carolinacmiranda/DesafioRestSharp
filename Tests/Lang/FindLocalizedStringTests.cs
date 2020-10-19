using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests.Lang;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Tests.Lang
{    
    [TestFixture]
    public class FindLocalizedStringTests : TestBase
    {
        [Test, Order(27)]
        [Obsolete]
        public void BuscarSequenciaLocalizada()
        {
            string all_projects = "all_projects";
            string statusCodeEsperado = "OK";

            FindLocalizedStringRequest findLocalizedStringRequest = new FindLocalizedStringRequest(all_projects);

            IRestResponse<dynamic> response = findLocalizedStringRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}