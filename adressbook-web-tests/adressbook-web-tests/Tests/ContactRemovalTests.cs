using NUnit.Framework;

namespace WebAddressBookTests 
{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {
        
        [Test]
        public void ContactRemovalTest()
        {
            app.Contact.RemoveCntactWithIndex(1);
        }       
    }
}