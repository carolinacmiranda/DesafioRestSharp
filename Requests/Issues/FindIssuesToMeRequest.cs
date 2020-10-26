using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class FindIssuesToMeRequest : RequestBase
    {
        public FindIssuesToMeRequest(string toMe)
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/issues?filter_id=assigned";
            method = Method.GET;
            parameters.Add("assigned", toMe);
        }
    }
}