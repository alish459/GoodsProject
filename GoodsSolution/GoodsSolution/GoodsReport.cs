using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsSolution
{
    public class GoodsReport : PersianUI.Controls.UserControl
    {
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlFooter;
        private PersianUI.Controls.GroupBox groupBox1;
        private PersianUI.Controls.GroupBox groupBox3;
        private PersianUI.Controls.DataGridView dataGridView1;
        private PersianUI.Controls.TextBoxes.TextBox txtsearch;
        private PersianUI.Controls.Label label1;
        private PersianUI.Controls.DateControl toDate;
        private PersianUI.Controls.Label label5;
        private PersianUI.Controls.DateControl fromDate;
        private System.Windows.Forms.Panel panel1;
        private PersianUI.Controls.Buttons.DisplayButton displayButton;
        private PersianUI.Controls.Buttons.CancelButton cancelButton;
        private System.Windows.Forms.Panel panel2;
        private PersianUI.Controls.Label lblResult;
        private PersianUI.Controls.Buttons.PrintButton printButton2;
        private PersianUI.Controls.Buttons.PrintButton printButton1;
        private System.Windows.Forms.Panel pnlMain;
        private List<Connection.GoodsReportService> Result = new List<Connection.GoodsReportService>();
        public GoodsReport()
        {
            InitializeComponent();
            txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            dataGridView1.DataSource = new List<Connection.GoodsReportService>();
            SetGrid();
        }
        private void SetGrid()
        {
            foreach (System.Windows.Forms.DataGridViewColumn item in dataGridView1.Columns)
            {
                item.Visible = false;
            }
            dataGridView1.Columns["GoodsName"].Visible = true;
            dataGridView1.Columns["ActDate"].Visible = true;
            dataGridView1.Columns["ArzName"].Visible = true;
            dataGridView1.Columns["BuyPrice"].Visible = true;
            dataGridView1.Columns["OtherPrices"].Visible = true;
            dataGridView1.Columns["ArzPrice"].Visible = true;
            dataGridView1.Columns["KolPrice"].Visible = true;
            dataGridView1.Columns["GoodsName"].HeaderText = "نام كالا";
            dataGridView1.Columns["ActDate"].HeaderText = "تاريخ";
            dataGridView1.Columns["ArzPrice"].HeaderText = "نرخ ارز";
            dataGridView1.Columns["ArzName"].HeaderText = "ارز";
            dataGridView1.Columns["KolPrice"].HeaderText = "مبلغ كل";
            dataGridView1.Columns["BuyPrice"].HeaderText = "قيمت خريد";
            dataGridView1.Columns["OtherPrices"].HeaderText = "ساير هزينه ها";
            dataGridView1.Columns["GoodsName"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["ActDate"].Width = 80;
            dataGridView1.Columns["ArzName"].Width = 200;
            dataGridView1.Columns["BuyPrice"].Width = 110;
            dataGridView1.Columns["ArzPrice"].Width = 110;
            dataGridView1.Columns["OtherPrices"].Width = 110;
            dataGridView1.Columns["KolPrice"].Width = 110;
            dataGridView1.Columns["BuyPrice"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["OtherPrices"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["ArzPrice"].DefaultCellStyle.Format = "#,0.##";
            dataGridView1.Columns["KolPrice"].DefaultCellStyle.Format = "#,0.##";
            foreach (var item in typeof(Connection.Model.AllGoods).GetProperties())
            {
                dataGridView1.Columns["GoodsName"].DisplayIndex = 0;
                dataGridView1.Columns["ActDate"].DisplayIndex = 1;
                dataGridView1.Columns["ArzName"].DisplayIndex = 2;
                dataGridView1.Columns["ArzPrice"].DisplayIndex = 3;
                dataGridView1.Columns["BuyPrice"].DisplayIndex = 4;
                dataGridView1.Columns["OtherPrices"].DisplayIndex = 5;
                dataGridView1.Columns["KolPrice"].DisplayIndex = 6;
            }
            dataGridView1.AutoGenerateColumns = false;
        }
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.groupBox1 = new PersianUI.Controls.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayButton = new PersianUI.Controls.Buttons.DisplayButton();
            this.cancelButton = new PersianUI.Controls.Buttons.CancelButton();
            this.label1 = new PersianUI.Controls.Label();
            this.toDate = new PersianUI.Controls.DateControl();
            this.label5 = new PersianUI.Controls.Label();
            this.fromDate = new PersianUI.Controls.DateControl();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblResult = new PersianUI.Controls.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printButton2 = new PersianUI.Controls.Buttons.PrintButton();
            this.printButton1 = new PersianUI.Controls.Buttons.PrintButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.groupBox3 = new PersianUI.Controls.GroupBox();
            this.dataGridView1 = new PersianUI.Controls.DataGridView();
            this.txtsearch = new PersianUI.Controls.TextBoxes.TextBox();
            this.pnlTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.groupBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 70);
            this.pnlTop.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.toDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.fromDate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "برآورد هزينه";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.displayButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Location = new System.Drawing.Point(195, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 37);
            this.panel1.TabIndex = 2;
            // 
            // displayButton
            // 
            this.displayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.displayButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.displayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayButton.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.displayButton.ForeColor = System.Drawing.Color.White;
            this.displayButton.Location = new System.Drawing.Point(103, 2);
            this.displayButton.Margin = new System.Windows.Forms.Padding(10);
            this.displayButton.Name = "displayButton";
            this.displayButton.NextControl = null;
            this.displayButton.Size = new System.Drawing.Size(81, 34);
            this.displayButton.TabIndex = 0;
            this.displayButton.Text = "نمايش";
            this.displayButton.UseVisualStyleBackColor = false;
            this.displayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.cancelButton.ForeColor = System.Drawing.Color.Gray;
            this.cancelButton.Location = new System.Drawing.Point(14, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.NextControl = null;
            this.cancelButton.Size = new System.Drawing.Size(81, 34);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.label1.Location = new System.Drawing.Point(542, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "تا تاريخ :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toDate
            // 
            this.toDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toDate.CanGoBackward = true;
            this.toDate.CanGoForward = false;
            this.toDate.Location = new System.Drawing.Point(408, 40);
            this.toDate.Name = "toDate";
            this.toDate.NextControl = null;
            this.toDate.NowShamsi10Cahracter = "1397/12/27";
            this.toDate.NowShamsi8Character = "1397/12/27";
            this.toDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toDate.Size = new System.Drawing.Size(120, 20);
            this.toDate.TabIndex = 1;
            this.toDate.Text = "dateControl1";
            this.toDate.Value10Cahracter = null;
            this.toDate.Value8Character = null;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.label5.Location = new System.Drawing.Point(729, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "از تاريخ :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fromDate
            // 
            this.fromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromDate.CanGoBackward = true;
            this.fromDate.CanGoForward = false;
            this.fromDate.Location = new System.Drawing.Point(604, 40);
            this.fromDate.Name = "fromDate";
            this.fromDate.NextControl = null;
            this.fromDate.NowShamsi10Cahracter = "1397/12/27";
            this.fromDate.NowShamsi8Character = "1397/12/27";
            this.fromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fromDate.Size = new System.Drawing.Size(120, 20);
            this.fromDate.TabIndex = 0;
            this.fromDate.Text = "dateControl1";
            this.fromDate.Value10Cahracter = null;
            this.fromDate.Value8Character = null;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblResult);
            this.pnlFooter.Controls.Add(this.panel2);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 456);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(800, 44);
            this.pnlFooter.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblResult.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.lblResult.Location = new System.Drawing.Point(732, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(68, 22);
            this.lblResult.TabIndex = 11;
            this.lblResult.Text = "توضيحات :";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.printButton2);
            this.panel2.Controls.Add(this.printButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 44);
            this.panel2.TabIndex = 10;
            // 
            // printButton2
            // 
            this.printButton2.BackColor = System.Drawing.Color.Chocolate;
            this.printButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.printButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton2.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.printButton2.ForeColor = System.Drawing.Color.White;
            this.printButton2.Location = new System.Drawing.Point(10, 4);
            this.printButton2.Margin = new System.Windows.Forms.Padding(10);
            this.printButton2.Name = "printButton2";
            this.printButton2.NextControl = null;
            this.printButton2.Size = new System.Drawing.Size(97, 34);
            this.printButton2.TabIndex = 12;
            this.printButton2.Text = "ارسال به اكسل";
            this.printButton2.UseVisualStyleBackColor = false;
            // 
            // printButton1
            // 
            this.printButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.printButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.printButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.printButton1.ForeColor = System.Drawing.Color.White;
            this.printButton1.Location = new System.Drawing.Point(112, 4);
            this.printButton1.Margin = new System.Windows.Forms.Padding(10);
            this.printButton1.Name = "printButton1";
            this.printButton1.NextControl = null;
            this.printButton1.Size = new System.Drawing.Size(81, 34);
            this.printButton1.TabIndex = 11;
            this.printButton1.Text = "چاپ";
            this.printButton1.UseVisualStyleBackColor = false;
            this.printButton1.Click += new System.EventHandler(this.PrintButton1_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox3);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 70);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 386);
            this.pnlMain.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.txtsearch);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 386);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ليست اقلام";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.dataGridView1.Location = new System.Drawing.Point(3, 54);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(794, 329);
            this.dataGridView1.TabIndex = 5;
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.White;
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtsearch.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.txtsearch.ForeColor = System.Drawing.Color.Black;
            this.txtsearch.Location = new System.Drawing.Point(3, 25);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(10);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.NextControl = null;
            this.txtsearch.Size = new System.Drawing.Size(794, 29);
            this.txtsearch.TabIndex = 4;
            this.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GoodsReport
            // 
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlTop);
            this.Name = "GoodsReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(800, 500);
            this.pnlTop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainForm.pnlMain.Controls.Clear();
        }
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            Result = Connection.CrudService.GoodsCrud.ReturnGoodsForReport(fromDate.GetDateFullChar(), toDate.GetDateFullChar());
            int IDHere = 1;
            Result.ForEach(a => a.RowID = IDHere++);
            Result.ForEach(a => a.KolPrice = (a.ArzPrice * a.BuyPrice) + (a.OtherPrices));
            dataGridView1.DataSource = Result;
            lblResult.Text = $"تعداد : {Result.Count.ToString("#,0")}    جمع هزينه‌ها : {Result.Sum(a => a.OtherPrices).ToString("#,0")}    جمع مبالغ كل : {Result.Sum(a => a.KolPrice).ToString("#,0")}";
        }

        private void PrintButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
