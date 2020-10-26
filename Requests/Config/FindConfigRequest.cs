using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Config
{
    public class FindConfigRequest : RequestBase
    {
        public FindConfigRequest(string csv)
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/config?option=csv_separator";
            method = Method.GET;
            parameters.Add("csv_separator", csv);
        }
    }
}