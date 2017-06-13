using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer.Pages.ManagePasswordPage
{
   public static class ManagePasswordAsserter
    {
        public static void AssertEmailIsSend(this ManagePasswordPage page, string text)
        {
            Assert.AreEqual(text, page.ResetMessage.Text);
        }
    }
}
