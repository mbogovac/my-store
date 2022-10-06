
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace MyStore.scenarios.orderProduct
{
    public class AddToCartAndOrder
    {
        public AddToCartAndOrder()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.LoginFormThroughHomePage();

            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
        }

        [Test]
        public void OrderProduct()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Email, Config.Credentials.Valid.Password);
            NavigateTo.FromNavigationToWomenPage();

            Actions.AddToCart();
            Actions.FinishOrder();

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(8));
            IWebElement success = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#center_column > div > p > strong")));
            
            Assert.AreEqual(Config.SuccessMsg.ProductOrdered, success.Text);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
