using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Filters
{
    public class FindAllFiltersRequest : RequestBase
    {
        public FindAllFiltersRequest(string filters)
        {
            url = "http://192.168.99.100:8989";
            requestService = "/api/rest/filters";
            method = Method.GET;
            parameters.Add("filters", filters);
        }
    }
}