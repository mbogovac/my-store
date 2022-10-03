using MyStore.pages;

namespace MyStore
{
    public static class NavigateTo
    {
        public static void LoginFormThroughHomePage()
        {
            HomePage homePage = new HomePage();
            homePage.SignIn.Click();
        }
    }
}
