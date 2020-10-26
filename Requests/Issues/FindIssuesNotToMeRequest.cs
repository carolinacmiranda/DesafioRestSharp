using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class FindIssuesNotToMeRequest : RequestBase
    {
        public FindIssuesNotToMeRequest(string notToMe)
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/issues?filter_id=unassigned";
            method = Method.GET;
            parameters.Add("unassigned", notToMe);
        }
    }
}