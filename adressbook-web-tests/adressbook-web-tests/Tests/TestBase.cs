﻿using NUnit.Framework;

namespace WebAddressBookTests
{
    public class TestBase
    {
        protected AppManager app;
        [SetUp]
        public void SetUp()
        {
            app = new AppManager();                       
        }

        [TearDown]
        protected void TearDown()
        {
            app.Stop();
        }
    }
}
