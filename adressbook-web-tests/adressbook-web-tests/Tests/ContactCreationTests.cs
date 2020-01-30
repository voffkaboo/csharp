using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
        
        [Test]
        public void ContactCreationTest()
        {
            app.Contact.InitiateContactCreation();
            ContactData user = new ContactData("FirstNameTest", "SecondNameTest","MiddleNameTest");
            user.NickName = "CreatedNickname";
            user.Title = "CreatedTitle";
            user.Company = "CreatedCompany";
            user.Address = "CreatedAddress";
            user.PhoneHome = "CreatedPhoneHome";
            user.PhoneMobile = "CreatedPhoneMobile";
            user.PhoneWork = "CreatedPhoneWork";
            user.Fax = "+311111111111";
            user.Email1 = "CreatedEmail1@gmail.com";
            user.Email2 = "CreatedEmail2@gmail.com";
            user.Email3 = "CreatedEmai3@gmail.com";
            user.Homepage = "www.voffka.com";
            user.SecondAddress = "Borshagovka district, 3";
            user.PhoneHome2 = "+13555555555555";
            user.Notes = "bla bla bla";
            user.BirthDay = "3";
            user.BirthMonth = "July";
            user.BirthYear = "1990";
            user.AnniversaryDay = "3";
            user.AnniversaryMonth = "February";
            user.AnniversaryYear = "2018";
            app.Contact.FillContactForms(user);
            app.Auth.Logout();
        }                        
    }
}