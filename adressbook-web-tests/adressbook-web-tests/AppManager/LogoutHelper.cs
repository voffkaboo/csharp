using OpenQA.Selenium;

namespace WebAddressBookTests
{
    public class LogoutHelper : HelperBase
    {
        public LogoutHelper(AppManager manager) : base(manager)
        {
        }
        public void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }
    }
}
