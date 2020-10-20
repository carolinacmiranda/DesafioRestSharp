using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpNetCoreTemplate.Helpers
{
    public class GeneralHelpers
    {       
        public static string FormatJson(string str)
        {
            string INDENT_STRING = "    ";
            var indent = 0;
            var quoted = false;
            var sb = new StringBuilder();
            for (var i = 0; i < str.Length; i++)
            {
                var ch = str[i];
                switch (ch)
                {
                    case '{':
                    case '[':
                        sb.Append(ch);
                        if (!quoted)
                        {
                            sb.AppendLine();
                            Enumerable.Range(0, ++indent).ForEach(item => sb.Append(INDENT_STRING));
                        }
                        break;
                    case '}':
                    case ']':
                        if (!quoted)
                        {
                            sb.AppendLine();
                            Enumerable.Range(0, --indent).ForEach(item => sb.Append(INDENT_STRING));
                        }
                        sb.Append(ch);
                        break;
                    case '"':
                        sb.Append(ch);
                        bool escaped = false;
                        var index = i;
                        while (index > 0 && str[--index] == '\\')
                            escaped = !escaped;
                        if (!escaped)
                            quoted = !quoted;
                        break;
                    case ',':
                        sb.Append(ch);
                        if (!quoted)
                        {
                            sb.AppendLine();
                            Enumerable.Range(0, indent).ForEach(item => sb.Append(INDENT_STRING));
                        }
                        break;
                    case ':':
                        sb.Append(ch);
                        if (!quoted)
                            sb.Append(" ");
                        break;
                    default:
                        sb.Append(ch);
                        break;
                }
            }
            return sb.ToString();
        }

        public static void EnsureDirectoryExists(string fullReportFilePath)
        {
            var directory = Path.GetDirectoryName(fullReportFilePath);
            if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
        }

        public static string ReturnProjectPath()
        {
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;

            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));

            return new Uri(actualPath).LocalPath;
        }

        public static bool VerificaSeStringEstaContidaNaLista(List<string> lista, string p_string)
        {
            foreach (string item in lista)
            {
                if (item.Equals(p_string))
                {
                    return true;
                }
            }
            return false;
        }

        public static int RetornaNumeroDeObjetosDoJson(JArray json)
        {
            return json.Count;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string GetMethodNameByLevel(int level)
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(level);
            return sf.GetMethod().Name;
        }

        public static bool IsAJsonArray(string json)
        {
            if (json.StartsWith("["))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static IEnumerable ReturnCSVData(string csvPath)
        {
            using (StreamReader sr = new StreamReader(csvPath, System.Text.Encoding.GetEncoding(65001)))
            {
                string headerLine = sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    ArrayList result = new ArrayList();
                    result.AddRange(line.Split(';'));
                    yield return result;
                }
            }
        }

        public static string ExecutarScriptNodeJS()
        {
            string resultado;
            string argument = @"C:\Users\Carol\source\repos\Desafio_API_Base2\Resources\ScriptNode.js";
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Program Files\nodejs\node.exe";
            start.Arguments = argument;
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    resultado = result.Remove(14);
                    Console.Write(result);
                }
            }

            return resultado;
        }

        /*public static string[] TesteCSV() 
        {
            Console.WriteLine("test");
            StreamReader sr = new StreamReader(@"C:\Users\Carol\source\repos\Desafio_RestSharp_Base2\Resources\TestData\CadastrarUsuarios.csv"); 
            Console.WriteLine("test2");

            string linha = null;
            string[] result = null;

            while ((linha = sr.ReadLine()) != null)
                {
                    Console.WriteLine(result);
                    result = linha.Split(';');
                    Console.WriteLine(result);
                }
                
            return result;
        }*/

        /*public static string[] OutroTesteCSV()
        {
            StreamReader rd = new StreamReader(@"C:\Users\User\Documents\file.csv, Encoding.Default, true);

                string linha = null;
                string[] linhaseparada = null;
                List<Object> linhas = new List<Object>();

                // ler o conteudo da linha e add na list 
                while ((linha = rd.ReadLine()) != null)
                { 
                    linhaseparada = linha.Split(',');                
                    foreach(var item in linhaseparada)
                }*/
        }

    static class Extensions
    {
        public static void ForEach<T>(this IEnumerable<T> ie, Action<T> action)
        {
            foreach (var i in ie)
            {
                action(i);
            }
        }
    }

    /*public static List<TestCaseData> AddUserDataDriven()
            {
                var testCases = new List<TestCaseData>();
                string[] split = { "" };
                using (var fs = File.OpenRead(@"C:\Users\Carol\source\repos\Desafio.restsharpnetcoretemplate-master\RestSharpNetCoreTemplate\Resources\TestData\CadastrarUsuarios.csv"))
                //using (var fs = File.OpenRead(SeleniumComum.SeleniumUteis.getPathDataDrivenFiles()))
                using (var sr = new StreamReader(fs))
                {
                    string line = string.Empty;

                    while (line != null)
                    {
                        line = sr.ReadLine();
                        if (line != null)
                        {
                            split = line.Split(new char[] { ',' }, StringSplitOptions.None);
                            string id = split[0].Trim();
                            string username = split[1].Trim();
                            string password = split[2].Trim();
                            string real_name = split[3].Trim();
                            string email = split[4].Trim();

                            {
                                var testCase = new TestCaseData(id, username,
                                password, real_name, email);
                                testCases.Add(testCase);
                            }
                        }
                    }
                }
                return testCases;
            }*/
    }
