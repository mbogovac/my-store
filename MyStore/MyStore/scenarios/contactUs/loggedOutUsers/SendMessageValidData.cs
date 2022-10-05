
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace MyStore.scenarios.contactUs.loggedOutUsers
{
    public class SendMessageValidData
    {
        public SendMessageValidData()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.ConactUsThroughHomePage();

            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void EnterValidData()
        {
            Actions.FillContactUsForm(Config.ContactUsData.Valid.Email,
                                      Config.ContactUsData.Valid.OrderRef,
                                      Config.ContactUsData.Valid.Message);

            var successMsg = Driver.driver.FindElement(By.CssSelector("#center_column > p"));
            Assert.AreEqual(Config.SuccessMsg.MessageSent, successMsg.Text);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
