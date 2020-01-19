using OpenQA.Selenium;

namespace WebAddressBookTests
{
    public class NavigationHelper
    {
        private IWebDriver driver;

        public NavigationHelper(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl("http://localhost/addressbook/");
            driver.Manage().Window.Size = new System.Drawing.Size(1050, 708);
        }

        public void GoToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
        public void ReturnToGroupPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
        }
    }
}
