using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.pages
{
    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver,this);
        }

        [FindsBy(How = How.ClassName, Using = "login")]
        public IWebElement SignIn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#contact-link > a")]
        public IWebElement ContactUs { get; set; }
    }
}
