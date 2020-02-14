using NUnit.Framework;

namespace WebAddressBookTests
{
    [Parallelizable(ParallelScope.Fixtures)]
    public class GroupCreationTests : AuthTestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            app.GroupBuilder
                .WithName("aaa")
                .WithHeader("header")
                .WithFooter("")
                .Build();
            app.Navigator.ReturnToGroupPage();            
        }
    }
}
