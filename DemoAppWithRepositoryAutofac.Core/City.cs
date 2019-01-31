using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppWithRepositoryAutofac.Core
{
    public class City
    {
        public Guid CityId { get; set; }

        public Guid StateId { get; set; }

        [Required]
        [StringLength(50)]
        public string CityName { get; set; }

        [StringLength(5)]
        public string CityCode { get; set; }

        [StringLength(7)]
        public string CityPhoneCode { get; set; }

        public virtual State State { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
