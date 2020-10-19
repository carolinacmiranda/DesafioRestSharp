using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class AddIssueRequest : RequestBase
    {
        public AddIssueRequest()
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/issues";
            method = Method.POST;
        }

        public void setJsonBody()
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Issues/AddIssueRequest.json", Encoding.UTF8);
        }

        public void setJsonBodyIncompleteSummary()
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Issues/AddIssueIncompleteSummaryRequest.json", Encoding.UTF8);
        }

        public void setJsonBodyIncompleteDescription()
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Issues/AddIssueIncompleteDescriptionRequest.json", Encoding.UTF8);
        }
    }
}