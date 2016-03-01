using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FAST.Models
{
    public class ContactDBContext : DbContext
    {

    
        public ContactDBContext() : base("name=ContactDBContext")
        {
        }

        public System.Data.Entity.DbSet<FAST.Models.Contact> Contacts { get; set; }

        public System.Data.Entity.DbSet<FAST.Models.Group> Groups { get; set; }
    }
}
