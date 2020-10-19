using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class FindIssueNotFoundRequest : RequestBase
    {
        public FindIssueNotFoundRequest(string id)
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/issues/1000";
            method = Method.GET;
            parameters.Add("1000", id);
        }
    }
}