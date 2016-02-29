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
        public string FirstName;

        [Display(Name = "Last Name")]
        public string LastName;


    }
}