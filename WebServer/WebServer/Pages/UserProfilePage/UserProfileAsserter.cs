using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer.Pages.UserProfilePage
{
   public static class UserProfileAsserter
    {
        public static void AssertFileIsUpload(this UserProfilePage page, string text)
        {
            Assert.AreEqual(text, page.DragAndDropMessage.Text);
        }
        public static void AssertSearchFileExists(this UserProfilePage page, string text)
        {
            Assert.AreEqual(text, page.ExistingFile.Text);
        }
        public static void AssertOlderPasswordIsChangedWithNewPassword(this UserProfilePage page, string text)
        {
            Assert.AreEqual(text, page.SuccessMessage.Text);
        }
        public static void AssertLogoutUser(this UserProfilePage page, string text)
        {
            Assert.AreEqual(text, page.Message.Text);
        }
    }
}
