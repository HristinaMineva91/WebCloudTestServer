using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer.Pages.ManagePasswordPage
{
   public partial class ManagePasswordPage : BasePage
    {
        public IWebElement ResetButton
        {
            get
            {
                var xpath = "//*[@id=\"login_form\"]/span/a[2]";
                this.Wait.Until(ExpectedConditions.ElementExists(OpenQA.Selenium.By.XPath(xpath)));
                return this.Driver.FindElement(OpenQA.Selenium.By.XPath(xpath));
            }
        }
        public IWebElement Email
        {
            get
            {
                var xpath = "//*[@id=\"reset_form\"]/div/input";
                this.Wait.Until(ExpectedConditions.ElementExists(OpenQA.Selenium.By.XPath(xpath)));
                return this.Driver.FindElement(OpenQA.Selenium.By.XPath(xpath));
            }
        }
        public IWebElement ResetPasswordButton
        {
            get
            {
                var xpath = "//*[@id=\"reset_form\"]/button";
                this.Wait.Until(ExpectedConditions.ElementExists(OpenQA.Selenium.By.XPath(xpath)));
                return this.Driver.FindElement(OpenQA.Selenium.By.XPath(xpath));
            }
        }
        public IWebElement ResetMessage
        {
            get
            {
                var xpath = "//*[@id=\"reset_results\"]/div";
                this.Wait.Until(ExpectedConditions.ElementExists(OpenQA.Selenium.By.XPath(xpath)));
                return this.Driver.FindElement(OpenQA.Selenium.By.XPath(xpath));
            }
        }
    }
}
