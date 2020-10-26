using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using RestSharpNetCoreTemplate.Requests.Issues;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestSharpNetCoreTemplate.Tests.NodeJS
{
    [TestFixture]
    class NodeJsTests : TestBase
    {
 
        [Test]
        [Obsolete]
        public void CadastrarProblemaComTagExecutandoNodeJS()
        {

            string statusCodeEsperado = "Created";

            AddIssueTagRequest addIssueTagRequest = new AddIssueTagRequest();
            addIssueTagRequest.setJsonBody();
            IRestResponse<dynamic> response = addIssueTagRequest.ExecuteRequest();          

            string nodeJs = GeneralHelpers.ExecutarScriptNodeJS();

            string text = "Anexando uma tag ao problema"+nodeJs;
            string name = "public"+nodeJs;

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());

            Console.WriteLine(response.Content);
            
        }
    }
}
