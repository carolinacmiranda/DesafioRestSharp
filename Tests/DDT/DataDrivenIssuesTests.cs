using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using RestSharpNetCoreTemplate.Requests.Issues;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using RestSharp;
using System.Collections;

namespace RestSharpNetCoreTemplate.Tests.DDT

{
    [TestFixture]
    public class DataDrivenIssuesTests : TestBase
    {
        AddIssueRequest addIssueRequest = new AddIssueRequest();
        public static IEnumerable CadastrarBugsProvider()
        {
        return GeneralHelpers.ReturnCSVData(GeneralHelpers.ReturnProjectPath() + "Resources/TestData/CadastrarBugs.csv");
        }

        [Test, TestCaseSource("CadastrarBugsProvider")]
        [Obsolete]
        public void CadastrarBugsDDT(ArrayList testData)
        {
            string statusCodeEsperado = "OK";

            string categoria = testData[0].ToString();
            string resumo = testData[1].ToString();
            string descricao = testData[2].ToString();

            addIssueRequest.setJsonBody();

            IRestResponse<dynamic> response = addIssueRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}