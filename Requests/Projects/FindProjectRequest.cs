using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Projects
{
    public class FindProjectRequest : RequestBase
    {
        public FindProjectRequest(string id)
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/projects/10";
            method = Method.GET;
            parameters.Add("10", id);
        }
    }
}