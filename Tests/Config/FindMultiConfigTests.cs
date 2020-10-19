using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests.Config;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace RestSharpNetCoreTemplate.Tests.Config
{
    [TestFixture]
    public class FindMultiConfigTests : TestBase
    {
        [Test]
        [Obsolete]
        public void BuscarMultiplasConfiguracoes()
        {
            var csv = "csv_separator";
            var statusCodeEsperado = "OK";

            FindMultiConfigRequest findMultiConfigRequest = new FindMultiConfigRequest(csv);

            IRestResponse<dynamic> response = findMultiConfigRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}