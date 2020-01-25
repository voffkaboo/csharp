using OpenQA.Selenium;

namespace WebAddressBookTests
{
    public class LoginHelper : HelperBase
    {
        public LoginHelper(AppManager manager) : base(manager)
        {
        }
        public void Login(AccountData account)
        {
            driver.FindElement(By.Name("user")).SendKeys(account.UserName);
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
        }
    }
}
