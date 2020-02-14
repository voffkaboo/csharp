using NUnit.Framework;

namespace WebAddressBookTests
{
    [Parallelizable(ParallelScope.Fixtures)]
    public class LoginTests : TestBase
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            AccountData accountData = new AccountData("admin", "secret");
            app.Auth.Logout();
            app.Auth.Login(accountData);
            Assert.IsTrue(app.Auth.IsLoggedIn(accountData));
        }
        public void LoginWithInvalidCredentials()
        {
            AccountData accountData = new AccountData("admin", "dfdf");
            app.Auth.Logout();
            app.Auth.Login(accountData);
            Assert.IsFalse(app.Auth.IsLoggedIn(accountData));
        }
    }
}
