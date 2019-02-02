using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppWithRepositoryAutofac.Core
{
    [Table("Country")]
    public class Country : BaseEntity
    {
        public Guid CountryId { get; set; }

        [Required]
        [StringLength(50)]
        public string CountryName { get; set; }

        [StringLength(5)]
        public string CountryCode { get; set; }

        [StringLength(7)]
        public string CountryPhoneCode { get; set; }

        public virtual ICollection<State> States { get; set; }
    }
}
