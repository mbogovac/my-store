
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace MyStore.scenarios.login
{
    public class RetrievePassInvalidEmail
    {
        public RetrievePassInvalidEmail()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.ForgotYourPasswordPage();

            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.driver.Manage().Window.Maximize();
        }

        [Test]
        public void RetrieveWithInvalidEmail()
        {
            Actions.EmailForForgottenPass(Config.Credentials.Invalid.Email);
            var errorMessage = Driver.driver.FindElement(By.CssSelector("#center_column > div > div > ol > li"));
            Assert.AreEqual(Config.ErrorMessages.InvalidEmail, errorMessage.Text);
        }

        [Test]
        public void RetrieveWithoutEmail()
        {
            Actions.EmailForForgottenPass(Config.Credentials.Invalid.Empty);
            var errorMessage = Driver.driver.FindElement(By.CssSelector("#center_column > div > div > ol > li"));
            Assert.AreEqual(Config.ErrorMessages.InvalidEmail, errorMessage.Text);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
