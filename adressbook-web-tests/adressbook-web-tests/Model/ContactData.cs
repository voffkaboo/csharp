namespace WebAddressBookTests
{
    public class ContactData
    {

        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FirstName { get; set; }
        public string NickName { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneMobile { get; set; }
        public string PhoneWork { get; set; }
        public string Fax { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string Homepage { get; set; }
        public string SecondAddress { get; set; }
        public string PhoneHome2 { get; set; } 
        public string Notes { get; set; }
        public string BirthDay { get; set; }
        public string BirthMonth { get; set; }
        public string BirthYear { get; set; }
        public string AnniversaryDay { get; set; }
        public string AnniversaryMonth { get; set; }
        public string AnniversaryYear { get; set; }
        public ContactData(string firstname, string lastname, string middlename)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.MiddleName = middlename;
        }
    }
}
