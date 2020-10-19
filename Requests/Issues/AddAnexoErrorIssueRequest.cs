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
    public class AddAnexoErrorIssueRequest : RequestBase
    {
        public AddAnexoErrorIssueRequest()
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/issues/0/files";
            method = Method.POST;
        }

        public void setJsonBodyError()
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Issues/AddAnexoErrorIssueRequest.json", Encoding.UTF8);
        }
    }
}