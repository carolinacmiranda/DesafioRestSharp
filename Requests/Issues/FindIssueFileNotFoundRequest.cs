using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class FindIssueFileNotFoundRequest : RequestBase
    {
        public FindIssueFileNotFoundRequest(string issue_id, string file_id)
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/issues/1/files/100";
            method = Method.GET;
            parameters.Add("1", issue_id);
            parameters.Add("100", file_id);
        }
    }
}