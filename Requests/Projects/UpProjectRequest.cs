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
    public class UpProjectRequest : RequestBase
    {
        public UpProjectRequest()
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/projects/33";
            method = Method.PATCH;
        }

        public void setJsonBody()
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Projects/UpProjectRequest.json", Encoding.UTF8);
        }
    }
}