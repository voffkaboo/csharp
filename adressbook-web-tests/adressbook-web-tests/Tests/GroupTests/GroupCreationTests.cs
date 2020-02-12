using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {
        [Test]
        public void GroupCreationTestV2()
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
