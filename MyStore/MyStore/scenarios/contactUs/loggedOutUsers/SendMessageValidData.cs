
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
            NavigateTo.ConactUsFromBlackNavBar();

            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void AllValidData()
        {
            Actions.FillContactUsForm(Config.ContactUsData.Valid.Email,
                                      Config.ContactUsData.Valid.OrderRef,
                                      Config.ContactUsData.Valid.Message);

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(8));
            IWebElement success = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#center_column > p")));
            Assert.IsTrue(success.Displayed);

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
