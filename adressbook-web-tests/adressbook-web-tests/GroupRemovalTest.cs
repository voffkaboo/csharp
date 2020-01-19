using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        
        [Test]
        public void GroupRemovalTest()
        {
            OpenHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            GoToGroupPage();
            SelectGroup(1);
            RemoveGroup();
            ReturnToGroupsPage();
        }                    
    }
}