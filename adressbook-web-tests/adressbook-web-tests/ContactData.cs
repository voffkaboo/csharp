namespace WebAddressBookTests
{
    class ContactData
    {

        public string LastName { get; set; } = "DefaultLastName";
        public string MiddleName { get; set; } = "DefaultMiddleName";
        public string FirstName { get; set; } = "DefaultFirstName";
        public string NickName { get; set; } = "DefaultNickName";
        public string Title { get; set; } = "DefaultTitle";
        public string Company { get; set; } = "DefaultCompany";
        public string Address { get; set; } = "Default";
        public string PhoneHome { get; set; } = "000000000";
        public string PhoneMobile { get; set; } = "11111111111";
        public string PhoneWork { get; set; } = "222222222";
        public string Fax { get; set; } = "3333333333";
        public string Email1 { get; set; } = "Default1@i.ua";
        public string Email2 { get; set; } = "Default2@i.ua";
        public string Email3 { get; set; } = "Default3@i.ua";
        public string Homepage { get; set; } = "Default.com.ua";
        public string Bday { get; set; } = "";
        public string SecondAddress { get; set; } = "DefaultSecondAddress";
        public string PhoneHome2 { get; set; } = "7777777777777";
        public string Notes { get; set; } = "";
        public string BirthDay { get; set; } = "3";
        public string BirthMonth { get; set; } = "February";
        public string BirthYear { get; set; } = "2000";
        public string AnniversaryDay { get; set; } = "9";
        public string AnniversaryMonth { get; set; } = "February";
        public string AnniversaryYear { get; set; } = "2019";
        public ContactData(string firstname, string lastname, string middlename)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.MiddleName = middlename;
        }
    }
}
