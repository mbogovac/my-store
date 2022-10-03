
using MyStore.pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MyStore.scenarios
{
    public class LoginInvalidEmail
    {
        public LoginInvalidEmail()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.LoginFormThroughHomePage();
        }

        [Test]
        public void InvalidEmail()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.Email, Config.Credentials.Valid.Password);

            var errorMessage = Driver.driver.FindElement(By.CssSelector("#center_column > div.alert.alert-danger > ol > li"));
            Assert.AreEqual(Config.ErrorMessages.InvalidEmail, errorMessage.Text);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
