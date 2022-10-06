
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MyStore.pages
{
    public class NavigationBar
    {
        public NavigationBar()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#block_top_menu > ul > li:nth-child(1) > a")]
        public IWebElement WomenLink { get; set; }
    }
}
