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
            using (var context = new Connection.Model.GoodsDBEntities())
            {
                return context.Arz.AsNoTracking().ToList();
            }
        }
        public static bool Create(Connection.Model.Arz ArzInstance)
        {
            using (var context = new Connection.Model.GoodsDBEntities())
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
    }
}
