using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        
        [Test]
        public void ContactCreationTest()
        {
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Contact.InitiateContactCreation();
            ContactData user = new ContactData("FirstNameTest", "SecondNameTest","MiddleNameTest");
            app.Contact.FillContactForms(user);
            app.Logout.Logout();
        }                        
    }
}