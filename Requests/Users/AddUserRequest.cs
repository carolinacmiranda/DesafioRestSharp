using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpNetCoreTemplate.Requests.Users
{
    public class AddUserRequest : RequestBase
    {
        public AddUserRequest()
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/users/";
            method = Method.POST;
        }

        public void setJsonBody()
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Users/AddUserRequest.json", Encoding.UTF8);
        }

        public void setJsonBodyIncomplete()
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Users/AddUserIncompleteRequest.json", Encoding.UTF8);
        }

        public void setJsonBodyUserEmail()
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Users/AddUserEmailRequest.json", Encoding.UTF8);
        }
    }
}