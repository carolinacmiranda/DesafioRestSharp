using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpNetCoreTemplate.DBSteps
{
    class ProjectsDBSteps
    {
        public static void AddNewProject(string idProjeto)
        {
            string idProjetoString = idProjeto.ToString();
            string query = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Queries/AddNewProject.sql", Encoding.UTF8);
            query = query.Replace("$idProjeto", idProjetoString);
            query = query.Replace("$projectDescription", " description");
            DBHelpers.ExecuteQuery(query);

            ExtentReportHelpers.AddTestInfo(2, "PARAMETERS: Executa query - " + query);
        }

        public static void DeleteAllProjects()
        {
            string query = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Queries/DeleteAllProjects.sql", Encoding.UTF8);
            DBHelpers.ExecuteQuery(query);
            ExtentReportHelpers.AddTestInfo(2, "PARAMETERS: Executa query - " + query);
        }
    }
}
