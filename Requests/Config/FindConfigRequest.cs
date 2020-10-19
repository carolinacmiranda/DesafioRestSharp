using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Config
{
    public class FindConfigRequest : RequestBase
    {
        public FindConfigRequest(string csv)
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/config?option=csv_separator";
            method = Method.GET;
            parameters.Add("csv_separator", csv);
        }
    }
}