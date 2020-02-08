using OpenQA.Selenium;

namespace WebAddressBookTests
{
    public class NavigationHelper : HelperBase
    {
        public NavigationHelper(AppManager manager) : base(manager)
        {
        }
        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl("http://localhost/addressbook/");
            driver.Manage().Window.Size = new System.Drawing.Size(1050, 708);
        }

        public void GoToGroupsPage()
        {
            if (driver.Url == "http://localhost/addressbook/group.php" 
                && IsElementPresent(By.Name("new")))
            {
                return;
            }
            driver.FindElement(By.LinkText("groups")).Click();
        }
        public void ReturnToGroupPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
        }
    }
}
