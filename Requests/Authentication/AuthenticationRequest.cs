using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpNetCoreTemplate.Requests.Authentication
{
    public class AuthenticationRequest : RequestBase
    {
        public AuthenticationRequest()
        {
            url = "https://dev-ud5p-o7y.auth0.com";
            requestService = "/oauth/token";
            method = Method.POST;
        }
        
        public void setJsonBody()
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Authentication/AuthenticationRequest.json", Encoding.UTF8);
        }
    }
}