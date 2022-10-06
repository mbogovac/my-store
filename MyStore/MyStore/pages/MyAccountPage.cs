
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MyStore.pages
{
    public class MyAccountPage
    {
        public MyAccountPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#contact-link > a")]
        public IWebElement ContactUsLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#center_column > div > div:nth-child(2) > ul > li > a > span")]
        public IWebElement MyWishListLink { get; set; }
    }
}
