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
    public class AddProjectRequest : RequestBase
    {
        public AddProjectRequest()
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/projects/";
            method = Method.POST;
        }

        public void setJsonBody()
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Projects/AddProjectRequest.json", Encoding.UTF8);
        }
    }
}