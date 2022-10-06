
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace MyStore.scenarios.orderProduct
{
    public class ChangeProductDeatails
    {
        public ChangeProductDeatails()
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
        public void ChangeDetails()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Email, Config.Credentials.Valid.Password);
            NavigateTo.FromNavigationToWomenPage();

            Actions.AddToCartAndChangeDetails("5");

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            IWebElement quantity = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("layer_cart_product_attributes")));

            Assert.AreEqual("Orange, L", quantity.Text);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
