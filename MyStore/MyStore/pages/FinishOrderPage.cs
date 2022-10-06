
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MyStore.pages
{
    public class FinishOrderPage
    {
        public FinishOrderPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"center_column\"]/p[2]/a[1]/span")]
        public IWebElement SummaryProceedToCheckot { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#center_column > form > p > button > span")]
        public IWebElement AddressProceedToCheckout { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form > p > button > span")]
        public IWebElement ShippingProceedToCheckout { get; set; }

        [FindsBy(How = How.Id, Using = "cgv")]
        public IWebElement TermsOfService { get; set; }

        [FindsBy(How = How.ClassName, Using = "bankwire")]
        public IWebElement BankWireMethod { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cart_navigation > button ")]
        public IWebElement ConfirmOrder { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#center_column > div > p > strong")]
        public IWebElement OrderCompleteText { get; set; }


    }
}
