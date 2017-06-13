using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnitTests;
using WebServer.Models;
using WebServer.Pages.LoginPage;
using WebServer.Pages.ManagePasswordPage;
using WebServer.Pages.RegistrationPage;
using WebServer.Pages.UserProfilePage;

namespace WebCloudTestServer
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            ChromeDriver driver = new ChromeDriver(options);

            driver.Manage().Window.Maximize();
            driver.Url = @"http://lyubenov.com/up/";

            var create = driver.ExecuteScript("show_register_form();");

            RegistrationPage registrationPage = new RegistrationPage(driver);
            RegisterUser user = new RegisterUser("Test", "123456789", "123456789", "Test@mail.bg");

            registrationPage.RegistrationForm(user);

            registrationPage.AssertRegistrationFormExsists("Регистрирай се");
            registrationPage.AssertRegisterNewUser("Your account was created successfully.");

            LoginPage loginPage = new LoginPage(driver);
            LoginUser loginUser = new LoginUser("Test", "123456789");

            loginPage.LoginForm(loginUser);

            loginPage.AssertSiteIsLoaded("http://lyubenov.com/up/");
            loginPage.AssertUserIsLogged("You are logged successfully. Redirecting...");

            ManagePasswordPage page = new ManagePasswordPage(driver);
            LoginUser loggedUser = new LoginUser("Test@mail.bg");

            page.ChangePassword(loggedUser);

            page.AssertEmailIsSend("Your new password was sent successfully.");

            UserProfilePage userProfilePage = new UserProfilePage(driver);
            userProfilePage.LoginFormAndUploadFile(loginUser);

            userProfilePage.AssertFileIsUpload("Drag & Drop files or Click");

            userProfilePage.SearchUploadedFiles();

            userProfilePage.AssertSearchFileExists("1.png");

            userProfilePage.ChangeOlderPasswordWithNewPassword();

            userProfilePage.AssertOlderPasswordIsChangedWithNewPassword("OK: YOUR PASSWORD WAS CHANGED.");

            userProfilePage.Logout.Click();

            userProfilePage.AssertLogoutUser("Web Cloud Test Server");
        }
    }
}

