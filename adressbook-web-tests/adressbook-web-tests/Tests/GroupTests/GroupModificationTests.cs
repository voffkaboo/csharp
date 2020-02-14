using NUnit.Framework;

namespace WebAddressBookTests
{
    [Parallelizable(ParallelScope.Fixtures)]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            var modifyData = GroupFixtureBuilder.CreateNew().Build();
            app.Groups.Modify(0, modifyData);
        }
    }
}