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
    public class AddIssueTagRequest : RequestBase
    {
        public AddIssueTagRequest()
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/issues/12/notes";
            method = Method.POST;
        }

        public void setJsonBody()
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Issues/AddIssueTagRequest.json", Encoding.UTF8);
        }
    }
}