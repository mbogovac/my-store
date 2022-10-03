

using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;

namespace MyStore.scenarios.authentication
{
    public class AuthenticationEmptyEmail
    {
        public AuthenticationEmptyEmail()
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
        public void EmptyEmailField()
        {
            Actions.FillAuthenticationForm(Config.Credentials.Invalid.Empty);
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
