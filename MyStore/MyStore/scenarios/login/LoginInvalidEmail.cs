
using MyStore.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace MyStore.scenarios.login
{
    public class LoginInvalidEmail
    {
        public LoginInvalidEmail()
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
        public void InvalidEmail()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.Email, Config.Credentials.Valid.Password);

            var errorMessage = Driver.driver.FindElement(By.CssSelector("#center_column > div.alert.alert-danger > ol > li"));
            Assert.AreEqual(Config.ErrorMessages.InvalidEmail, errorMessage.Text);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
