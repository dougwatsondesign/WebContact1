using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebContact1.Models
{
    public class ContactModel
    {
        public int ID { get; set; }
        public Guid ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AltPhone { get; set; }
        public DateTime Birthday { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }


    }
}