namespace PhoneBook.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Phone
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string PhoneNumber { get; set; }

        public int TypeID { get; set; }

        public int? PersonID { get; set; }

        //public virtual Person Person { get; set; }

        //public virtual PhoneType PhoneType { get; set; }
    }
}
