using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    [Table("Person.Address")]
    public partial class Address
    {
        public Address()
        {
            //BusinessEntityAddress = new HashSet<BusinessEntityAddress>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Address ID")]
        public int AddressID { get; set; }

        [Display(Name = "Address Line 1")]
        [Required(ErrorMessage = "The Address Line 1 is required")]
        [StringLength(60)]
        public string AddressLine1 { get; set; }

        [Display(Name = "Address Line 2")]
        [StringLength(60)]
        public string AddressLine2 { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "The City is required")]
        [StringLength(30)]
        public string City { get; set; }

        [Display(Name = "State Province ID")]
        public int StateProvinceID { get; set; }

        [Display(Name = "Postal Code")]
        [Required(ErrorMessage = "The Postal Code is required")]
        [StringLength(15)]
        public string PostalCode { get; set; }

        [Display(Name = "Row Guid")]
        public Guid rowguid { get; set; }

        [Display(Name = "Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [Display(Name = "State Province")]
        public virtual StateProvince StateProvince { get; set; }

        //[Display(Name = "Business Entity Address")]
        //public virtual ICollection<BusinessEntityAddress> BusinessEntityAddress { get; set; }
    }
}
