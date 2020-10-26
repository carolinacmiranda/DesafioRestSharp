using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Projects
{
    public class FindProjectNotFoundRequest : RequestBase
    {
        public FindProjectNotFoundRequest(string id)
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/projects/100";
            method = Method.GET;
            parameters.Add("100", id);
        }
    }
}