using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Projects
{
    public class FindProjectNotFoundRequest : RequestBase
    {
        public FindProjectNotFoundRequest(string id)
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/projects/100";
            method = Method.GET;
            parameters.Add("100", id);
        }
    }
}