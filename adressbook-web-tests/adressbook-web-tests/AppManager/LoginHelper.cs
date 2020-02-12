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
            if (IsLoggedIn())
            {
                if (IsLoggedIn(account))
                {
                    return;
                }
                Logout();
            }
            FillFieldOnlyIfDataExists(By.Name("user"), account.UserName);
            FillFieldOnlyIfDataExists(By.Name("pass"), account.Password);            
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
        }
        
        public bool IsLoggedIn()
        {
            return IsElementPresent(By.Name("logout"));
        }

        public bool IsLoggedIn(AccountData account)
        {
            return IsLoggedIn()
                && driver.FindElement(By.Name("logout"))
                         .FindElement(By.TagName("b")).Text
                         == "(" + account.UserName + ")";           
        }

        public void Logout()
        {
            if (IsLoggedIn())
            {
                driver.FindElement(By.LinkText("Logout")).Click();
            }
        }
    }
}
