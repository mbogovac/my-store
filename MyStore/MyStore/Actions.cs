using MyStore.pages;
using OpenQA.Selenium.Chrome;
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
    }
}
