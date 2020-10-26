using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Filters
{
    public class FindFilterRequest : RequestBase
    {
        public FindFilterRequest(string id)
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/filters?filter_id=3";
            method = Method.GET;
            parameters.Add("3", id);
        }
    }
}