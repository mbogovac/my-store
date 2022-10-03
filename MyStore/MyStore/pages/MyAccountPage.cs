
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

    }
}
