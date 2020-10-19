using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Users
{
    public class DelUserRequest : RequestBase
    {
        public DelUserRequest(string id)
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/users/2";
            method = Method.DELETE;
            parameters.Add("2", id);
        }
    }
}