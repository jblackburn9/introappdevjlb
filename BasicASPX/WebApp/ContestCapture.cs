using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public class ContestCapture
    {
        public string FirstName;
        public string LastName;
        public string AddressLine1;
        public string AddressLine2;
        public string City;
        public string Province;
        public string PostCode;
        public string Email;

        public ContestCapture()
        {

        }

        public ContestCapture(string firstname, string lastname, string addressline1, string addressline2, string city, string province, string postcode, string email)
        {
            FirstName = firstname;
            LastName = lastname;
            AddressLine1 = addressline1;
            AddressLine2 = addressline2;
            City = city;
            Province = province;
            PostCode = postcode;
            Email = email;
        }
    }
}