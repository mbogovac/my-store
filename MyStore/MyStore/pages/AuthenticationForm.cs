using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MyStore.pages
{
    public class AuthenticationForm
    {
        public AuthenticationForm()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "email_create")]
        public IWebElement EmailAuthentication { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        public IWebElement CreateAccount  { get; set; }
    }
}
