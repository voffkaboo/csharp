﻿using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        
        [Test]
        public void GroupRemovalTest()
        {
            app.Groups.RemoveGroup(1);        
        }                    
    }
}