using NUnit.Framework;

namespace WebAddressBookTests 
{
    [TestFixture]
    public class ContactRemovalTests : TestBase
    {
        
        [Test]
        public void ContactRemovalTest()
        {
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Contact.SelectContact(1);
            app.Contact.RemoveContact();
            app.Contact.AcceptRemovalViaPopUp();
        }       
    }
}