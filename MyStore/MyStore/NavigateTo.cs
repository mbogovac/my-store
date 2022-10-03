using MyStore.pages;
using System.Threading;

namespace MyStore
{
    public static class NavigateTo
    {
        public static void LoginFormThroughHomePage()
        {
            HomePage homePage = new HomePage();
            homePage.SignIn.Click();
        }

        public static void ForgotYourPasswordPage()
        {
            HomePage homePage = new HomePage();
            LoginForm loginForm = new LoginForm();

            homePage.SignIn.Click();
            Thread.Sleep(2000);
            loginForm.ForgotPasswordLink.Click();
        }
    }
}
