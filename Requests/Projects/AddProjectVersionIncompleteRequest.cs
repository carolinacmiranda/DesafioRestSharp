using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpNetCoreTemplate.Requests.Projects
{
    public class AddProjectVersionIncompleteRequest : RequestBase
    {
        public AddProjectVersionIncompleteRequest()
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/projects/10/versions/";
            method = Method.POST;
        }

        public void setJsonBodyIncomplete()
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Projects/AddProjectVersionIncompleteRequest.json", Encoding.UTF8);
        }
    }
}