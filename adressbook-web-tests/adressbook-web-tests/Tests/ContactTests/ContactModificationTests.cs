using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            int contactIndex = 0;
            var contactModel = new ContactFixtureBuilder().Build();
            app.Contact.Modify(contactIndex, contactModel);
        }
    }
}