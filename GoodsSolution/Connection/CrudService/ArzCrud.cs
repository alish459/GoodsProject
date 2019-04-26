using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection.CrudService
{
    public class ArzCrud
    {
        public static List<Connection.Model.Arz> ReturnArz()
        {
            using (var context = new Connection.Model.PersianModel())
            {
                //var x = context.Customers.ToList();
                return context.Arz.AsNoTracking().ToList();
            }
        }
        public static bool Create(Connection.Model.Arz ArzInstance)
        {
            using (var context = new Connection.Model.PersianModel())
            {
                try
                {
                    context.Arz.Add(ArzInstance);
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
        public static bool Update(Connection.Model.Arz ObjectName)
        {
            using (var context = new Connection.Model.PersianModel())
            {
                try
                {
                    var Ins = context.Arz.Where(a => a.ArzID == ObjectName.ArzID).FirstOrDefault();
                    Ins.ArzName = ObjectName.ArzName;
                    Ins.Price = ObjectName.Price;
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
        public static bool Delete(int ID)
        {
            using (var context = new Connection.Model.PersianModel())
            {
                try
                {
                    context.Arz.Remove(context.Arz.Find(ID));
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
        public static bool Delete()
        {
            using (var context = new Connection.Model.PersianModel())
            {
                try
                {
                    context.Arz.RemoveRange(context.Arz.ToList());
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
