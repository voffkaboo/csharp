using NUnit.Framework;

namespace WebAddressBookTests
{
    [SetUpFixture]
    public class TestSuiteFixture
    {
        public static AppManager app;

        [OneTimeSetUp]
        public void InitAppManager()
        {
            app = new AppManager();
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
        }
        [OneTimeTearDown]
        public void StopAppManager()
        {
            app.Stop();
        }
    }
}
