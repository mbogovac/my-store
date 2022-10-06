
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

        [FindsBy(How = How.XPath, Using = "//*[@id=\"center_column\"]/ul/li[1]/div/div[1]/div/a[1]")]
        public IWebElement ProductImageLink { get; set; }

        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"center_column\"]/ul/li[1]/div/div[2]/div[2]/a[1]/span")]
        public IWebElement AddToCart { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\"layer_cart\"]/div[1]/div[1]/h2")]
        public IWebElement ProductAddedMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"layer_cart\"]/div[1]/div[2]/div[4]/a/span")]
        public IWebElement ProceedToCheckout { get; set; }

        [FindsBy(How = How.ClassName, Using = "icon-plus")]
        public IWebElement PlusIcon { get; set; }

        [FindsBy(How = How.ClassName, Using = "icon-minus")]
        public IWebElement MinusIcon { get; set; }

        [FindsBy(How = How.Id, Using = "quantity_wanted")]
        public IWebElement Quantity { get; set; }

        [FindsBy(How = How.Id, Using = "group_1")]
        public IWebElement SizeDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "color_14")]
        public IWebElement AnotherColor { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"add_to_cart\"]/button/span")]
        public IWebElement AddToCart2 { get; set; }

        [FindsBy(How = How.Id, Using = "wishlist_button")]
        public IWebElement AddToWishlistButton { get; set; }
    }
}
