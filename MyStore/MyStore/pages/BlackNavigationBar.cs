
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MyStore.pages
{
    public class BlackNavigationBar
    {
        public BlackNavigationBar()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#header > div.nav > div > div > nav > div:nth-child(1) > a")]
        public IWebElement NameLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#contact-link > a")]
        public IWebElement ContactUsLink { get; set; }
    }
}
