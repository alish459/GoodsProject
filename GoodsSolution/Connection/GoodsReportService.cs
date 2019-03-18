using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class GoodsReportService
    {
        public int RowID { get; set; }
        public string ActDate { get; set; }
        public decimal ArzPrice { get; set; }
        public string ArzName { get; set; }
        public string GoodsName { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal OtherPrices { get; set; }
        public decimal KolPrice { get; set; }
    }
}
