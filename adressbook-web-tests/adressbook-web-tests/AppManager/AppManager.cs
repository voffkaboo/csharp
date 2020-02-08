using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace WebAddressBookTests
{
    public class AppManager
    {
        protected IWebDriver driver;

        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;
        protected GroupBuilder groupBuilder;
        protected ContactBuilder contactBuilder;


        private static ThreadLocal<AppManager> app= new ThreadLocal<AppManager>();

        private AppManager()
        {
            driver = new ChromeDriver();
            loginHelper = new LoginHelper(this);
            navigationHelper = new NavigationHelper(this);
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);
            groupBuilder = new GroupBuilder(this);
            contactBuilder = new ContactBuilder(this);
        }
        ~AppManager()
        {
            driver.Quit();
        }
        public static AppManager GetInstance()
        {
            if (!app.IsValueCreated)
            {
                AppManager newInstance = new AppManager();
                newInstance.Navigator.OpenHomePage();
                app.Value = newInstance;                
            }
            return app.Value;
        }
        public IWebDriver Driver=> driver;
        public LoginHelper Auth => loginHelper;
        public NavigationHelper Navigator => navigationHelper;
        public GroupHelper Groups => groupHelper;
        public ContactHelper Contact => contactHelper;
        public GroupBuilder GroupBuilder => groupBuilder;
        public ContactBuilder ContactBuilder => contactBuilder;
    }
}
