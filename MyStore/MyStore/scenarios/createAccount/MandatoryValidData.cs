
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;

namespace MyStore.scenarios.createAccount
{
    public class MandatoryValidData
    {
        public MandatoryValidData()
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
        public void MandatoryFieldsValid()
        {
            Actions.FillAuthenticationForm(Config.Credentials.Valid.UnregisteredEmail);
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(6));
            IWebElement registrationHeading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#account-creation_form > div:nth-child(1) > h3")));
            Assert.IsTrue(registrationHeading.Displayed);

            Actions.FillCreateAccountForm(Config.CreateAccountData.Valid.FirstName,
                                          Config.CreateAccountData.Valid.LastName,
                                          Config.CreateAccountData.Valid.Password,
                                          Config.CreateAccountData.Valid.Address,
                                          Config.CreateAccountData.Valid.City,
                                          Config.CreateAccountData.Valid.PostalCode,
                                          Config.CreateAccountData.Valid.MobilePhone);

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
