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
    }
}