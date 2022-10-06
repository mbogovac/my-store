
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MyStore.pages
{
    public class WishlistPage
    {
        public WishlistPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "name")]
        public IWebElement WishlistName { get; set; }

        [FindsBy(How = How.Id, Using = "submitWishlist")]
        public IWebElement SaveWishlist { get; set; }
    }
}
