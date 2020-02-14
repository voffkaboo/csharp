using System.IO;
using NUnit.Framework;
using Bogus;

namespace WebAddressBookTests
{
    public class ContactFixtureBuilder
    {
        private readonly ContactData contactModel;

        public ContactFixtureBuilder()
        {
            this.contactModel = CreateDefaultModel();
        }

        public static ContactFixtureBuilder CreateNew()
        {
            return new ContactFixtureBuilder();
        }

        public ContactFixtureBuilder WithFirstName(string firstName)
        {
            this.contactModel.FirstName = firstName;
            return this;
        }

        public ContactFixtureBuilder WithMiddleName(string middleName)
        {
            this.contactModel.MiddleName = middleName;
            return this;
        }

        public ContactFixtureBuilder WithLastName(string lastName)
        {
            this.contactModel.LastName = lastName;
            return this;
        }

        public ContactFixtureBuilder WithNickName(string nickname)
        {
            this.contactModel.NickName = nickname;
            return this;
        }

        public ContactFixtureBuilder WithPhotoName(string photoName)
        {
            var path = Path.Combine(TestContext.CurrentContext.TestDirectory, @"IMAGE\", photoName);

            this.contactModel.PathToPhoto = path;
            return this;

        }

        public ContactFixtureBuilder WithTitle(string title)
        {
            this.contactModel.Title = title;
            return this;
        }

        public ContactFixtureBuilder WithCompany(string company)
        {
            this.contactModel.Company = company;
            return this;
        }

        public ContactFixtureBuilder WithAddress(string address)
        {
            this.contactModel.Address = address;
            return this;
        }

        public ContactFixtureBuilder WithPhoneHome(string phoneHome)
        {
            this.contactModel.PhoneHome = phoneHome;
            return this;
        }

        public ContactFixtureBuilder WithPhoneMobile(string phoneMobile)
        {
            this.contactModel.PhoneMobile = phoneMobile;
            return this;
        }
        public ContactFixtureBuilder WithPhoneWork(string phoneWork)
        {
            this.contactModel.PhoneWork = phoneWork;
            return this;
        }

        public ContactFixtureBuilder WithFax(string Fax)
        {
            this.contactModel.Fax = Fax;
            return this;
        }

        public ContactFixtureBuilder WithEmail1(string email1)
        {
            this.contactModel.Email1 = email1;
            return this;
        }

        public ContactFixtureBuilder WithEmail2(string email2)
        {
            this.contactModel.Email2 = email2;
            return this;
        }

        public ContactFixtureBuilder WithEmail3(string email3)
        {
            this.contactModel.Email3 = email3;
            return this;
        }

        public ContactFixtureBuilder WithHomepage(string homepage)
        {
            this.contactModel.Homepage = homepage;
            return this;
        }

        public ContactFixtureBuilder WithBirthDay(string birthDay)
        {
            this.contactModel.BirthDay = birthDay;
            return this;
        }

        public ContactFixtureBuilder WithBirthMonth(string birthMonth)
        {
            this.contactModel.BirthMonth = birthMonth;
            return this;
        }

        public ContactFixtureBuilder WithBirthYear(string birthYear)
        {
            this.contactModel.BirthYear = birthYear;
            return this;
        }

        public ContactFixtureBuilder WithAnniversaryDay(string anniversaryDay)
        {
            this.contactModel.AnniversaryDay = anniversaryDay;
            return this;
        }

        public ContactFixtureBuilder WithAnniversaryMonth(string anniversaryMonth)
        {
            this.contactModel.AnniversaryMonth = anniversaryMonth;
            return this;
        }

        public ContactFixtureBuilder WithAnniversaryYear(string anniversaryYear)
        {
            this.contactModel.AnniversaryYear = anniversaryYear;
            return this;
        }

        public ContactFixtureBuilder WithSecondAddress(string SecondAddress)
        {
            this.contactModel.SecondAddress = SecondAddress;
            return this;
        }

        public ContactFixtureBuilder WithPhoneHome2(string PhoneHome2)
        {
            this.contactModel.PhoneHome2 = PhoneHome2;
            return this;
        }

        public ContactFixtureBuilder WithNotes(string Notes)
        {
            this.contactModel.Notes = Notes;
            return this;
        }

        public ContactData Build()
        {
            return this.contactModel;
        }

        private ContactData CreateDefaultModel()
        {                   
            string pathToFile = Path.Combine(TestContext.CurrentContext.TestDirectory, @"IMAGE\", "img.jpg");

            ContactData model = new Faker<ContactData>()
                .RuleFor(o => o.FirstName, f => f.Person.FirstName)
                .RuleFor(o => o.MiddleName, f => f.Person.LastName)
                .RuleFor(o => o.LastName, f => f.Person.LastName)
                .RuleFor(o => o.NickName, f => f.Person.UserName)
                .RuleFor(o => o.PathToPhoto, f => pathToFile)
                .RuleFor(o => o.Title, f => f.Name.JobTitle())
                .RuleFor(o => o.Company, f => f.Company.CompanyName())
                .RuleFor(o => o.Address, f => f.Address.StreetAddress())
                .RuleFor(o => o.PhoneHome, f => f.Phone.PhoneNumber("+(###)#######"))
                .RuleFor(o => o.PhoneMobile, f => f.Phone.PhoneNumber("+(###)#######"))
                .RuleFor(o => o.PhoneWork, f => f.Phone.PhoneNumber("+(###)#######"))
                .RuleFor(o => o.Fax, f => f.Phone.PhoneNumber("+(###)#######"))
                .RuleFor(o => o.Email1, f => f.Internet.Email())
                .RuleFor(o => o.Email2, f => f.Internet.Email())
                .RuleFor(o => o.Email3, f => f.Internet.Email())
                .RuleFor(o => o.Homepage, f => f.Internet.Url())
                .RuleFor(o => o.BirthDay, f => f.Random.Int(0, 28).ToString())
                .RuleFor(o => o.BirthMonth, f => f.Date.Month())
                .RuleFor(o => o.BirthYear, f => f.Date.Past().Year.ToString())
                .RuleFor(o => o.AnniversaryDay, f => f.Random.Int(0, 28).ToString())
                .RuleFor(o => o.AnniversaryMonth, f => f.Date.Month())
                .RuleFor(o => o.AnniversaryYear, f => f.Date.Past().Year.ToString())                
                .RuleFor(o => o.SecondAddress, f => f.Address.StreetAddress())
                .RuleFor(o => o.PhoneHome2, f => f.Phone.PhoneNumber("+(###)#######"))
                .RuleFor(o => o.Notes, f => f.Lorem.Sentence())
                .Generate();

            return model;
        }
    }
}