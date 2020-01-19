using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        
        [Test]
        public void GroupCreationTest()
        {
            OpenHomePage();
            loginHelper.Login(new AccountData("admin","secret"));
            GoToGroupsPage();
            InitGroupCreation();
            FillGroupForms(new GroupData("aaa"));
            SubmitGroupCreation();
            ReturnToGroupPage();
            Logout();
        }                  
    }
}
