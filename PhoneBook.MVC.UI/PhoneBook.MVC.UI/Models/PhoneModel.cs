using PhoneBook.MVC.UI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneBook.MVC.UI.Models
{
    public class PhoneModel
    {
        public PhoneType PhoneType { get; set; }
        public Phone Phone { get; set; }
        public Person Person { get; set; }
    }
}