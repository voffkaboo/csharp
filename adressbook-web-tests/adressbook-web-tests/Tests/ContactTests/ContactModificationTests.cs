using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {

        [Test]
        public void ContactModificationTest()
        {
            ContactData modifyData = new ContactData();
            modifyData.Fax = "11111111111";
            modifyData.Homepage = "ustalNoEbowu@mail.com";
            modifyData.AnniversaryDay = "3";
            modifyData.AnniversaryMonth = "February";                      
            modifyData.AnniversaryYear = "2018";
            modifyData.BirthMonth = "July";
            modifyData.BirthYear = "1991";
            modifyData.BirthDay = "9";

            app.Contact.Modify(1, modifyData);
        }
        [Test]
        public void ContactModificationTestV2()
        {
            int contactIndex = 1;
            var contactModel = new ContactFixtureBuilder().Build();
            app.Contact.Modify(contactIndex, contactModel);
        }
    }
}