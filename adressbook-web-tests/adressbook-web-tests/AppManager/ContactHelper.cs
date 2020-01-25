using NUnit.Framework;
using OpenQA.Selenium;
using System.IO;

namespace WebAddressBookTests
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(AppManager manager) : base(manager)
        {
        }
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

        internal ContactHelper Modify(int indexNumber, ContactData modifyData)
        {
            SelectContact(indexNumber);
            InitiateContactModification();
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

        public ContactHelper FillContactForms(ContactData contact)
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.FirstName);
            driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("middlename")).SendKeys(contact.MiddleName);
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.LastName);
            driver.FindElement(By.Name("nickname")).Clear();
            driver.FindElement(By.Name("nickname")).SendKeys(contact.NickName);
            driver.FindElement(By.Name("photo")).Clear();
            var path = Path.Combine(TestContext.CurrentContext.TestDirectory, @"IMAGE\", "img.jpg");
            driver.FindElement(By.Name("photo")).SendKeys(path);
            driver.FindElement(By.Name("title")).Clear();
            driver.FindElement(By.Name("title")).SendKeys(contact.Title);
            driver.FindElement(By.Name("company")).Clear();
            driver.FindElement(By.Name("company")).SendKeys(contact.Company);
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys(contact.Address);
            driver.FindElement(By.Name("home")).Clear();
            driver.FindElement(By.Name("home")).SendKeys(contact.PhoneHome);
            driver.FindElement(By.Name("mobile")).Clear();
            driver.FindElement(By.Name("mobile")).SendKeys(contact.PhoneMobile);
            driver.FindElement(By.Name("work")).Clear();
            driver.FindElement(By.Name("work")).SendKeys(contact.PhoneWork);
            driver.FindElement(By.Name("title")).Clear();
            driver.FindElement(By.Name("title")).SendKeys(contact.Title);
            driver.FindElement(By.Name("company")).Clear();
            driver.FindElement(By.Name("company")).SendKeys(contact.Company);
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys(contact.Address);
            driver.FindElement(By.Name("fax")).Clear();
            driver.FindElement(By.Name("fax")).SendKeys(contact.Fax);
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys(contact.Email1);
            driver.FindElement(By.Name("email2")).Clear();
            driver.FindElement(By.Name("email2")).SendKeys(contact.Email2);
            driver.FindElement(By.Name("email3")).Clear();
            driver.FindElement(By.Name("email3")).SendKeys(contact.Email3);
            driver.FindElement(By.Name("homepage")).Clear();
            driver.FindElement(By.Name("homepage")).SendKeys(contact.Homepage);
            this.SelectBirthday(contact);
            this.SelectAnniversaryDate(contact);
            driver.FindElement(By.Name("address2")).Click();
            driver.FindElement(By.Name("address2")).Clear();
            driver.FindElement(By.Name("address2")).SendKeys(contact.SecondAddress);
            driver.FindElement(By.Name("phone2")).Click();
            driver.FindElement(By.Name("phone2")).Clear();
            driver.FindElement(By.Name("phone2")).SendKeys(contact.PhoneHome2);
            driver.FindElement(By.Name("notes")).Click();
            driver.FindElement(By.Name("notes")).Clear();
            driver.FindElement(By.Name("notes")).SendKeys(contact.Notes);            
            driver.FindElement(By.CssSelector("input[type='submit']~input[type='submit']")).Click();
            return this;
        }
        protected ContactHelper SelectBirthday(ContactData contact)
        {
            driver.FindElement(By.Name("bday")).Click();
            var dropdownBday = driver.FindElement(By.Name("bday"));
            dropdownBday.FindElement(By.XPath($"./option[@value='{contact.BirthDay}']")).Click();
            driver.FindElement(By.Name("bday")).Click();
            driver.FindElement(By.Name("bmonth")).Click();
            var dropdownBMonth = driver.FindElement(By.Name("bmonth"));
            dropdownBMonth.FindElement(By.XPath($"./option[@value='{contact.BirthMonth}' or @value='{contact.BirthMonth.ToLower()}']")).Click();
            driver.FindElement(By.Name("bmonth")).Click();
            driver.FindElement(By.Name("byear")).Click();
            driver.FindElement(By.Name("byear")).SendKeys(contact.BirthYear);
            return this;
        }

        protected ContactHelper SelectAnniversaryDate(ContactData contact)
        {
            driver.FindElement(By.Name("aday")).Click();
            var dropdownADay = driver.FindElement(By.Name("aday"));
            dropdownADay.FindElement(By.XPath($"./option[@value='{contact.AnniversaryDay}']")).Click();
            driver.FindElement(By.Name("aday")).Click();
            driver.FindElement(By.Name("aday")).SendKeys(contact.AnniversaryDay);
            driver.FindElement(By.Name("amonth")).Click();
            var dropdownAMonth = driver.FindElement(By.Name("amonth"));
            dropdownAMonth.FindElement(By.XPath($"./option[@value='{contact.AnniversaryMonth}' or @value='{contact.AnniversaryMonth.ToLower()}']")).Click();
            driver.FindElement(By.Name("amonth")).Click();
            driver.FindElement(By.Name("amonth")).SendKeys(contact.AnniversaryMonth);
            driver.FindElement(By.Name("ayear")).Click();
            driver.FindElement(By.Name("ayear")).SendKeys(contact.AnniversaryYear);
            return this;
        }

        public ContactHelper InitiateContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }
    }
}
