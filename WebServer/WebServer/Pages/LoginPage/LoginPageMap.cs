using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer.Pages.LoginPage
{
   public partial class LoginPage : BasePage
    {
        public IWebElement Username
        {
            get
            {
                var xpath = "//*[@id=\"login_form\"]/div[1]/input";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement Password
        {
            get
            {
                var xpath = "//*[@id=\"login_form\"]/div[2]/input";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement LoginButton
        {
            get
            {
                var xpath = "//*[@id=\"login_form\"]/button";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement MessageForLoginUser
        {
            get
            {
                var xpath = "//*[@id=\"login_results\"]/div";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
    }
}
