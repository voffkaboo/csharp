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

        public IWebDriver Driver=> driver;
        public LoginHelper Auth => loginHelper;
        public NavigationHelper Navigator => navigationHelper;
        public GroupHelper Groups => groupHelper;
        public ContactHelper Contact => contactHelper;
        public LogoutHelper Logout => logoutHelper;
        public void Stop()
        {
            driver.Quit();
        }
    }
}
