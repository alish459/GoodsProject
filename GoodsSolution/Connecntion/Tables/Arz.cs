using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecntion.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Arz")]
    public partial class Arz
    {
        public int ArzID { get; set; }

        [Required]
        [StringLength(500)]
        public string ArzName { get; set; }

        public decimal ArzPrice { get; set; }
    }
}
