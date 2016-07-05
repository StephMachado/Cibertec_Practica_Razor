using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    [Table("Person.BusinessEntity")]
    public partial class BusinessEntity
    {       
        public BusinessEntity()
        {
            BusinessEntityAddress = new HashSet<BusinessEntityAddress>();
            BusinessEntityContact = new HashSet<BusinessEntityContact>();
        }

        [Column(Order = 0)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BusinessEntityID { get; set; }

        [Column(Order = 1)]
        public Guid rowguid { get; set; }

        [Column(Order = 2)]
        public DateTime ModifiedDate { get; set; }
        
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddress { get; set; }
       
        public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; }

        public int PersonID { get; set; }

        public virtual Person Person { get; set; }
    }
}
