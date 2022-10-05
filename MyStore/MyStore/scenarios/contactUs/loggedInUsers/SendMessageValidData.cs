
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace MyStore.scenarios.contactUs.loggedInUsers
{
    public class SendMessageValidData
    {
        public SendMessageValidData()
        {
        }

        [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            NavigateTo.LoginFormThroughHomePage();
            Actions.FillLoginForm(Config.Credentials.Valid.Email, Config.Credentials.Valid.Password);

            NavigateTo.FromMyAccountToContactPage();

        }

        [Test]
        public void AllValidData()
        {

            Actions.FillContactFormLoggedIn(Config.ContactUsData.Valid.Message);

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(8));
            IWebElement success = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#center_column > p")));
            Assert.IsTrue(success.Displayed);

            var successMsg = Driver.driver.FindElement(By.CssSelector("#center_column > p"));
            Assert.AreEqual(Config.SuccessMsg.MessageSent, successMsg.Text);
        }

        [Test]
        public void DifferentEmail()
        {
            Actions.FillContactFormDifferentEmail(Config.ContactUsData.Valid.Email,
                                                  Config.ContactUsData.Valid.Message);

            var successMsg = Driver.driver.FindElement(By.CssSelector("#center_column > p"));
            Assert.AreEqual(Config.SuccessMsg.MessageSent, successMsg.Text);
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
