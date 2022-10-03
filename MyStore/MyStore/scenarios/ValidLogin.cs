
using NUnit.Framework;
using OpenQA.Selenium;

namespace MyStore.scenarios
{
    public class ValidLogin
    {
        public ValidLogin()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.LoginFormThroughHomePage();
        }

        [Test]
        public void ValidCredetials()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Email, Config.Credentials.Valid.Password);
            var signOut = Driver.driver.FindElement(By.ClassName("logout"));
            Assert.IsTrue(signOut.Displayed);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
