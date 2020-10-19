using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class FindIssuesMonitoredByMeRequest : RequestBase
    {
        public FindIssuesMonitoredByMeRequest(string byMe)
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/issues?filter_id=monitored";
            method = Method.GET;
            parameters.Add("monitored", byMe);
        }
    }
}