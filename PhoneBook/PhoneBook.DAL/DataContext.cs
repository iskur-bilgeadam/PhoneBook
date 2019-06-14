namespace PhoneBook.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<PhoneType> PhoneTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<PhoneType>()
            //    .HasMany(e => e.Phones)
            //    .WithRequired(e => e.PhoneType)
            //    .HasForeignKey(e => e.TypeID)
            //    .WillCascadeOnDelete(false);
        }
    }
}
