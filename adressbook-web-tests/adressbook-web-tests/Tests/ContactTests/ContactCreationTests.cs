using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
        [Test]
        public void CreateContactTestv2() => app.ContactBuilder.Build();
    }
}