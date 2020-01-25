using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactModificationTests : TestBase
    {

        [Test]
        public void ContactModificationTest()
        {
            ContactData modifyData = new ContactData("Edik","Petrovich","Pupkinovich");
            modifyData.Fax = "11111111111";
            modifyData.Homepage = "ustalNoEbowu@mail.com";
            modifyData.AnniversaryDay = "3";
            modifyData.AnniversaryMonth = "February";                      
            modifyData.AnniversaryYear = "2018";
            
            app.Contact.Modify(1, modifyData);
        }
    }
}