using NUnit.Framework;

namespace WebAddressBookTests 
{
    [TestFixture]
    public class ContactRemovalTests : TestBase
    {
        
        [Test]
        public void ContactRemovalTest()
        {
            OpenHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            SelectContact(1);
            RemoveContact();
            AcceptRemovalViaPopUp();
        }       
    }
}