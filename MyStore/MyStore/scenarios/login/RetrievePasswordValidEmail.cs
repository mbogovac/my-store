using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.scenarios.login
{
    public class RetrievePasswordValidEmail
    {
        public RetrievePasswordValidEmail()
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
        public void RetrievePassValidEmail()
        {
            Actions.EmailForForgottenPass(Config.Credentials.Valid.Email);
            var successfullMessage = Driver.driver.FindElement(By.CssSelector(".alert.alert-success"));
            Assert.IsTrue(successfullMessage.Displayed);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
