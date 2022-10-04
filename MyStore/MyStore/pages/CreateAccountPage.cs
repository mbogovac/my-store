
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MyStore.pages
{
    public class CreateAccountPage
    {
        public CreateAccountPage()
        {
            PageFactory.InitElements(Driver.driver,this);
        }

        [FindsBy(How = How.Id, Using = "id_gender1")]
        public IWebElement MrGender { get; set; }

        [FindsBy(How = How.Id, Using = "id_gender2")]
        public IWebElement MrsGender { get; set; }

        [FindsBy(How = How.Id, Using = "customer_firstname")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "customer_lastname")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "address1")]
        public IWebElement Address { get; set; }

        [FindsBy(How = How.Id, Using = "city")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.Id, Using = "id_state")]
        public IWebElement StateDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "postcode")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.Id, Using = "phone_mobile")]
        public IWebElement MobilePhone { get; set; }

        [FindsBy(How = How.Id, Using = "submitAccount")]
        public IWebElement SubmitAccount { get; set; }
    }
}
