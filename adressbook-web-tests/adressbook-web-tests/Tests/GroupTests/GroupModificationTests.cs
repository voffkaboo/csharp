using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTestV2()
        {
            var modifyData = new GroupFixtureBuilder().Build();
            app.Groups.Modify(1, modifyData);
        }
    }
}