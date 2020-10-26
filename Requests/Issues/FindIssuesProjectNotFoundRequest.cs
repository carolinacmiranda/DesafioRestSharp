using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class FindIssuesProjectNotFoundRequest : RequestBase
    {
        public FindIssuesProjectNotFoundRequest(string id)
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/issues?project_id=100";
            method = Method.GET;
            parameters.Add("100", id);
        }
    }
}