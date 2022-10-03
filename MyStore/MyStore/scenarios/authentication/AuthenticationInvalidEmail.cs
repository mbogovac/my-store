
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace MyStore.scenarios.authentication
{
    public class AuthenticationInvalidEmail
    {
        public AuthenticationInvalidEmail()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.LoginFormThroughHomePage();

            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void ExistingEmail()
        {
            Actions.FillAuthenticationForm(Config.Credentials.Valid.Email);
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(6));
            IWebElement error = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#create_account_error > ol > li")));
            Assert.AreEqual(Config.ErrorMessages.ExistingEmail, error.Text);
        }

        [Test]
        public void InvalidEmailFormat()
        {
            Actions.FillAuthenticationForm(Config.Credentials.Invalid.Email);
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(6));
            IWebElement error = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#create_account_error > ol > li")));
            Assert.AreEqual(Config.ErrorMessages.InvalidEmail, error.Text);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
