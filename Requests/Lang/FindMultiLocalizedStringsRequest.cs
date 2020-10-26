using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Lang
{
    public class FindMultiLocalizedStringsRequest : RequestBase
    {
        public FindMultiLocalizedStringsRequest(string all_projects)
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/lang?string[]=all_projects&string[]=does_not_exist&string[]=status&string[]=move_bugs&string[]=status_enum_string";
            method = Method.GET;
            parameters.Add("all_projects", all_projects);
        }
    }
}