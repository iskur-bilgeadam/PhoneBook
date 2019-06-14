using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneBook.MVC.UI.Entities
{
    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string TCKN { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}