
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;

namespace MyStore.scenarios.contactUs.loggedOutUsers
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
            NavigateTo.ConactUsFromBlackNavBar();

            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void InvalidEmailFormat()
        {
            Actions.FillContactUsForm(Config.ContactUsData.Invalid.InvalidEmail,
                                      Config.ContactUsData.Valid.OrderRef,
                                      Config.ContactUsData.Valid.Message);

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(8));
            IWebElement registrationHeading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#center_column > div > ol > li")));
            Assert.IsTrue(registrationHeading.Displayed);

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
