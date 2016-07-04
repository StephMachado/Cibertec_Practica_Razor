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

        [Column(Order = 0)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Address ID")]
        public int AddressID { get; set; }

        [Column(Order = 1)]
        [Display(Name = "Address Line 1")]
        [Required(ErrorMessage = "The Address Line 1 is required")]
        [StringLength(60)]
        public string AddressLine1 { get; set; }

        [Column(Order = 2)]
        [Display(Name = "Address Line 2")]
        [StringLength(60)]
        public string AddressLine2 { get; set; }

        [Column(Order = 3)]
        [Display(Name = "City")]
        [Required(ErrorMessage = "The City is required")]
        [StringLength(30)]
        public string City { get; set; }

        [Column(Order = 4)]
        [Display(Name = "State Province ID")]
        public int StateProvinceID { get; set; }

        [Column(Order = 5)]
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
