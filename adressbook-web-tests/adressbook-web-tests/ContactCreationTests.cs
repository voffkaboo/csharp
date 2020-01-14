﻿// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using WebAddressBookTests;
using System.IO;

namespace WebAddressBookTests
{
    [TestFixture]
    public class AccountCreationTest
    {
        private IWebDriver driver;
        
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void AccountCreation()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            InitiateAccountCreation();
            ContactData user = new ContactData("FirstNameTest", "SecondNameTest","MiddleNameTest");
            FillContactForms(user);
            GoToHomePage();
            Logout();
        }

        private void Logout()
        {
            driver.FindElement(By.XPath("//*[@id='top']/form/a")).Click();
        }

        private void GoToHomePage()
        {
            driver.FindElement(By.XPath("//*[@id='content']/div/i/a[2]")).Click();
        }

        private void FillContactForms(ContactData user)
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).SendKeys(user.FirstName);
            driver.FindElement(By.Name("middlename")).SendKeys(user.MiddleName);
            driver.FindElement(By.Name("lastname")).SendKeys(user.LastName);
            driver.FindElement(By.Name("nickname")).SendKeys(user.NickName);
            //file uploading
            string fileName = "img.jpg";
            string workingDirectory = Directory.GetParent(TestContext.CurrentContext.TestDirectory).Parent.FullName;
            string destinationPath = AppDomain.CurrentDomain.BaseDirectory;
            
            destinationPath = Path.Combine(destinationPath, fileName);
            string sourcePath = Path.Combine(workingDirectory, @"IMG\", fileName);
            File.Copy(sourcePath, destinationPath);
            string pathToFile = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img.jpg");
            driver.FindElement(By.Name("photo")).SendKeys(pathToFile);
          
            driver.FindElement(By.Name("title")).SendKeys(user.Title);
            driver.FindElement(By.Name("company")).SendKeys(user.Company);
            driver.FindElement(By.Name("address")).SendKeys(user.Address);
            driver.FindElement(By.Name("home")).SendKeys(user.PhoneHome);
            driver.FindElement(By.Name("mobile")).SendKeys(user.PhoneMobile);
            driver.FindElement(By.Name("work")).SendKeys(user.PhoneWork);
            driver.FindElement(By.Name("title")).SendKeys(user.Title);
            driver.FindElement(By.Name("company")).SendKeys(user.Company);
            driver.FindElement(By.Name("address")).SendKeys(user.Address);
            driver.FindElement(By.Name("fax")).SendKeys(user.Fax);
            driver.FindElement(By.Name("email")).SendKeys(user.Email1);
            driver.FindElement(By.Name("email2")).SendKeys(user.Email2);
            driver.FindElement(By.Name("email3")).SendKeys(user.Email3);
            driver.FindElement(By.Name("homepage")).SendKeys(user.Homepage);

            driver.FindElement(By.Name("bday")).SendKeys(user.Bday);
            driver.FindElement(By.Name("address2")).Click();
            driver.FindElement(By.Name("address2")).SendKeys(user.SecondAddress);
            driver.FindElement(By.Name("phone2")).Click();
            driver.FindElement(By.Name("phone2")).SendKeys(user.PhoneHome2);
            driver.FindElement(By.Name("notes")).Click();
            driver.FindElement(By.Name("notes")).SendKeys(user.Notes);
            this.SelectBirthday(user);
            this.SelectAnniversaryDate(user);
            driver.FindElement(By.CssSelector("input[type='submit']~input[type='submit']")).Click();
            }
        private void SelectBirthday(ContactData user)
        {
            driver.FindElement(By.Name("bday")).Click();
            {
                var dropdown = driver.FindElement(By.Name("bday"));
                dropdown.FindElement(By.XPath($"//select[@name='bday']/option[@value='{user.BirthDay}']")).Click();
            }
            driver.FindElement(By.Name("bday")).Click();
            driver.FindElement(By.Name("bmonth")).Click();
            {
                var dropdown = driver.FindElement(By.Name("bmonth"));
                dropdown.FindElement(By.XPath($"//select[@name='bmonth']/option[@value='{user.BirthMonth}']")).Click();
            }
            driver.FindElement(By.Name("bmonth")).Click();
            driver.FindElement(By.Name("byear")).Click();
            driver.FindElement(By.Name("byear")).SendKeys(user.BirthYear);
        }

        private void SelectAnniversaryDate(ContactData user)
        {
            driver.FindElement(By.Name("aday")).Click();
            {
                var dropdown = driver.FindElement(By.Name("aday"));
                dropdown.FindElement(By.XPath($"//select[@name='aday']/option[@value='{user.AnniversaryDay}']")).Click();
            }
            driver.FindElement(By.Name("aday")).Click();
            driver.FindElement(By.Name("aday")).SendKeys(user.AnniversaryDay);
            driver.FindElement(By.Name("amonth")).Click();
            {
                var dropdown = driver.FindElement(By.Name("amonth"));
                dropdown.FindElement(By.XPath($"//select[@name='amonth']/option[@value='{user.AnniversaryMonth}']")).Click();
            }
            driver.FindElement(By.Name("amonth")).Click();
            driver.FindElement(By.Name("amonth")).SendKeys(user.AnniversaryMonth);
            driver.FindElement(By.Name("ayear")).Click();
            driver.FindElement(By.Name("ayear")).SendKeys(user.AnniversaryYear);
        }

        private void InitiateAccountCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }

        private void Login(AccountData account)
        {
            driver.FindElement(By.Name("user")).SendKeys(account.UserName);
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
        }

        private void OpenHomePage()
        {
            driver.Navigate().GoToUrl("http://localhost/addressbook/");
            driver.Manage().Window.Size = new System.Drawing.Size(1050, 708);
        }
    }
}