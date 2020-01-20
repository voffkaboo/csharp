﻿using OpenQA.Selenium;

namespace WebAddressBookTests
{
    public class LogoutHelper : HelperBase
    {
        public LogoutHelper(IWebDriver driver) : base(driver){}
        public void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }
    }
}
