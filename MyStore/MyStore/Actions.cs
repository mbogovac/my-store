using MyStore.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace MyStore
{
    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseUrl);
        }

        public static void FillLoginForm(string email, string password)
        {
            LoginForm loginForm = new LoginForm();

            loginForm.EmailField.Clear();
            loginForm.EmailField.SendKeys(email);
            loginForm.PasswordField.Clear();
            loginForm.PasswordField.SendKeys(password);
            loginForm.SignInButton.Click();
        }

        public static void EmailForForgottenPass(string email)
        {
            ForgotPasswordPage fpPage = new ForgotPasswordPage();
            fpPage.EmailField.Clear();
            fpPage.EmailField.SendKeys(email);
            fpPage.RetrievePassword.Click();
        }

        public static void FillAuthenticationForm(string email)
        {
            AuthenticationForm authForm = new AuthenticationForm();
            authForm.EmailAuthentication.Clear();
            authForm.EmailAuthentication.SendKeys(email);
            authForm.CreateAccount.Click();
        }

        public static void FillCreateAccountForm(string firstName, string lastName, string password, string address, string city, string zip, string phone)
        {
            CreateAccountPage createAcc = new CreateAccountPage();
            createAcc.FirstName.Clear();
            createAcc.FirstName.SendKeys(firstName);
            createAcc.LastName.Clear();
            createAcc.LastName.SendKeys(lastName);
            createAcc.Password.Clear();
            createAcc.Password.SendKeys(password);
            createAcc.Address.Clear();
            createAcc.Address.SendKeys(address);
            createAcc.City.Clear();
            createAcc.City.SendKeys(city);
            createAcc.PostalCode.Clear();
            createAcc.PostalCode.SendKeys(zip);
            createAcc.MobilePhone.Clear();
            createAcc.MobilePhone.SendKeys(phone);

            SelectElement s = new SelectElement(createAcc.StateDropDown);
            s.SelectByText("Florida");

            createAcc.SubmitAccount.Click();
        }

        public static void FillCreateAccountWithoutState(string firstName, string lastName, string password, string address, string city, string zip, string phone)
        {
            CreateAccountPage createAcc = new CreateAccountPage();
            createAcc.FirstName.Clear();
            createAcc.FirstName.SendKeys(firstName);
            createAcc.LastName.Clear();
            createAcc.LastName.SendKeys(lastName);
            createAcc.Password.Clear();
            createAcc.Password.SendKeys(password);
            createAcc.Address.Clear();
            createAcc.Address.SendKeys(address);
            createAcc.City.Clear();
            createAcc.City.SendKeys(city);
            createAcc.PostalCode.Clear();
            createAcc.PostalCode.SendKeys(zip);
            createAcc.MobilePhone.Clear();
            createAcc.MobilePhone.SendKeys(phone);

            createAcc.SubmitAccount.Click();
        }

        public static void FillContactUsForm (string email, string orderRef, string msg)
        {
            ContactUsPage contactUsPage = new ContactUsPage();

            SelectElement s = new SelectElement(contactUsPage.SubjectDropDown);
            s.SelectByText("Customer service");

            contactUsPage.Email.Clear();
            contactUsPage.Email.SendKeys(email);
            contactUsPage.OrderReference.Clear();
            contactUsPage.OrderReference.SendKeys(orderRef);
            contactUsPage.Message.Clear();
            contactUsPage.Message.SendKeys(msg);

            contactUsPage.SubmitMessage.Click();

        }

        public static void ContactFormEmptyDropDown(string email, string orderRef, string msg)
        {
            ContactUsPage contactUsPage = new ContactUsPage();

            SelectElement s = new SelectElement(contactUsPage.SubjectDropDown);
            s.SelectByText("-- Choose --");

            contactUsPage.Email.Clear();
            contactUsPage.Email.SendKeys(email);
            contactUsPage.OrderReference.Clear();
            contactUsPage.OrderReference.SendKeys(orderRef);
            contactUsPage.Message.Clear();
            contactUsPage.Message.SendKeys(msg);

            contactUsPage.SubmitMessage.Click();

        }

        public static void FillContactFormLoggedIn(string msg)
        {
            ContactUsPage contactUsPage = new ContactUsPage();

            SelectElement s = new SelectElement(contactUsPage.SubjectDropDown);
            s.SelectByText("Customer service");

            SelectElement sEl = new SelectElement(contactUsPage.OrderRefDropDown);
            sEl.SelectByIndex(1);

            contactUsPage.Message.Clear();
            contactUsPage.Message.SendKeys(msg);

            contactUsPage.SubmitMessage.Click();
        }

        public static void FillContactFormDifferentEmail(string email, string msg)
        {
            ContactUsPage contactUsPage = new ContactUsPage();

            SelectElement s = new SelectElement(contactUsPage.SubjectDropDown);
            s.SelectByText("Customer service");

            SelectElement sEl = new SelectElement(contactUsPage.OrderRefDropDown);
            sEl.SelectByIndex(1);

            contactUsPage.Email.Clear();
            contactUsPage.Email.SendKeys(email);
            contactUsPage.Message.Clear();
            contactUsPage.Message.SendKeys(msg);

            contactUsPage.SubmitMessage.Click();
        }

        public static void AddToCart()
        {
            WomenPage womenPage = new WomenPage();
            womenPage.AddToCart.Click();

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(7));
            IWebElement productAdded = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"layer_cart\"]/div[1]/div[1]/h2")));

            womenPage.ProceedToCheckout.Click();
        }

        public static void AddToCartAndChangeDetails(string quantity)
        {
            WomenPage womenPage = new WomenPage();
            womenPage.ProductImageLink.Click();

            womenPage.PlusIcon.Click();
            Thread.Sleep(1000);
            womenPage.PlusIcon.Click();
            Thread.Sleep(1000);
            womenPage.MinusIcon.Click();
            Thread.Sleep(1000);
            womenPage.Quantity.Clear();
            womenPage.Quantity.SendKeys(quantity);
            Thread.Sleep(1000);

            SelectElement s = new SelectElement(womenPage.SizeDropDown);
            s.SelectByText("L");

            womenPage.AddToCart2.Click();
        }

        public static void FinishOrder()
        {
            FinishOrderPage finishOrderPage = new FinishOrderPage();
            finishOrderPage.SummaryProceedToCheckot.Click();
            finishOrderPage.AddressProceedToCheckout.Click();
            finishOrderPage.TermsOfService.Click();
            finishOrderPage.ShippingProceedToCheckout.Click();
            finishOrderPage.BankWireMethod.Click();
            finishOrderPage.ConfirmOrder.Click();
        }

        public static void NewWishlist()
        {
            WishlistPage wishlistPage = new WishlistPage();
            wishlistPage.WishlistName.Clear();
            wishlistPage.WishlistName.SendKeys("First wishlist");
            wishlistPage.SaveWishlist.Click();
        }

        public static void AddToWishlist()
        {
            WomenPage womenPage = new WomenPage();

            womenPage.ProductImageLink.Click();
            womenPage.AddToWishlistButton.Click();

        }

    }
}
