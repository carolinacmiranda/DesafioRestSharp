using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class FindIssuesProjectNotFoundRequest : RequestBase
    {
        public FindIssuesProjectNotFoundRequest(string id)
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/issues?project_id=1";
            method = Method.GET;
            parameters.Add("1", id);
        }
    }
}