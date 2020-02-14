using NUnit.Framework;

namespace WebAddressBookTests
{
    [Parallelizable(ParallelScope.Fixtures)]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            int contactIndex = 0;
            var contactModel = ContactFixtureBuilder.CreateNew().Build();
            app.Contact.Modify(contactIndex, contactModel);
        }
    }
}