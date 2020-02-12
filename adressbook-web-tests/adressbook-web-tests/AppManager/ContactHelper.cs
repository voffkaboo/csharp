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
            manager.Navigator.OpenHomePage();            
            if (IsElementPresent(By.XPath("(//input[@name='selected[]'])[" + index + "]")))
            {
                driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
                return this;
            }
            else
            {
                manager.ContactBuilder.WithFirstName("createdCauseNoPrviousGroups").Build();
                manager.Navigator.OpenHomePage();
                driver.FindElement(By.Name("selected[]")).FindElement(By.XPath("//table[@id='maintable']//td[contains(text(),'createdCauseNoPrviousGroups')]")).Click();
                return this;
            }
        }
        public void GoToGroupsPage()
        {
            if (driver.Url == "http://localhost/addressbook/group.php"
                && IsElementPresent(By.Name("new")))
            {
                return;
            }
            driver.FindElement(By.LinkText("groups")).Click();
        }

        public ContactHelper FillContactForms(ContactData contact)
        {
            FillFieldOnlyIfDataExists(By.Name("firstname"), contact.FirstName);
            FillFieldOnlyIfDataExists(By.Name("middlename"), contact.MiddleName);
            FillFieldOnlyIfDataExists(By.Name("lastname"), contact.LastName);
            FillFieldOnlyIfDataExists(By.Name("nickname"), contact.NickName);
            var path = Path.Combine(TestContext.CurrentContext.TestDirectory, @"IMAGE\", "img.jpg");
            FillFieldOnlyIfDataExists(By.Name("photo"), path);
            FillFieldOnlyIfDataExists(By.Name("title"), contact.Title);
            FillFieldOnlyIfDataExists(By.Name("company"), contact.Company);
            FillFieldOnlyIfDataExists(By.Name("address"), contact.Address);
            FillFieldOnlyIfDataExists(By.Name("home"), contact.PhoneHome);
            FillFieldOnlyIfDataExists(By.Name("mobile"), contact.PhoneMobile);
            FillFieldOnlyIfDataExists(By.Name("work"), contact.PhoneWork);
            FillFieldOnlyIfDataExists(By.Name("fax"), contact.Fax);
            FillFieldOnlyIfDataExists(By.Name("email"), contact.Email1);
            FillFieldOnlyIfDataExists(By.Name("email2"), contact.Email2);
            FillFieldOnlyIfDataExists(By.Name("email3"), contact.Email3);
            FillFieldOnlyIfDataExists(By.Name("homepage"), contact.Homepage);
            FillFieldOnlyIfDataExists(By.Name("address2"), contact.SecondAddress);
            SelectBirthday(contact);
            SelectAnniversaryDate(contact);
            FillFieldOnlyIfDataExists(By.Name("phone2"), contact.PhoneHome2);
            FillFieldOnlyIfDataExists(By.Name("notes"), contact.Notes);
            
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

        public void Create(ContactData contact)
        {
            InitiateContactCreation();
            FillContactForms(contact);            
        }
    }
}
