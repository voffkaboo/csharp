using NUnit.Framework;

namespace WebAddressBookTests 
{
    [TestFixture]
    public class ContactRemovalTests : TestBase
    {
        
        [Test]
        public void ContactRemovalTest()
        {
            navigationHelper.OpenHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            contactHelper.SelectContact(1);
            contactHelper.RemoveContact();
            contactHelper.AcceptRemovalViaPopUp();
        }       
    }
}