using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            var modifyData = new GroupFixtureBuilder().Build();
            app.Groups.Modify(0, modifyData);
        }
    }
}