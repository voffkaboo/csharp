using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTestV2()
        {
            int contactIndex = 1;
            var contactModel = new ContactFixtureBuilder().Build();
            app.Contact.Modify(contactIndex, contactModel);
        }
    }
}