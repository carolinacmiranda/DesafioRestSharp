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
    public class FindMultiLocalizedStringsTests : TestBase
    {
        [Test, Order(28)]
        [Obsolete]
        public void BuscarMultiplasSequenciasLocalizadas()
        {
            string all_projects = "all_projects";
            string statusCodeEsperado = "OK";

            FindMultiLocalizedStringsRequest findMultiLocalizedStringsRequest = new FindMultiLocalizedStringsRequest(all_projects);

            IRestResponse<dynamic> response = findMultiLocalizedStringsRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}