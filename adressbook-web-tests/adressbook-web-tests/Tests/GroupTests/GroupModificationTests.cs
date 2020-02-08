using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {

        [Test]
        public void GroupModificationTest()
        {
            GroupData modifyData = new GroupData();
            modifyData.Header = "HeaderModified";
            modifyData.Footer = "FooterModified";

            app.Groups.Modify(1, modifyData);
        }
        [Test]
        public void GroupModificationTestV2()
        {
            var modifyData = new GroupFixtureBuilder().Build();
            app.Groups.Modify(1, modifyData);
        }
    }
}