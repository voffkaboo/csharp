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
        public ContactHelper RemoveCntactWithIndex(int contactIndex)
        {
            SelectContact(contactIndex);
            RemoveContact();
            AcceptRemovalViaPopUp();
            return this;
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
            FillFieldOnlyIfDataExists("firstname", contact.FirstName);
            FillFieldOnlyIfDataExists("middlename", contact.MiddleName);
            FillFieldOnlyIfDataExists("lastname", contact.LastName);
            FillFieldOnlyIfDataExists("nickname", contact.NickName);
            var path = Path.Combine(TestContext.CurrentContext.TestDirectory, @"IMAGE\", "img.jpg");
            FillFieldOnlyIfDataExists("photo", path);
            FillFieldOnlyIfDataExists("title", contact.Title);
            FillFieldOnlyIfDataExists("company", contact.Company);
            FillFieldOnlyIfDataExists("address", contact.Address);
            FillFieldOnlyIfDataExists("home", contact.PhoneHome);
            FillFieldOnlyIfDataExists("mobile", contact.PhoneMobile);
            FillFieldOnlyIfDataExists("work", contact.PhoneWork);
            FillFieldOnlyIfDataExists("fax", contact.Fax);
            FillFieldOnlyIfDataExists("email", contact.Email1);
            FillFieldOnlyIfDataExists("emai2", contact.Email2);
            FillFieldOnlyIfDataExists("emai3", contact.Email3);
            FillFieldOnlyIfDataExists("homepage", contact.Homepage);
            FillFieldOnlyIfDataExists("address2", contact.SecondAddress);
            SelectBirthday(contact);
            SelectAnniversaryDate(contact);
            FillFieldOnlyIfDataExists("phone2", contact.PhoneHome2);
            FillFieldOnlyIfDataExists("notes", contact.Notes);
            
            driver.FindElement(By.CssSelector("input[type='submit']~input[type='submit']")).Click();
            return this;
        }

        protected ContactHelper FillFieldOnlyIfDataExists(string fieldName, string contactData)
        {
            if (contactData!=null)
            {
                driver.FindElement(By.Name(fieldName)).Clear();
                driver.FindElement(By.Name(fieldName)).SendKeys(contactData);
            }
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
