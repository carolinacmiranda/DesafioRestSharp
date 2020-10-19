using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class MonitorIssueRequest : RequestBase
    {
        public MonitorIssueRequest(string id)
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/issues/12/monitors";
            method = Method.POST;
            parameters.Add("12", id);
        }
    }
}