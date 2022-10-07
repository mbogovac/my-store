
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace MyStore.scenarios.contactUs.loggedInUsers
{
    public class SendMessageWithoutEmail
    {
        public SendMessageWithoutEmail()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            NavigateTo.LoginFormThroughHomePage();
            Actions.FillLoginForm(Config.Credentials.Valid.Email, Config.Credentials.Valid.Password);

            NavigateTo.ConactUsFromBlackNavBar();
        }

        [Test]
        public void WithoutEmail()
        {
            Actions.FillContactFormDifferentEmail(Config.ContactUsData.Invalid.Empty,
                                                 Config.ContactUsData.Valid.Message);


            var error = Driver.driver.FindElement(By.CssSelector("#center_column > div > ol > li"));
            Assert.AreEqual(Config.ErrorMessages.InvalidEmail, error.Text);
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
