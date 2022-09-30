using SeleniumExtras.PageObjects;

namespace MyStore.pages
{
    public class AuthenticationPage
    {
        public AuthenticationPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
    }
}
