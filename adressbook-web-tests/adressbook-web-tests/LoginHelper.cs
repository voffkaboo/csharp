using OpenQA.Selenium;

namespace WebAddressBookTests
{
    public class LoginHelper
    {
        private IWebDriver driver;

        public LoginHelper(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void Login(AccountData account)
        {
            driver.FindElement(By.Name("user")).SendKeys(account.UserName);
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
        }        
    }
}
