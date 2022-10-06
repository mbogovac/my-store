
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MyStore.pages
{
    public class WomenPage
    {
        public WomenPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"center_column\"]/ul/li[1]/div/div[1]/div/a[1]/img")]
        public IWebElement Product1Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"center_column\"]/ul/li[1]/div/div[2]/div[2]/a[1]/span")]
        public IWebElement AddToCart { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\"layer_cart\"]/div[1]/div[1]/h2")]
        public IWebElement ProductAddedMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"layer_cart\"]/div[1]/div[2]/div[4]/a/span")]
        public IWebElement ProceedToCheckout { get; set; }
    }
}
