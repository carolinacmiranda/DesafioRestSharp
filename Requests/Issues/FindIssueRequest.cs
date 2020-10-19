using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class FindIssueRequest : RequestBase
    {
        public FindIssueRequest(string id)
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/issues/12";
            method = Method.GET;
            parameters.Add("12", id);
        }
    }
}
