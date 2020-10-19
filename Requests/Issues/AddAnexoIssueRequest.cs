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
    public class AddAnexoIssueRequest : RequestBase
    {
        public AddAnexoIssueRequest()
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/issues/12/files";
            method = Method.POST;
        }

        public void setJsonBody()
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Issues/AddAnexoIssueRequest.json", Encoding.UTF8);
        }
    }
}