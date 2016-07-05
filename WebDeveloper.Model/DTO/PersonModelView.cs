using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloper.Model.DTO
{
    public class PersonModelView
    {
        [Display(Name = "ID")]
        public int BusinessEntityID { get; set; }

        [Display(Name = "First Name")]
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        [StringLength(50)]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        public string IamgePath { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
