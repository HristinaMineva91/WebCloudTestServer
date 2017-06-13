using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer.Pages.RegistrationPage
{
  public static class RegistrationPageAsserter
    {
        public static void AssertRegistrationFormExsists(this RegistrationPage page, string text)
        {
            Assert.AreEqual(text, page.RegisterButton.Text);
        }
        public static void AssertRegisterNewUser(this RegistrationPage page, string text)
        {
            Assert.AreEqual(text, page.SuccessMessage.Text);
        }
    }
}
