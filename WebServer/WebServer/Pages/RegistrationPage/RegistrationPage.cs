using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServer.Models;

namespace WebServer.Pages.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver) : base(driver)
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
        public void RegistrationForm(RegisterUser user)
        {
            this.CreateButton.Click();
            Type(this.InstagramUsername, user.InstagramUsername);
            Type(this.Password, user.Password);
            Type(this.ConfirmPassword, user.ConfirmPassword);
            Type(this.Email, user.Email);
            this.RegisterButton.Click();
        }
        private void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }
}
