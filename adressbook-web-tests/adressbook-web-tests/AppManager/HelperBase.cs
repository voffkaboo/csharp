using OpenQA.Selenium;

namespace WebAddressBookTests
{
    public class HelperBase
    {
        public AppManager manager;
        public IWebDriver driver;
        public HelperBase(AppManager manager)
        {
            this.manager = manager;
            driver = manager.Driver;
        }
        public void FillFieldOnlyIfDataExists(By field, string contactData)
        {
            if (contactData != null)
            {
                driver.FindElement(field).Clear();
                driver.FindElement(field).SendKeys(contactData);
            }            
        }
    }
}