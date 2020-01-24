using NUnit.Framework;
using OpenQA.Selenium;
using System.IO;

namespace WebAddressBookTests
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(AppManager manager) : base(manager) { }
        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }
        public ContactHelper AcceptRemovalViaPopUp()
        {
            driver.SwitchTo().Alert().Accept();
            return this;
        }

        internal ContactHelper Modify(int v, ContactData modifyData)
        {
            SelectContact(v);
            InitiateContactModification();
            DeleteFilledContactForms();
            FillContactForms(modifyData);
            manager.Navigator.GoToGroupsPage();
            return this;
        }

        public ContactHelper InitiateContactModification()
        {
            driver.FindElement(By.XPath("(//img[@title='Edit'])")).Click();
            return this;
        }

        public ContactHelper SelectContact(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
        }

        public ContactHelper DeleteFilledContactForms()
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("nickname")).Clear();
            driver.FindElement(By.Name("photo")).Clear();
            driver.FindElement(By.Name("title")).Clear();
            driver.FindElement(By.Name("company")).Clear();
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("home")).Clear();
            driver.FindElement(By.Name("mobile")).Clear();
            driver.FindElement(By.Name("work")).Clear();
            driver.FindElement(By.Name("title")).Clear();
            driver.FindElement(By.Name("company")).Clear();
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("fax")).Clear();
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email2")).Clear();
            driver.FindElement(By.Name("email3")).Clear();
            driver.FindElement(By.Name("homepage")).Clear();
            driver.FindElement(By.Name("address2")).Clear();
            driver.FindElement(By.Name("phone2")).Clear();
            return this;
        }

            public ContactHelper FillContactForms(ContactData user)
        {            
            driver.FindElement(By.Name("firstname")).SendKeys(user.FirstName);
            driver.FindElement(By.Name("middlename")).SendKeys(user.MiddleName);            
            driver.FindElement(By.Name("lastname")).SendKeys(user.LastName);            
            driver.FindElement(By.Name("nickname")).SendKeys(user.NickName);
            //file uploading            
            driver.FindElement(By.Name("photo")).SendKeys(Path
                .Combine(TestContext.CurrentContext.TestDirectory, @"IMAGE\", "img.jpg"));            
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
            driver.FindElement(By.Name("address2")).Click();            
            driver.FindElement(By.Name("address2")).SendKeys(user.SecondAddress);            
            driver.FindElement(By.Name("phone2")).Click();            
            driver.FindElement(By.Name("phone2")).SendKeys(user.PhoneHome2);
            driver.FindElement(By.Name("notes")).Click();
            driver.FindElement(By.Name("notes")).SendKeys(user.Notes);
            this.SelectBirthday(user);
            this.SelectAnniversaryDate(user);
            driver.FindElement(By.CssSelector("input[type='submit']~input[type='submit']")).Click();
            return this;
        }
        protected ContactHelper SelectBirthday(ContactData user)
        {
            driver.FindElement(By.Name("bday")).Click();
            var dropdownBday = driver.FindElement(By.Name("bday"));
            dropdownBday.FindElement(By.XPath($"//select[@name='bday']/option[@value='{user.BirthDay}']")).Click();
            driver.FindElement(By.Name("bday")).Click();
            driver.FindElement(By.Name("bmonth")).Click();
            var dropdownBMonth = driver.FindElement(By.Name("bmonth"));
            dropdownBMonth.FindElement(By.XPath($"//select[@name='bmonth']/option[@value='{user.BirthMonth}']")).Click();
            driver.FindElement(By.Name("bmonth")).Click();
            driver.FindElement(By.Name("byear")).Click();
            driver.FindElement(By.Name("byear")).SendKeys(user.BirthYear);
            return this;
        }

        protected ContactHelper SelectAnniversaryDate(ContactData user)
        {
            driver.FindElement(By.Name("aday")).Click();
            var dropdownADay = driver.FindElement(By.Name("aday"));
            dropdownADay.FindElement(By.XPath($"//select[@name='aday']/option[@value='{user.AnniversaryDay}']")).Click();
            driver.FindElement(By.Name("aday")).Click();
            driver.FindElement(By.Name("aday")).SendKeys(user.AnniversaryDay);
            driver.FindElement(By.Name("amonth")).Click();
            var dropdownAMonth = driver.FindElement(By.Name("amonth"));
            dropdownAMonth.FindElement(By.CssSelector($"option[value='{user.AnniversaryMonth.ToLower()}']")).Click();
            driver.FindElement(By.Name("amonth")).Click();
            driver.FindElement(By.Name("amonth")).SendKeys(user.AnniversaryMonth);
            driver.FindElement(By.Name("ayear")).Click();
            driver.FindElement(By.Name("ayear")).SendKeys(user.AnniversaryYear);
            return this;
        }

        public ContactHelper InitiateContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }
    }
}
