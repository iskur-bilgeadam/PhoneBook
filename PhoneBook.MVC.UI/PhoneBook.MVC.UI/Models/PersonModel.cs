using PhoneBook.MVC.UI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneBook.MVC.UI.Models
{
    public class PersonModel
    {
        public Person Person { get; set; }
        public Phone Phone { get; set; }
        public List<Phone> Phones { get; set; }


    }
}