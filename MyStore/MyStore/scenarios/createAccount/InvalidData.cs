﻿
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;

namespace MyStore.scenarios.createAccount
{
    public class InvalidData
    {
        public InvalidData()
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
        public void PasswordLessThan5()
        {
            Actions.FillAuthenticationForm(Config.Credentials.Valid.UnregisteredEmail);
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(6));
            IWebElement registrationHeading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#account-creation_form > div:nth-child(1) > h3")));
            Assert.IsTrue(registrationHeading.Displayed);

            Actions.FillCreateAccountForm(Config.CreateAccountData.Valid.FirstName,
                                          Config.CreateAccountData.Valid.LastName,
                                          Config.CreateAccountData.Invalid.PassLessThan5,
                                          Config.CreateAccountData.Valid.Address,
                                          Config.CreateAccountData.Valid.City,
                                          Config.CreateAccountData.Valid.PostalCode,
                                          Config.CreateAccountData.Valid.MobilePhone);

            var error = Driver.driver.FindElement(By.CssSelector("#center_column > div > ol > li"));
            Assert.AreEqual(Config.ErrorMessages.InvalidPass, error.Text);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}