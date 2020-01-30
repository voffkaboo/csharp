using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {
        
        [Test]
        public void GroupCreationTest()
        {
            GroupData data = new GroupData("aaa");
                        
            app.Groups.Create(data);
            app.Navigator.ReturnToGroupPage();
            app.Auth.Logout();
        }                  
    }
}
