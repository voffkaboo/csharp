using NUnit.Framework;

namespace WebAddressBookTests
{
    [Parallelizable(ParallelScope.Fixtures)]
    public class ContactCreationTests : AuthTestBase
    {
        [Test]
        public void CreateContactTest() => app.ContactBuilder.Build();
    }
}