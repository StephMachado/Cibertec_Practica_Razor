using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    [Table("Person.CountryRegion")]
    public partial class CountryRegion
    {
        public CountryRegion()
        {
            StateProvince = new HashSet<StateProvince>();
        }

        [Key]
        [StringLength(3)]
        [Display(Name = "Country Region Code")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string CountryRegionCode { get; set; }

        [Required(ErrorMessage = "The Name is required")]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [Display(Name = "State Province")]
        public virtual ICollection<StateProvince> StateProvince { get; set; }
    }
}
