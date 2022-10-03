
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MyStore.scenarios.login
{
    public class LoginEmptyFields
    {
        public LoginEmptyFields()
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
        public void EmptyEmailAndPassword()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.Empty, Config.Credentials.Invalid.Empty);
            var errorMessage = Driver.driver.FindElement(By.CssSelector("#center_column > div.alert.alert-danger > ol > li"));
            Assert.AreEqual(Config.ErrorMessages.EmptyEmailField, errorMessage.Text);
        }

        [Test]
        public void EmptyEmailField()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.Empty, Config.Credentials.Valid.Password);
            var errorMessage = Driver.driver.FindElement(By.CssSelector("#center_column > div.alert.alert-danger > ol > li"));
            Assert.AreEqual(Config.ErrorMessages.EmptyEmailField, errorMessage.Text);
        }

        [Test]
        public void EmptyPasswordField()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Email, Config.Credentials.Invalid.Empty);
            var errorMessage = Driver.driver.FindElement(By.CssSelector("#center_column > div.alert.alert-danger > ol > li"));
            Assert.AreEqual(Config.ErrorMessages.EmptyPasswordField, errorMessage.Text);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
