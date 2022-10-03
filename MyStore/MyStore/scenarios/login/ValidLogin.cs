
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace MyStore.scenarios.login
{
    public class ValidLogin
    {
        public ValidLogin()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.LoginFormThroughHomePage();

            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.driver.Manage().Window.Maximize();
        }

        [Test]
        public void ValidCredetials()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Email, Config.Credentials.Valid.Password);
            var signOut = Driver.driver.FindElement(By.ClassName("logout"));
            Assert.IsTrue(signOut.Displayed);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
