
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MyStore.pages
{
    public class ForgotPasswordPage
    {
        public ForgotPasswordPage()
        {
            PageFactory.InitElements(Driver.driver,this);
        }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form_forgotpassword > fieldset > p > button")]
        public IWebElement RetrievePassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#center_column > div > div > ol > li")]
        public IWebElement ErrorMessage { get; set; } 
    }
}
