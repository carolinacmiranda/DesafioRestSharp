using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class FindIssuesNotToMeRequest : RequestBase
    {
        public FindIssuesNotToMeRequest(string notToMe)
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/issues?filter_id=unassigned";
            method = Method.GET;
            parameters.Add("unassigned", notToMe);
        }
    }
}