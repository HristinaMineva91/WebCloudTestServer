using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServer.Models;

namespace WebServer.Pages.ManagePasswordPage
{
    public partial class ManagePasswordPage : BasePage
    {
        public ManagePasswordPage(IWebDriver driver) : base(driver)
        {
        }
        public string URL
        {
            get
            {
                //return "http://revistabrazil.com";
                return @"http://lyubenov.com/up/";
            }
        }
        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.URL);
        }
        public void ChangePassword(LoginUser user)
        {
            this.ResetButton.Click();
            Type(this.Email, user.Email);
            this.ResetPasswordButton.Click();
        }
        private void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }
}
