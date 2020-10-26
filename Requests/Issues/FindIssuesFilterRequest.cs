using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class FindIssuesFilterRequest : RequestBase
    {
        public FindIssuesFilterRequest(string id)
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/issues?filter_id=1";
            method = Method.GET;
            parameters.Add("1", id);
        }
    }
}