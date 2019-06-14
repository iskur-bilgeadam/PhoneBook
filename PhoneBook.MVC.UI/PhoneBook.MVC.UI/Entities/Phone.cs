using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneBook.MVC.UI.Entities
{
    public class Phone
    {
        public int ID { get; set; }
        public string PhoneNumber { get; set; }
        public int TypeID { get; set; }
        public int PersonID { get; set; }
        public PhoneType PhoneType { get; set; }
        public List<PhoneType> PhoneTypes { get; set; }
    }
}