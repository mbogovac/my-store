using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MyStore.pages
{
    public class LoginForm
    {
        public LoginForm()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        public IWebElement SignInButton { get; set; }

    }
}
