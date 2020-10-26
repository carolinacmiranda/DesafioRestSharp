using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Users
{
    public class DelUserRequest : RequestBase
    {
        public DelUserRequest(string id)
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/users/2";
            method = Method.DELETE;
            parameters.Add("2", id);
        }
    }
}