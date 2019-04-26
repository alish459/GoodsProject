using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodsSolution
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            pnlMain = new System.Windows.Forms.Panel();
            InitializeComponent();
            pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Location = new System.Drawing.Point(0, 25);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(1184, 470);
            pnlMain.TabIndex = 2;
            this.Controls.Add(pnlMain);

        }
        private void ArzDefineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArzDefinition arzDefinition = new ArzDefinition
            {
                Dock = DockStyle.Fill
            };
            arzDefinition.txtArz.Focus();
            pnlMain.Controls.Add(arzDefinition);
        }

        private void GoodsDefineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsDefinition arzDefinition = new GoodsDefinition
            {
                Dock = DockStyle.Fill
            };
            pnlMain.Controls.Add(arzDefinition);
        }
        private void ArzReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsReport arzDefinition = new GoodsReport
            {
                Dock = DockStyle.Fill
            };
            pnlMain.Controls.Add(arzDefinition);
        }
        private void TTExcell_Click(object sender, EventArgs e)
        {
            try
            {
                if (PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "آيا از انجام اين كار مطمئن هستيد؟\n تمام داده هاي شما پاك خواهند شد و داده هاي جديد جايگزين خواهند شد\n در صورت انتخاب بلي منتظر بمانيد تا داده هاي شما پاك شود", "w") == DialogResult.Yes)
                {
                    if (Connection.CrudService.GoodsCrud.Delete() && Connection.CrudService.ArzCrud.Delete())
                    {
                        PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "اطلاعات ديتابيس با موفقيت پاك شدند");
                        OpenFileDialog ofImport = new OpenFileDialog();
                        ofImport.Title = "Select file";
                        ofImport.InitialDirectory = @"c:\";
                        ofImport.FileName = "";
                        ofImport.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
                        ofImport.FilterIndex = 1;
                        ofImport.RestoreDirectory = true;

                        if (ofImport.ShowDialog() == DialogResult.OK)
                        {
                            DataGridView dataGridView1 = new DataGridView();
                            String name = "Sheet1";
                            String constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                                            ofImport.FileName +
                                            ";Extended Properties='Excel 8.0;HDR=YES;';";

                            OleDbConnection con = new OleDbConnection(constr);
                            OleDbCommand oconn = new OleDbCommand("Select * From [" + name + "$]", con);
                            con.Open();
                            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                            System.Data.DataTable data = new System.Data.DataTable();
                            sda.Fill(data);
                            List<DataRow> list = data.AsEnumerable().ToList();
                            dataGridView1.DataSource = list;
                            Dictionary<string, decimal> AllArz = new Dictionary<string, decimal>();
                            List<Connection.Model.AllGoods> ResultGoods = new List<Connection.Model.AllGoods>();
                            foreach (var item in list)
                            {
                                if (!AllArz.Any(a => a.Key == item.ItemArray[3].ToString()))
                                {
                                    AllArz.Add(item.ItemArray[3].ToString(), decimal.Parse(item.ItemArray[2].ToString()));
                                }
                                Connection.Model.AllGoods Res = new Connection.Model.AllGoods()
                                {
                                    ArzID = 0,
                                    ArzPrice = 0,
                                    ActDate = item.ItemArray[1].ToString(),
                                    ArzName = item.ItemArray[3].ToString(),
                                    BuyPrice = decimal.Parse(item.ItemArray[5].ToString()),
                                    GoodsName = item.ItemArray[4].ToString(),
                                    OtherPrices = decimal.Parse(item.ItemArray[6].ToString()),
                                };
                                ResultGoods.Add(Res);
                            }
                            foreach (var item in AllArz)
                            {
                                Connection.CrudService.ArzCrud.Create(new Connection.Model.Arz() { ArzName = item.Key, Price = item.Value });
                            }
                            var ArzRes = Connection.CrudService.ArzCrud.ReturnArz();
                            foreach (var item in ResultGoods)
                            {
                                Connection.CrudService.GoodsCrud.Create(new Connection.Model.AllGoods() { ActDate = item.ActDate, ArzID = ArzRes.FirstOrDefault(a => a.ArzName == item.ArzName).ArzID, ArzName = item.ArzName, ArzPrice = ArzRes.FirstOrDefault(a => a.ArzName == item.ArzName).Price, BuyPrice = item.BuyPrice, GoodsName = item.GoodsName, OtherPrices = item.OtherPrices });
                            }
                            PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "اطلاعات با موفقيت جايگذاري شدند");
                        }
                    }
                    else
                    {
                        PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "حذف اطلاعات با خطا مواجه شد", "e");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
