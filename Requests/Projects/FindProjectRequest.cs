using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Projects
{
    public class FindProjectRequest : RequestBase
    {
        public FindProjectRequest(string id)
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/projects/0";
            method = Method.GET;
            parameters.Add("0", id);
        }
    }
}