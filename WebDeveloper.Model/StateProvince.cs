using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    [Table("Person.StateProvince")]
    public partial class StateProvince
    {
        public StateProvince()
        {
            Address = new HashSet<Address>();
        }

        [Column(Order = 0)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "State Province ID")]
        public int StateProvinceID { get; set; }

        [Column(Order = 1)]
        [Required(ErrorMessage = "The Country Region Code is required")]
        [StringLength(3)]
        [Display(Name = "Country Region Code")]
        public string CountryRegionCode { get; set; }

        [Display(Name = "Country Region")]
        public virtual CountryRegion CountryRegion { get; set; }

        [Column(Order = 2)]
        [Required(ErrorMessage = "The State Province Cod is required")]
        [StringLength(3)]
        [Display(Name = "State Province Code")]
        public string StateProvinceCode { get; set; }

        [Column(Order = 3)]
        [Required(ErrorMessage = "The Name is required")]
        [StringLength(50)]
        [Display(Name = "Name - State Province")]
        public string Name { get; set; }

        [Display(Name = "Is Only State Province Flag")]
        public bool IsOnlyStateProvinceFlag { get; set; }

        [Display(Name = "Territory ID")]
        public int TerritoryID { get; set; }

        [Display(Name = "Row Guid")]
        public Guid rowguid { get; set; }

        [Display(Name = "Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [Display(Name = "Address")]
        public virtual ICollection<Address> Address { get; set; }
    }
}
