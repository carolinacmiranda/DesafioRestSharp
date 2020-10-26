using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Lang
{
    public class FindLocalizedStringRequest : RequestBase
    {
        public FindLocalizedStringRequest(string all_projects)
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/lang?string=all_projects";
            method = Method.GET;
            parameters.Add("all_projects", all_projects);
        }
    }
}