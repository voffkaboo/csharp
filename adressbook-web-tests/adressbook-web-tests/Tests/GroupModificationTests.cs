using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupModificationTests : TestBase
    {

        [Test]
        public void GroupModificationTest()
        {
            GroupData modifyData = new GroupData("www");
            modifyData.Header = "HeaderModified";
            modifyData.Footer = "FooterModified";

            app.Groups.Modify(1, modifyData);
        }
    }
}