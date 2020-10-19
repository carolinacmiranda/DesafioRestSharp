using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using RestSharpNetCoreTemplate.Requests.Users;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RestSharpNetCoreTemplate.Tests.Regex
{
    [TestFixture]
    public class RegexTests : TestBase
    {
        [Test]
        [Obsolete]
        public void ValidarEmailValidoComRegex()
        {

            string email = "teste@emailvalido.com";

            bool isValidEmail = RegexHelpers.IsValidEmail(email);

            Assert.IsTrue(isValidEmail);
        }

        [Test]
        public void ValidarEmailInvalidoComRegex()
        {

            string email = "teste@emailinvalido";

            bool isValidEmail = RegexHelpers.IsValidEmail(email);

            Assert.IsFalse(isValidEmail);

        }
    }
}