using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    [Table("Person.ContactType")]
    public partial class ContactType
    {
        public ContactType()
        {
            BusinessEntityContact = new HashSet<BusinessEntityContact>();
        }

        [Display(Name = "Contact Type ID")]
        public int ContactTypeID { get; set; }

        [Required(ErrorMessage = "The Name is required")]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [Display(Name = "Business Entity Contact")]
        public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; }
    }
}
