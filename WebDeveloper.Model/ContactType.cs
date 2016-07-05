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
            //BusinessEntityContact = new HashSet<BusinessEntityContact>();
        }

        [Column(Order = 0)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Contact Type ID")]
        public int ContactTypeID { get; set; }

        [Column(Order = 1)]
        [Required(ErrorMessage = "The Name is required")]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Column(Order = 2)]
        [Display(Name = "Modified Date")]
        public DateTime ModifiedDate { get; set; }

        //[Display(Name = "Business Entity Contact")]
        //public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; }
    }
}
