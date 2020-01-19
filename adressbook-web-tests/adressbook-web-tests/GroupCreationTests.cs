using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        
        [Test]
        public void GroupCreationTest()
        {
            navigationHelper.OpenHomePage();
            loginHelper.Login(new AccountData("admin","secret"));
            navigationHelper.GoToGroupsPage();
            groupHelper.InitGroupCreation();
            groupHelper.FillGroupForms(new GroupData("aaa"));
            groupHelper.SubmitGroupCreation();
            navigationHelper.ReturnToGroupPage();
            Logout();
        }                  
    }
}
