using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer.Pages.UserProfilePage
{
  public partial class UserProfilePage : BasePage
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
        public IWebElement UploadFileButton
        {
            get
            {
                var xpath = "//*[@id=\"bs-example-navbar-collapse-1\"]/ul/li[1]/a";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement DragAndDrobOrClickButton
        {
            get
            {
                var className = "arfaly-showcase icon icon-cloud-storage";
                this.Wait.Until(ExpectedConditions.ElementExists(By.ClassName(className)));
                return this.Driver.FindElement(By.ClassName(className));
            }
        }
        public IWebElement DragAndDropMessage
        {
            get
            {
                var xpath = "//*[@id=\"arfaly-filedrag\"]/text()";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement SearchFilesMenu
        {
            get
            {
                var xpath = "//*[@id=\"bs-example-navbar-collapse-1\"]/form/div/input";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement FilenameBox
        {
            get
            {
                var xpath = "/html/body/div/div/div/div[2]/div/table";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement ExistingFile
        {
            get
            {
                var xpath = "/html/body/div/div/div/div[2]/div/table/tbody/tr[1]/td[1]/a";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement Settings
        {
            get
            {
                var xpath = "//*[@id=\"bs-example-navbar-collapse-1\"]/ul/li[2]/a";
                this.Wait.Until(ExpectedConditions.ElementExists(OpenQA.Selenium.By.XPath(xpath)));
                return this.Driver.FindElement(OpenQA.Selenium.By.XPath(xpath));
            }
        }
        public IWebElement CurrentPassword
        {
            get
            {
                var xpath = "/html/body/div/div/div/div[2]/div/div/div[2]/form/div[1]/input";
                this.Wait.Until(ExpectedConditions.ElementExists(OpenQA.Selenium.By.XPath(xpath)));
                return this.Driver.FindElement(OpenQA.Selenium.By.XPath(xpath));
            }
        }
        public IWebElement NewPassword
        {
            get
            {
                var xpath = "/html/body/div/div/div/div[2]/div/div/div[2]/form/div[2]/input";
                this.Wait.Until(ExpectedConditions.ElementExists(OpenQA.Selenium.By.XPath(xpath)));
                return this.Driver.FindElement(OpenQA.Selenium.By.XPath(xpath));
            }
        }
        public IWebElement ConfirmPassword
        {
            get
            {
                var xpath = "/html/body/div/div/div/div[2]/div/div/div[2]/form/div[3]/input";
                this.Wait.Until(ExpectedConditions.ElementExists(OpenQA.Selenium.By.XPath(xpath)));
                return this.Driver.FindElement(OpenQA.Selenium.By.XPath(xpath));
            }
        }
        public IWebElement SaveChangeButton
        {
            get
            {
                var xpath = "/html/body/div/div/div/div[2]/div/div/div[2]/form/button";
                this.Wait.Until(ExpectedConditions.ElementExists(OpenQA.Selenium.By.XPath(xpath)));
                return this.Driver.FindElement(OpenQA.Selenium.By.XPath(xpath));
            }
        }
        public IWebElement SuccessMessage
        {
            get
            {
                var xpath = "/html/body/div/div/div/div[2]/div/div[1]";
                this.Wait.Until(ExpectedConditions.ElementExists(OpenQA.Selenium.By.XPath(xpath)));
                return this.Driver.FindElement(OpenQA.Selenium.By.XPath(xpath));
            }
        }
        public IWebElement Logout
        {
            get
            {
                var xpath = "//*[@id=\"bs-example-navbar-collapse-1\"]/ul/li[3]/a";
                this.Wait.Until(ExpectedConditions.ElementExists(OpenQA.Selenium.By.XPath(xpath)));
                return this.Driver.FindElement(OpenQA.Selenium.By.XPath(xpath));
            }
        }
        public IWebElement Message
        {
            get
            {
                var xpath = "/html/body/div/div/div/div[1]";
                this.Wait.Until(ExpectedConditions.ElementExists(OpenQA.Selenium.By.XPath(xpath)));
                return this.Driver.FindElement(OpenQA.Selenium.By.XPath(xpath));
            }
        }
    }
}
