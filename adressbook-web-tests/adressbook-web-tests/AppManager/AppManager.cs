using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebAddressBookTests
{
    public class AppManager
    {
        protected IWebDriver driver;

        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;
        protected LogoutHelper logoutHelper;

        public AppManager()
        {
            driver = new ChromeDriver();
            loginHelper = new LoginHelper(this);
            navigationHelper = new NavigationHelper(this);
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);
            logoutHelper = new LogoutHelper(this);
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }
        public LoginHelper Auth
        {
            get => loginHelper;
        }
        public NavigationHelper Navigator
        {
            get => navigationHelper;
        }
        public GroupHelper Groups
        {
            get => groupHelper;
        }
        public ContactHelper Contact
        {
            get => contactHelper;
        }
        public LogoutHelper Logout
        {
            get => logoutHelper;
        }
        public void Stop()
        {
            driver.Quit();
        }
    }
}
