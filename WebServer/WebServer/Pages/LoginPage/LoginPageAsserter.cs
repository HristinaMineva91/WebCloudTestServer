using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer.Pages.LoginPage
{
  public static class LoginPageAsserter
    {
        public static void AssertSiteIsLoaded(this LoginPage page, string message)
        {
            Assert.AreEqual(message, page.URL);
        }
        public static void AssertUserIsLogged(this LoginPage page, string text)
        {
            Assert.AreEqual(text, page.MessageForLoginUser.Text);
        }
    }
}
