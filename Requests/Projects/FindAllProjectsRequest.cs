using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Projects
{
    public class FindAllProjectsRequest : RequestBase
    {
        public FindAllProjectsRequest(string projects)
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/projects/";
            method = Method.GET;
            parameters.Add("projects", projects);
        }
    }
}