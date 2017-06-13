using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServer.Models;

namespace WebServer.Pages.LoginPage
{
   public partial class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        public string URL
        {
            get
            {
                // return "http://revistabrazil.com";
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
        private void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }
}
