using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection.CrudService
{
    public class GoodsCrud
    {
        public static List<Connection.Model.AllGoods> ReturnAllGoods()
        {
            using (var context = new Connection.Model.GoodsDBEntities())
            {
                return context.AllGoods.AsNoTracking().ToList();
            }
        }
        public static bool Create(Connection.Model.AllGoods AllGoodsInstance)
        {
            using (var context = new Connection.Model.GoodsDBEntities())
            {
                try
                {
                    context.AllGoods.Add(AllGoodsInstance);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.ToString());
                    return false;
                }
            }
        }
        public static bool Update(Connection.Model.AllGoods ObjectName)
        {
            using (var context = new Connection.Model.GoodsDBEntities())
            {
                try
                {
                    var Ins = context.AllGoods.Where(a => a.GoodsID == ObjectName.GoodsID).FirstOrDefault();
                    Ins.ActDate = ObjectName.ActDate;
                    Ins.ArzID = ObjectName.ArzID;
                    Ins.BuyPrice = ObjectName.BuyPrice;
                    Ins.GoodsName = ObjectName.GoodsName;
                    Ins.OtherPrices = ObjectName.OtherPrices;
                    Ins.ArzPrice = ObjectName.ArzPrice;
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.ToString());
                    return false;
                }
            }
        }
        public static List<GoodsReportService> ReturnGoodsForReport(string v1, string v2)
        {
            using (var context = new Connection.Model.GoodsDBEntities())
            {
                return (from read in context.AllGoods.AsNoTracking().Where(a => a.ActDate.CompareTo(v1) >= 0 && a.ActDate.CompareTo(v2) <= 0).ToList()
                        select new GoodsReportService
                        {
                            ActDate = read.ActDate,
                            ArzPrice = read.ArzPrice,
                            BuyPrice = read.BuyPrice,
                            KolPrice = 0,
                            GoodsName = read.GoodsName,
                            OtherPrices = read.OtherPrices,
                            RowID = 0,
                            ArzName = read.ArzName,
                        }).ToList();
            }
        }
        public static bool Delete(int ID)
        {
            using (var context = new Connection.Model.GoodsDBEntities())
            {
                try
                {
                    context.AllGoods.Remove(context.AllGoods.Find(ID));
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.ToString());
                    return false;
                }
            }
        }
    }
}
