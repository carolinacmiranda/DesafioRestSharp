using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Users
{
    public class FindUserRequest : RequestBase
    {
        public FindUserRequest(string me)
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/users/me";
            method = Method.GET;
            parameters.Add("me", me);
        }
    }
}
