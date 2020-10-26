using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class FindIssuesProjectRequest : RequestBase
    {
        public FindIssuesProjectRequest(string id)
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/issues?project_id=0";
            method = Method.GET;
            parameters.Add("0", id);
        }
    }
}