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
    public class AddIssueErrorTagRequest : RequestBase
    {
        public AddIssueErrorTagRequest()
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/issues/0/notes";
            method = Method.POST;
        }

        public void setJsonBodyError()
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Issues/AddIssueErrorTagRequest.json", Encoding.UTF8);
        }
    }
}