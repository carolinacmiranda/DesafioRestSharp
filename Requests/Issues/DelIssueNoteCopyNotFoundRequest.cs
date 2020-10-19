using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class DelIssueNoteCopyNotFoundRequest : RequestBase
    {
        public DelIssueNoteCopyNotFoundRequest(string issue_id, string relationship_id)
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/issues/22/relationships/0";
            method = Method.DELETE;
            parameters.Add("22", issue_id);
            parameters.Add("0", relationship_id);
        }
    }
}