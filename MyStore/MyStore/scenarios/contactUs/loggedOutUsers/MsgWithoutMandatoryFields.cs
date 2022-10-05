
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace MyStore.scenarios.contactUs.loggedOutUsers
{
    public class MsgWithoutMandatoryFields
    {
        public MsgWithoutMandatoryFields()
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
        public void AllEmptyData()
        {
            Actions.ContactFormEmptyDropDown(Config.ContactUsData.Invalid.Empty,
                                             Config.ContactUsData.Invalid.Empty,
                                             Config.ContactUsData.Invalid.Empty);

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(8));
            IWebElement registrationHeading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#center_column > div > ol > li")));
            Assert.IsTrue(registrationHeading.Displayed);

            var error = Driver.driver.FindElement(By.CssSelector("#center_column > div > ol > li"));
            Assert.AreEqual(Config.ErrorMessages.InvalidEmail, error.Text);
        }

        [Test]
        public void WithoutEmail()
        {
            Actions.FillContactUsForm(Config.ContactUsData.Invalid.Empty,
                                      Config.ContactUsData.Valid.OrderRef,
                                      Config.ContactUsData.Valid.Message);

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(8));
            IWebElement registrationHeading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#center_column > div > ol > li")));
            Assert.IsTrue(registrationHeading.Displayed);

            var error = Driver.driver.FindElement(By.CssSelector("#center_column > div > ol > li"));
            Assert.AreEqual(Config.ErrorMessages.InvalidEmail, error.Text);
        }

        [Test]
        public void WithoutMessage()
        {
            Actions.FillContactUsForm(Config.ContactUsData.Valid.Email,
                                      Config.ContactUsData.Valid.OrderRef,
                                      Config.ContactUsData.Invalid.Empty);

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(8));
            IWebElement registrationHeading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#center_column > div > ol > li")));
            Assert.IsTrue(registrationHeading.Displayed);

            var error = Driver.driver.FindElement(By.CssSelector("#center_column > div > ol > li"));
            Assert.AreEqual(Config.ErrorMessages.EmptyMessageField, error.Text);
        }

        [Test]
        public void WithoutSubject()
        {
            Actions.ContactFormEmptyDropDown(Config.ContactUsData.Valid.Email,
                                             Config.ContactUsData.Valid.OrderRef,
                                             Config.ContactUsData.Valid.Message);

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(8));
            IWebElement registrationHeading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#center_column > div > ol > li")));
            Assert.IsTrue(registrationHeading.Displayed);

            var error = Driver.driver.FindElement(By.CssSelector("#center_column > div > ol > li"));
            Assert.AreEqual(Config.ErrorMessages.NothingInDropDown, error.Text);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
