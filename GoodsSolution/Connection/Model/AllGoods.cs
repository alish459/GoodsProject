namespace Connection.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AllGoods
    {
        [Key]
        public int GoodsID { get; set; }

        [Required]
        [StringLength(500)]
        public string GoodsName { get; set; }

        [Required]
        [StringLength(10)]
        public string ActDate { get; set; }

        public int ArzID { get; set; }

        public decimal BuyPrice { get; set; }

        public decimal OtherPrices { get; set; }

        [Required]
        [StringLength(500)]
        public string ArzName { get; set; }

        public decimal ArzPrice { get; set; }
    }
}
