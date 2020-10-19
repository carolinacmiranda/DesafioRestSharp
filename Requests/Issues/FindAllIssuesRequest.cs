using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class FindAllIssuesRequest : RequestBase
    {
        public FindAllIssuesRequest(string page_size, string page)
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/issues?page_size=1&page=8";
            method = Method.GET;
            parameters.Add("1", page_size);
            parameters.Add("8", page);
        }
    }
}