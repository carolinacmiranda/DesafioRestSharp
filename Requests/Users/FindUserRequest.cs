using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Users
{
    public class FindUserRequest : RequestBase
    {
        public FindUserRequest(string me)
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/users/me";
            method = Method.GET;
            parameters.Add("me", me);
        }
    }
}
