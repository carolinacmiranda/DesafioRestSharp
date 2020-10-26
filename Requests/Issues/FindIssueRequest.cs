using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class FindIssueRequest : RequestBase
    {
        public FindIssueRequest(string id)
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/issues/12";
            method = Method.GET;
            parameters.Add("12", id);
        }
    }
}
