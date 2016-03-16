using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FAST.Models
{
    public class Contact
    {

        public int ID { get; set; }

        [Display(Name="First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Position { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        [DataType(DataType.PostalCode)]
        public string ZIP { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string CellPhone { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string HomePhone { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string WorkPhone { get; set; }
    }
}