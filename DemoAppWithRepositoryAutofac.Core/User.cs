using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppWithRepositoryAutofac.Core
{
    public class User : BaseEntity
    {
        public Guid UserId { get; set; }

        [Required]
        [StringLength(10)]
        public string usertype { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(10)]
        public string Salutation { get; set; }

        [StringLength(40)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        [StringLength(6)]
        public string Sex { get; set; }

        [StringLength(100)]
        public string SocialSecurityNnumber { get; set; }

        public Guid? BloodGroupId { get; set; }

        [StringLength(150)]
        public string AddressLine1 { get; set; }

        [StringLength(150)]
        public string AddressLine2 { get; set; }

        public Guid? CityId { get; set; }

        [StringLength(50)]
        public string EmailId { get; set; }

        [StringLength(15)]
        public string MobileNumber { get; set; }

        [StringLength(15)]
        public string HomePhoneNumber { get; set; }

        [StringLength(15)]
        public string WorkPhoneNumber1 { get; set; }

        [StringLength(15)]
        public string WorkPhoneNumber2 { get; set; }
        public virtual City City { get; set; }
    }
}
