using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using TestApp.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using TechTalk.SpecFlow;

namespace TestApp.Tests
{
    public class LoginTest : DriverHelper
    {
        [SetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
        }
        [TearDown]
        protected void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void loginTest()
        {
            config configurations = new config();
            Login login = new Login();
            Homepage hp = new Homepage();
            RegistrationPage regPage = new RegistrationPage();
            urlManager UrlManager = new urlManager();

            //Driver.Navigate().GoToUrl("https://demo.nopcommerce.com/");
            UrlManager.openUrl(Driver, UrlManager.baseUrl);

            Driver.Manage().Window.Maximize();
            hp.clickLoginBtn();
            login.EnterEmail("stacey@test.com");
            login.EnterPsw("Testing123");
            login.submitLogin();

            //Thread.Sleep(7000);
            hp.isLogOffExist();

            Thread.Sleep(7000);

        }
        }
}
