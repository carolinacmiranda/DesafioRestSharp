using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Filters
{
    public class FindAllFiltersRequest : RequestBase
    {
        public FindAllFiltersRequest(string filters)
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/filters";
            method = Method.GET;
            parameters.Add("filters", filters);
        }
    }
}