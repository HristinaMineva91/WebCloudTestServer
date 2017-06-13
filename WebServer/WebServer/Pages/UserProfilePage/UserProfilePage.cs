using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServer.Models;

namespace WebServer.Pages.UserProfilePage
{
   public partial class UserProfilePage : BasePage
    {
        public UserProfilePage(IWebDriver driver) : base(driver)
        {
        }
        public string URL
        {
            get
            {
                return @"http://lyubenov.com/up/";
            }
        }
        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.URL);
        }
        public void LoginForm(LoginUser user)
        {
            Type(this.Username, user.Username);
            Type(this.Password, user.Password);
            this.LoginButton.Click();
        }
        public void LoginFormAndUploadFile(LoginUser user)
        {
            Type(this.Username, user.Username);
            Type(this.Password, user.Password);
            this.LoginButton.Click();
            this.UploadFileButton.Click();
        }
        public void SearchUploadedFiles()
        {
            if (!this.FilenameBox.Equals(null))
            {
                this.SearchFilesMenu.SendKeys("1.png");
                this.SearchFilesMenu.SendKeys(Keys.Enter);
            }
        }
        public void ChangeOlderPasswordWithNewPassword()
        {
            this.Settings.Click();
            this.CurrentPassword.SendKeys("123456789");
            this.NewPassword.SendKeys("987654321");
            this.ConfirmPassword.SendKeys("987654321");
            this.SaveChangeButton.Click();
        }
        private void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }
}
