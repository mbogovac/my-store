
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;

namespace MyStore.scenarios.createAccount
{
    public class EmptyMandatoryFields
    {
        public EmptyMandatoryFields()
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
        public void EmptyMandatoryData()
        {
            Actions.FillAuthenticationForm(Config.Credentials.Valid.UnregisteredEmail);
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(6));
            IWebElement registrationHeading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#account-creation_form > div:nth-child(1) > h3")));
            Assert.IsTrue(registrationHeading.Displayed);

            Actions.FillCreateAccountForm(Config.CreateAccountData.Invalid.Empty,
                                          Config.CreateAccountData.Invalid.Empty,
                                          Config.CreateAccountData.Invalid.Empty,
                                          Config.CreateAccountData.Invalid.Empty,
                                          Config.CreateAccountData.Invalid.Empty,
                                          Config.CreateAccountData.Invalid.Empty,
                                          Config.CreateAccountData.Invalid.Empty);

            var error = Driver.driver.FindElement(By.CssSelector("#center_column > div > p"));
            Assert.IsTrue(error.Displayed);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
