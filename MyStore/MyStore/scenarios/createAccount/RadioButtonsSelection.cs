
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace MyStore.scenarios.createAccount
{
    public class RadioButtonsSelection
    {
        public RadioButtonsSelection()
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
        public void TitleRadioButtons()
        {
            Actions.FillAuthenticationForm(Config.Credentials.Valid.UnregisteredEmail);
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(6));
            IWebElement registrationHeading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#account-creation_form > div:nth-child(1) > h3")));
            Assert.IsTrue(registrationHeading.Displayed);

            var spanMrChecked = Driver.driver.FindElement(By.CssSelector("#uniform-id_gender1 > span"));
            var spanMrsChecked = Driver.driver.FindElement(By.CssSelector("#uniform-id_gender2 > span"));

            Actions.SelectMrRadioButton();
            Assert.AreEqual("checked", spanMrChecked.GetAttribute("class"));
            Assert.AreEqual("", spanMrsChecked.GetAttribute("class"));

            Actions.SelectMrsRadioButton();
            Assert.AreEqual("checked", spanMrsChecked.GetAttribute("class"));
            Assert.AreEqual("", spanMrChecked.GetAttribute("class"));
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
