using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Pages
{
    public class FindIssuePageRequest : RequestBase
    {
        public FindIssuePageRequest(string id)
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/issues/25";
            method = Method.GET;
            parameters.Add("25", id);
        }
    }
}