using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests;
using WebServer.Models;
using WebServer.Pages.LoginPage;
using WebServer.Pages.ManagePasswordPage;
using WebServer.Pages.RegistrationPage;
using WebServer.Pages.UserProfilePage;

namespace WebServer
{
    [TestFixture]
    public class Tests
    {
        public IWebDriver driver;

        //Open Chrome Browser
        [SetUp]
        public void Init()
        {
            this.driver = new ChromeDriver();
            this.driver.Manage().Window.Maximize();
        }

        //Quit Chrome Browser
        [TearDown]
        public void CleanUp()
        {
            this.driver.Quit();
        }

        //Check the site is loaded
        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]
        public void CheckSiteIsLoaded()
        {
            var loginPage = new LoginPage(this.driver);
            loginPage.NavigateTo();

            loginPage.AssertSiteIsLoaded("http://lyubenov.com/up/");
        }

        //Check registration form is loaded
        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]
        public void CheckRegistrationFormExsists()
        {
            RegistrationPage registrationPage = new RegistrationPage(this.driver);
            registrationPage.NavigateTo();

            registrationPage.CreateButton.Click();

            registrationPage.AssertRegistrationFormExsists("Регистрирай се");
        }

        //Register new user
        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]
        public void CheckRegisterNewUser()
        {
            RegistrationPage registrationPage = new RegistrationPage(this.driver);

            registrationPage.NavigateTo();

            var username = "Sunny";
            var password = "123456789";
            var confirmPassword = "123456789";
            var email = username + DateTime.Now.Minute + "@mail.bg";

            var user = new RegisterUser(username, password, confirmPassword, email);
            registrationPage.RegistrationForm(user);

            registrationPage.AssertRegisterNewUser("Your account was created successfully.");
        }

        //Login created user
        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]
        public void CheckLoginUser()
        {
            LoginPage loginPage = new LoginPage(this.driver);
            loginPage.NavigateTo();

            var username = "Test";
            var password = "123456789";
            LoginUser user = new LoginUser(username, password);
            loginPage.LoginForm(user);

            loginPage.AssertUserIsLogged("You are logged successfully. Redirecting...");
        }
        
        //Send email with new password
        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]
        public void CheckPasswordIsChanged()
        {
            ManagePasswordPage managePasswordPage = new ManagePasswordPage(this.driver);
            managePasswordPage.NavigateTo();

            RegistrationPage registrationPage = new RegistrationPage(this.driver);

            var username = "test";
            var password = "123456789";
            var confirmPassword = "123456789";
            var email = username + "@mail.bg";
            var user = new RegisterUser(username, password, confirmPassword, email);
            registrationPage.RegistrationForm(user);

            LoginUser loginUser = new LoginUser(email);

            managePasswordPage.ChangePassword(loginUser);

            managePasswordPage.AssertEmailIsSend("Your new password was sent successfully.");
        }

        //Login in account and upload new file
        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]
        public void CheckFileIsUpload()
        {
            UserProfilePage userProfilePage = new UserProfilePage(this.driver);
            userProfilePage.NavigateTo();

            var username = "Test";
            var password = "123456789";
            LoginUser user = new LoginUser(username, password);

            userProfilePage.LoginFormAndUploadFile(user);

            userProfilePage.AssertFileIsUpload("Drag & Drop files or Click");
            userProfilePage.DragAndDrobOrClickButton.Click();
        }

        //Search for uploded file
        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]
        public void CheckSearchFileExists()
        {
            UserProfilePage userProfilePage = new UserProfilePage(this.driver);
            userProfilePage.NavigateTo();

            var username = "Test";
            var password = "123456789";
            LoginUser user = new LoginUser(username, password);

            userProfilePage.LoginFormAndUploadFile(user);

            userProfilePage.SearchUploadedFiles();

            userProfilePage.AssertSearchFileExists("1.png");
        }

        //Change current password with new password and save the changes
        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]
        public void CheckOlderPasswordIsChangedWithNewPassword()
        {
            UserProfilePage userProfilePage = new UserProfilePage(this.driver);
            userProfilePage.NavigateTo();

            var username = "Test";
            var password = "123456789";
            LoginUser user = new LoginUser(username, password);

            userProfilePage.LoginForm(user);

            userProfilePage.ChangeOlderPasswordWithNewPassword();

            userProfilePage.AssertOlderPasswordIsChangedWithNewPassword("OK: YOUR PASSWORD WAS CHANGED.");
        }

        //Logout the user
        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]
        public void CheckLogoutUser()
        {
            UserProfilePage userProfilePage = new UserProfilePage(this.driver);
            userProfilePage.NavigateTo();

            var username = "Test";
            var password = "123456789";
            LoginUser user = new LoginUser(username, password);

            userProfilePage.LoginForm(user);

            userProfilePage.Logout.Click();
            userProfilePage.AssertLogoutUser("Web Cloud Test Server");
        }
    }
}
