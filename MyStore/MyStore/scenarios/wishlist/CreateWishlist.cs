
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace MyStore.scenarios.wishlist
{
    public class CreateWishlist
    {
        public CreateWishlist()
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
        public void WishlistCreate()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Email, Config.Credentials.Valid.Password);
            NavigateTo.FromMyAccountToWishlist();

            Actions.NewWishlist();

            var tableWishlist = Driver.driver.FindElement(By.CssSelector("#wishlist_53951 > td:nth-child(1) > a"));
            Assert.AreEqual("First wishlist", tableWishlist.Text);

            NavigateTo.FromNavigationToWomenPage();

            Actions.AddToWishlist();

            NavigateTo.GoToMyAccountPage();

            NavigateTo.FromMyAccountToWishlist();

            var tableQuantity = Driver.driver.FindElement(By.CssSelector("#wishlist_53951 > td.bold.align_center"));
            Assert.AreEqual("5", tableQuantity.Text);

        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
