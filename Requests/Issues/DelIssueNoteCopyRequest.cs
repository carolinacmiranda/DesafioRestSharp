using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class DelIssueNoteCopyRequest : RequestBase
    {
        public DelIssueNoteCopyRequest(string issue_id, string relationship_id)
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/issues/20/relationships/1";
            method = Method.DELETE;
            parameters.Add("20", issue_id);
            parameters.Add("1", relationship_id);
        }
    }
}