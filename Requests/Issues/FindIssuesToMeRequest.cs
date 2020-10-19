using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class FindIssuesToMeRequest : RequestBase
    {
        public FindIssuesToMeRequest(string toMe)
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/issues?filter_id=assigned";
            method = Method.GET;
            parameters.Add("assigned", toMe);
        }
    }
}