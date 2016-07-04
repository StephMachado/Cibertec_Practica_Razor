using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    [Table("Person.Person")]
    public partial class Person
    {
        public Person()
        {
            BusinessEntityContact = new HashSet<BusinessEntityContact>();
            EmailAddress = new HashSet<EmailAddress>();
            PersonPhone = new HashSet<PersonPhone>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Business Entity ID")]
        public int BusinessEntityID { get; set; }

        [Required]
        [StringLength(2)]
        [Display(Name = "Person Type")]
        public string PersonType { get; set; }

        [Display(Name = "Name Style")]
        public bool NameStyle { get; set; }

        [Display(Name = "Title")]
        [StringLength(8)]
        public string Title { get; set; }

        [Display(Name = "FirstName")]
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Display(Name = "MiddleName")]
        [StringLength(50)]
        public string MiddleName { get; set; }

        [Display(Name = "LastName")]
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Display(Name = "Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [Display(Name = "Suffix")]
        [StringLength(10)]
        public string Suffix { get; set; }

        [Display(Name = "Email Promotion")]
        public int EmailPromotion { get; set; }

        [Display(Name = "Additional Contact Info")]
        [Column(TypeName = "xml")]
        public string AdditionalContactInfo { get; set; }

        [Display(Name = "Demographics")]
        [Column(TypeName = "xml")]
        public string Demographics { get; set; }
        
        [Display(Name = "Row Guid")]
        public Guid rowguid { get; set; }

        [Display(Name = "Business Entity")]
        public virtual BusinessEntity BusinessEntity { get; set; }

        [Display(Name = "Business Entity Contact")]
        public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; }

        [Display(Name = "Email Address")]
        public virtual ICollection<EmailAddress> EmailAddress { get; set; }

        [Display(Name = "Password")]
        public virtual Password Password { get; set; }

        [Display(Name = "Person Phone")]
        public virtual ICollection<PersonPhone> PersonPhone { get; set; }
    }
}
