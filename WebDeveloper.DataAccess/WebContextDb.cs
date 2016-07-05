using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class WebContextDb : DbContext
    {
        public WebContextDb() : base()
        {
            Database.SetInitializer(new WebDeveloperInitializer());
        }

        public DbSet<CountryRegion> CountryRegions { get; set; }

        public DbSet<StateProvince> StateProvinces { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<ContactType> ContactTypes { get; set; }

        //public DbSet<AddressType> AddressTypes { get; set; }

        //public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove();
        }
    }
}
