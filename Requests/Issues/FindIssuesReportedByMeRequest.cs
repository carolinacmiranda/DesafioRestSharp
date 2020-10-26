using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class FindIssuesReportedByMeRequest : RequestBase
    {
        public FindIssuesReportedByMeRequest(string byMe)
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/issues?filter_id=reported";
            method = Method.GET;
            parameters.Add("reported", byMe);
        }
    }
}