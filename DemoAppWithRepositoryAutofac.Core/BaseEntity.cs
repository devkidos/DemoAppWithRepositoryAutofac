using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppWithRepositoryAutofac.Core
{
    public abstract class BaseEntity
    {
        [Required]
        [StringLength(10)]
        public string Status { get; set; } = "Active";
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public Guid UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
        public string IP { get; set; }
    }
}
