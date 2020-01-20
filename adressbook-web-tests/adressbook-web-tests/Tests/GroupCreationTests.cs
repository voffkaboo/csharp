using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        
        [Test]
        public void GroupCreationTest()
        {
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin","secret"));
            app.Navigator.GoToGroupsPage();
            app.Groups.InitGroupCreation();
            app.Groups.FillGroupForms(new GroupData("aaa"));
            app.Groups.SubmitGroupCreation();
            app.Navigator.ReturnToGroupPage();
            app.Logout.Logout();
        }                  
    }
}
