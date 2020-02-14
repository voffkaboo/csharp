using NUnit.Framework;

namespace WebAddressBookTests 
{
    [Parallelizable(ParallelScope.Fixtures)]
    public class ContactRemovalTests : AuthTestBase
    {
        
        [Test]
        public void ContactRemovalTest()
        {
            app.Contact.RemoveCntactWithIndex(0);
        }
    }
}