using NUnit.Framework;

namespace WebAddressBookTests
{
    public class TestBase
    {
        protected AppManager app;
        [SetUp]
        public void SetUp()
        {
            app = new AppManager();
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
        }

        [TearDown]
        protected void TearDown()
        {
            app.Stop();
        }
    }
}
