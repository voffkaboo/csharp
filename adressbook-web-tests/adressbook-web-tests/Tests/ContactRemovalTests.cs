﻿using NUnit.Framework;

namespace WebAddressBookTests 
{
    [TestFixture]
    public class ContactRemovalTests : TestBase
    {
        
        [Test]
        public void ContactRemovalTest()
        {
         app.Contact.SelectContact(1)
                    .RemoveContact()
                    .AcceptRemovalViaPopUp();
        }       
    }
}