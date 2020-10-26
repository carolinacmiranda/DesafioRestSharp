using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Config
{
    public class FindMultiConfigRequest : RequestBase
    {
        public FindMultiConfigRequest(string csv)
        {
            url = JsonBuilder.ReturnParameterAppSettings("URL");
            requestService = "/api/rest/config?option[]=crypto_master_salt&option[]=csv_separator&option[]=status_colors&option[]=does_not_exist&option[]=status_enum_string";
            method = Method.GET;
            parameters.Add("csv_separator", csv);
        }
    }
}