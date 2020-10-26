using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class FindAllIssuesRequest : RequestBase
    {
        public FindAllIssuesRequest(string page_size, string page)
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/issues?page_size=1&page=8";
            method = Method.GET;
            parameters.Add("1", page_size);
            parameters.Add("8", page);
        }
    }
}