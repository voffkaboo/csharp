using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressBookTests
{
    class UserData
    {

        public string LastName { get; set; } = "";
        public string MiddleName { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string NickName { get; set; } = "";
        public string Title { get; set; } = "";
        public string Company { get; set; } = "";
        public string Address { get; set; } = "";
        public string Home { get; set; } = "";
        public string Mobile { get; set; } = "";
        public string Work { get; set; } = "";
        public string Address2 { get; set; } = "";
        public UserData(string firstname, string lastname, string middlename)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.MiddleName = middlename;
        }

    }
}
