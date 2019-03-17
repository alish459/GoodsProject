using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecntion.Tables
{
    public class AllGoods
    {
        public AllGoods()
        {

        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GoodsID { get; set; }
        [StringLength(200)]
        public string GoodsName { get; set; }
        public string GoodsDefineDate { get; set; }
        public int ArzID { get; set; }
        public decimal BuyPrice { get; set; }
        [ForeignKey("ArzID")]
        public Arz Arzes { get; set; }
    }
}
