using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class FindIssueFileRequest : RequestBase
    {
        public FindIssueFileRequest(string issue_id, string file_id)
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/issues/12/files/5";
            method = Method.GET;
            parameters.Add("12", issue_id);
            parameters.Add("5", file_id);
        }
    }
}