
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MyStore.pages
{
    public class ContactUsPage
    {
        public ContactUsPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "id_contact")]
        public IWebElement SubjectDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "id_order")]
        public IWebElement OrderReference { get; set; }

        [FindsBy(How = How.Id, Using = "message")]
        public IWebElement Message { get; set; }

        [FindsBy(How = How.Id, Using = "submitMessage")]
        public IWebElement SubmitMessage { get; set; }

        [FindsBy(How = How.Name, Using = "id_order")]
        public IWebElement OrderRefDropDown { get; set; }
    }
}
