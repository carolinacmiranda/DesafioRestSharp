using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class FindIssueFileNotFoundRequest : RequestBase
    {
        public FindIssueFileNotFoundRequest(string issue_id, string file_id)
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/issues/1/files/22";
            method = Method.GET;
            parameters.Add("1", issue_id);
            parameters.Add("22", file_id);
        }
    }
}