using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class FindIssuesMonitoredByMeRequest : RequestBase
    {
        public FindIssuesMonitoredByMeRequest(string byMe)
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/issues?filter_id=monitored";
            method = Method.GET;
            parameters.Add("monitored", byMe);
        }
    }
}