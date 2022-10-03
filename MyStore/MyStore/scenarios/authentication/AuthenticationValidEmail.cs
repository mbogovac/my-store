
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace MyStore.scenarios.authentication
{
    public class AuthenticationValidEmail
    {
        public AuthenticationValidEmail()
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
        public void AuthWithValidEmail()
        {
            Actions.FillAuthenticationForm(Config.Credentials.Valid.UnregisteredEmail);
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(6));
            IWebElement registrationHeading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#account-creation_form > div:nth-child(1) > h3")));
            Assert.IsTrue(registrationHeading.Displayed);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
