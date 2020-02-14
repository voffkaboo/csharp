using NUnit.Framework;

namespace WebAddressBookTests
{
    [Parallelizable(ParallelScope.Fixtures)]
    public class GroupRemovalTests : AuthTestBase
    {
        
        [Test]
        public void GroupRemovalTest()
        {
            app.Groups.RemoveGroup(0);        
        }                    
    }
}