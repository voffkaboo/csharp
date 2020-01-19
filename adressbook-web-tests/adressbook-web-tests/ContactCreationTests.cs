using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactCreationTest : TestBase
    {
        
        [Test]
        public void AccountCreation()
        {
            navigationHelper.OpenHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            contactHelper.InitiateContactCreation();
            ContactData user = new ContactData("FirstNameTest", "SecondNameTest","MiddleNameTest");
            contactHelper.FillContactForms(user);
            Logout();
        }                        
    }
}