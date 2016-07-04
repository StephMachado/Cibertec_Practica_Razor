using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    [Table("Person.AddressType")]
    public partial class AddressType
    {
        public AddressType()
        {
            BusinessEntityAddress = new HashSet<BusinessEntityAddress>();
        }

        [Display(Name = "Address Type ID")]
        public int AddressTypeID { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "The Name is required")]
        [StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "Row Guid")]
        public Guid rowguid { get; set; }

        [Display(Name = "Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [Display(Name = "Business Entity Address")]
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddress { get; set; }
    }
}
