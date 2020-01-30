using System;
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
            if (isLoggedIn())
            {
                if (isLoggedIn(account))
                {
                    return;
                }
                Logout();
            }
            FillFieldOnlyIfDataExists(By.Name("user"), account.UserName);
            FillFieldOnlyIfDataExists(By.Name("pass"), account.Password);            
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
        }
        
        public bool isLoggedIn()
        {
            return IsElementPresent(By.Name("logout"));
        }

        public bool isLoggedIn(AccountData account)
        {
            return isLoggedIn()
                && driver.FindElement(By.Name("logout"))
                         .FindElement(By.TagName("b")).Text
                         == "(" + account.UserName + ")";           
        }

        public void Logout()
        {
            if (isLoggedIn())
            {
                driver.FindElement(By.LinkText("Logout")).Click();
            }
        }
    }
}
