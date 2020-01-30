using NUnit.Framework;

namespace WebAddressBookTests
{
    public class TestBase
    {
        protected AppManager app;

        [SetUp]
        public void SetUpAppManager()
        {
            app = AppManager.GetInstance();
        }
    }
}
