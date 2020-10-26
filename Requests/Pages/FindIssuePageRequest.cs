using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Pages
{
    public class FindIssuePageRequest : RequestBase
    {
        public FindIssuePageRequest(string id)
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/issues/25";
            method = Method.GET;
            parameters.Add("25", id);
        }
    }
}