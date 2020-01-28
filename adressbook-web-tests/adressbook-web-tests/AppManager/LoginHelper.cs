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
            FillFieldOnlyIfDataExists(By.Name("user"), account.UserName);
            FillFieldOnlyIfDataExists(By.Name("pass"), account.Password);            
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
        }
    }
}
