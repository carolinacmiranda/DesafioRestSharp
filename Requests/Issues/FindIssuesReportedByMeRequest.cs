using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class FindIssuesReportedByMeRequest : RequestBase
    {
        public FindIssuesReportedByMeRequest(string byMe)
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/issues?filter_id=reported";
            method = Method.GET;
            parameters.Add("reported", byMe);
        }
    }
}