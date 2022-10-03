using MyStore.pages;
using OpenQA.Selenium.Chrome;

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
    }
}
