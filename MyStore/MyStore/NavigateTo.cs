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

        public static void FromNavigationToWomenPage()
        {
            NavigationBar navigationBar = new NavigationBar();
            navigationBar.WomenLink.Click();
        }

        public static void ForgotYourPasswordPage()
        {
            HomePage homePage = new HomePage();
            LoginForm loginForm = new LoginForm();

            homePage.SignIn.Click();
            Thread.Sleep(2000);
            loginForm.ForgotPasswordLink.Click();
        }

        public static void ConactUsFromBlackNavBar()
        {
            BlackNavigationBar blackNavigationBar = new BlackNavigationBar();
            blackNavigationBar.ContactUsLink.Click();
        }

        public static void FromMyAccountToWishlist()
        {
            MyAccountPage myAccountPage = new MyAccountPage();
            myAccountPage.MyWishListLink.Click();
        }

        public static void GoToMyAccountPage()
        {
            BlackNavigationBar blackNavigationBar = new BlackNavigationBar();
            blackNavigationBar.NameLink.Click();
        }
    }
}
