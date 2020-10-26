using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpNetCoreTemplate.DBSteps
{
    class IssuesDBSteps
    {
        public static void AddNewProject(string nomeProjeto)
        {
            string query = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Queries/AddNewProject.sql", Encoding.UTF8);
            query = query.Replace("$projectName", nomeProjeto);
            DBHelpers.ExecuteQuery(query);

            ExtentReportHelpers.AddTestInfo(2, "PARAMETERS: Executa query - " + query);
        }
    }
}
