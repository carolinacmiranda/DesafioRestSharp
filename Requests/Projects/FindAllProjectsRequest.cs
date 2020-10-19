using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Projects
{
    public class FindAllProjectsRequest : RequestBase
    {
        public FindAllProjectsRequest(string projects)
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/projects/";
            method = Method.GET;
            parameters.Add("projects", projects);
        }
    }
}