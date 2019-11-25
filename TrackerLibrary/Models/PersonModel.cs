using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{

    public class PersonModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string CellPhoneNumber { get; set; }

        public PersonModel()
        {

        }

        public PersonModel(string FirstNameValue, string LastNameValue, string EmailAddressValue, string CellPhoneNumberValue)
        {
            FirstName = FirstNameValue;
            LastName = LastNameValue;
            EmailAddress = EmailAddressValue;
            CellPhoneNumber = CellPhoneNumberValue;
        }
    }
}
