using MyStore.pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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

        public static void MrRadioBtn()
        {
            CreateAccountPage createAcc = new CreateAccountPage();
            createAcc.MrGender.Click();
        }

        public static void MrsRadioBtn()
        {
            CreateAccountPage createAcc = new CreateAccountPage();
            createAcc.MrsGender.Click();
        }
    }
}
