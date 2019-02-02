using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppWithRepositoryAutofac.Core
{
    [Table("State")]
    public class State : BaseEntity
    {
        public Guid StateId { get; set; }

        public Guid CountryId { get; set; }

        [Required]
        [StringLength(50)]
        public string StateName { get; set; }

        [StringLength(5)]
        public string StateCode { get; set; }

        public virtual ICollection<City> Cities { get; set; }

        public virtual Country Country { get; set; }
    }
}
