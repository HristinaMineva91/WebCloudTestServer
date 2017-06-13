using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer.Pages.RegistrationPage
{
   public partial class RegistrationPage : BasePage
    {
        public IWebElement CreateButton
        {
            get
            {
                var xpath = "//*[@id=\"login_form\"]/span/a[1]";
                this.Wait.Until(ExpectedConditions.ElementExists(OpenQA.Selenium.By.XPath(xpath)));
                return this.Driver.FindElement(OpenQA.Selenium.By.XPath(xpath));

            }
        }
        public IWebElement InstagramUsername
        {
            get
            {
                var xpath = "//*[@id=\"register_form\"]/div[1]/input";
                this.Wait.Until(ExpectedConditions.ElementExists(OpenQA.Selenium.By.XPath(xpath)));
                return this.Driver.FindElement(OpenQA.Selenium.By.XPath(xpath));
            }
        }
        public IWebElement Password
        {
            get
            {
                var xpath = "//*[@id=\"register_form\"]/div[2]/input";
                this.Wait.Until(ExpectedConditions.ElementExists(OpenQA.Selenium.By.XPath(xpath)));
                return this.Driver.FindElement(OpenQA.Selenium.By.XPath(xpath));
            }
        }
        public IWebElement ConfirmPassword
        {
            get
            {
                var xpath = "//*[@id=\"register_form\"]/div[3]/input";
                this.Wait.Until(ExpectedConditions.ElementExists(OpenQA.Selenium.By.XPath(xpath)));
                return this.Driver.FindElement(OpenQA.Selenium.By.XPath(xpath));
            }
        }
        public IWebElement Email
        {
            get
            {
                var xpath = "//*[@id=\"register_form\"]/div[4]/input";
                this.Wait.Until(ExpectedConditions.ElementExists(OpenQA.Selenium.By.XPath(xpath)));
                return this.Driver.FindElement(OpenQA.Selenium.By.XPath(xpath));
            }
        }
        public IWebElement RegisterButton
        {
            get
            {
                var xpath = "//*[@id=\"register_form\"]/button";
                this.Wait.Until(ExpectedConditions.ElementExists(OpenQA.Selenium.By.XPath(xpath)));
                return this.Driver.FindElement(OpenQA.Selenium.By.XPath(xpath));
            }
        }
        public IWebElement SuccessMessage
        {
            get
            {
                var xpath = "//*[@id=\"register_results\"]/div";
                this.Wait.Until(ExpectedConditions.ElementExists(OpenQA.Selenium.By.XPath(xpath)));
                return this.Driver.FindElement(OpenQA.Selenium.By.XPath(xpath));
            }
        }
    }
}
