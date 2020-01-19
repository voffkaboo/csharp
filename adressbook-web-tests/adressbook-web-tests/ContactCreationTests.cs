using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactCreationTest : TestBase
    {
        
        [Test]
        public void AccountCreation()
        {
            OpenHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            InitiateAccountCreation();
            ContactData user = new ContactData("FirstNameTest", "SecondNameTest","MiddleNameTest");
            FillContactForms(user);
            Logout();
        }                        
    }
}