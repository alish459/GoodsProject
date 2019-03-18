using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsSolution
{
    public class GoodsDefinition : PersianUI.Controls.UserControl
    {
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlFooter;
        private PersianUI.Controls.GroupBox groupBox3;
        private PersianUI.Controls.DataGridView dataGridView1;
        private PersianUI.Controls.TextBoxes.TextBox txtsearch;
        private PersianUI.Controls.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private PersianUI.Controls.Buttons.CancelButton cancelButton;
        private PersianUI.Controls.Buttons.SaveButton saveButton;
        private PersianUI.Controls.NumericTextBoxWithSeperator txtBuyPrice;
        private PersianUI.Controls.Label label2;
        public PersianUI.Controls.TextBoxes.TextBox txtNaka;
        private PersianUI.Controls.Label label1;
        private PersianUI.Controls.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private PersianUI.Controls.Buttons.DeleteButton deleteButton;
        private PersianUI.Controls.Buttons.CancelButton cancelButtonEdit;
        private PersianUI.Controls.Buttons.SaveButton saveButtonEdit;
        private PersianUI.Controls.Label label5;
        private PersianUI.Controls.DateControl dateControl;
        private PersianUI.Controls.NumericTextBoxWithSeperator txtArzPrice;
        private PersianUI.Controls.Label label7;
        private PersianUI.Controls.Label label6;
        private PersianUI.Controls.ComboBoxes.ComboBox cmbArz;
        private PersianUI.Controls.NumericTextBoxWithSeperator txtArzPriceEdit;
        private PersianUI.Controls.Label label9;
        private PersianUI.Controls.Label label10;
        private PersianUI.Controls.ComboBoxes.ComboBox cmbArzEdit;
        private PersianUI.Controls.Label label3;
        private PersianUI.Controls.DateControl dateControlEdit;
        private PersianUI.Controls.NumericTextBoxWithSeperator txtBuyPriceEdit;
        private PersianUI.Controls.Label label4;
        public PersianUI.Controls.TextBoxes.TextBox txtNakaEdit;
        private PersianUI.Controls.Label label8;
        private PersianUI.Controls.NumericTextBoxWithSeperator txtOtherPrice;
        private PersianUI.Controls.Label label11;
        private PersianUI.Controls.NumericTextBoxWithSeperator txtOtherPriceEdit;
        private PersianUI.Controls.Label label12;
        private System.Windows.Forms.Panel pnlMain;
        private List<Connection.Model.AllGoods> Result = new List<Connection.Model.AllGoods>();
        private List<Connection.Model.Arz> ResultArz = new List<Connection.Model.Arz>();
        private List<Connection.Model.Arz> ResultArzEdit = new List<Connection.Model.Arz>();
        private Connection.Model.AllGoods ResultEdit = new Connection.Model.AllGoods();
        public GoodsDefinition()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            txtNaka.Text = txtArzPrice.Text = txtBuyPrice.Text = txtOtherPrice.Text = string.Empty;
            pnlFooter.Visible = false;
            Result = Connection.CrudService.GoodsCrud.ReturnAllGoods();
            dataGridView1.DataSource = Result;
            txtNaka.Focus();
            SetGrid();
            ResultArz = Connection.CrudService.ArzCrud.ReturnArz();
            ResultArzEdit = Connection.CrudService.ArzCrud.ReturnArz();
            cmbArz.DataSource = ResultArz;
            cmbArz.ValueMember = "ArzID";
            cmbArz.DisplayMember = "ArzName";
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
            dataGridView1.Columns["GoodsName"].HeaderText = "نام كالا";
            dataGridView1.Columns["ActDate"].HeaderText = "تاريخ";
            dataGridView1.Columns["ArzPrice"].HeaderText = "نرخ ارز";
            dataGridView1.Columns["ArzName"].HeaderText = "ارز";
            dataGridView1.Columns["BuyPrice"].HeaderText = "قيمت خريد";
            dataGridView1.Columns["OtherPrices"].HeaderText = "ساير هزينه ها";
            dataGridView1.Columns["GoodsName"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["ActDate"].Width = 80;
            dataGridView1.Columns["ArzName"].Width = 200;
            dataGridView1.Columns["BuyPrice"].Width = 110;
            dataGridView1.Columns["ArzPrice"].Width = 110;
            dataGridView1.Columns["OtherPrices"].Width = 110;
            dataGridView1.Columns["BuyPrice"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["OtherPrices"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["ArzPrice"].DefaultCellStyle.Format = "N0";
            foreach (var item in typeof(Connection.Model.AllGoods).GetProperties())
            {
                dataGridView1.Columns["GoodsName"].DisplayIndex = 0;
                dataGridView1.Columns["ActDate"].DisplayIndex = 1;
                dataGridView1.Columns["ArzName"].DisplayIndex = 2;
                dataGridView1.Columns["ArzPrice"].DisplayIndex = 3;
                dataGridView1.Columns["BuyPrice"].DisplayIndex = 4;
                dataGridView1.Columns["OtherPrices"].DisplayIndex = 5;
            }
            dataGridView1.AutoGenerateColumns = false;
        }
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.groupBox1 = new PersianUI.Controls.GroupBox();
            this.txtOtherPrice = new PersianUI.Controls.NumericTextBoxWithSeperator();
            this.saveButton = new PersianUI.Controls.Buttons.SaveButton();
            this.label11 = new PersianUI.Controls.Label();
            this.txtArzPrice = new PersianUI.Controls.NumericTextBoxWithSeperator();
            this.label7 = new PersianUI.Controls.Label();
            this.label6 = new PersianUI.Controls.Label();
            this.cmbArz = new PersianUI.Controls.ComboBoxes.ComboBox();
            this.label5 = new PersianUI.Controls.Label();
            this.dateControl = new PersianUI.Controls.DateControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelButton = new PersianUI.Controls.Buttons.CancelButton();
            this.txtBuyPrice = new PersianUI.Controls.NumericTextBoxWithSeperator();
            this.label2 = new PersianUI.Controls.Label();
            this.txtNaka = new PersianUI.Controls.TextBoxes.TextBox();
            this.label1 = new PersianUI.Controls.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.groupBox2 = new PersianUI.Controls.GroupBox();
            this.txtOtherPriceEdit = new PersianUI.Controls.NumericTextBoxWithSeperator();
            this.label12 = new PersianUI.Controls.Label();
            this.txtArzPriceEdit = new PersianUI.Controls.NumericTextBoxWithSeperator();
            this.label9 = new PersianUI.Controls.Label();
            this.label10 = new PersianUI.Controls.Label();
            this.cmbArzEdit = new PersianUI.Controls.ComboBoxes.ComboBox();
            this.label3 = new PersianUI.Controls.Label();
            this.dateControlEdit = new PersianUI.Controls.DateControl();
            this.txtBuyPriceEdit = new PersianUI.Controls.NumericTextBoxWithSeperator();
            this.label4 = new PersianUI.Controls.Label();
            this.txtNakaEdit = new PersianUI.Controls.TextBoxes.TextBox();
            this.label8 = new PersianUI.Controls.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteButton = new PersianUI.Controls.Buttons.DeleteButton();
            this.cancelButtonEdit = new PersianUI.Controls.Buttons.CancelButton();
            this.saveButtonEdit = new PersianUI.Controls.Buttons.SaveButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.groupBox3 = new PersianUI.Controls.GroupBox();
            this.dataGridView1 = new PersianUI.Controls.DataGridView();
            this.txtsearch = new PersianUI.Controls.TextBoxes.TextBox();
            this.pnlTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.pnlTop.Size = new System.Drawing.Size(800, 131);
            this.pnlTop.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOtherPrice);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtArzPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbArz);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateControl);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtBuyPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNaka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 131);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تعريف كالا";
            // 
            // txtOtherPrice
            // 
            this.txtOtherPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtherPrice.BackColor = System.Drawing.Color.White;
            this.txtOtherPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtherPrice.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.txtOtherPrice.ForeColor = System.Drawing.Color.Black;
            this.txtOtherPrice.Location = new System.Drawing.Point(529, 97);
            this.txtOtherPrice.Margin = new System.Windows.Forms.Padding(10);
            this.txtOtherPrice.Name = "txtOtherPrice";
            this.txtOtherPrice.NextControl = this.saveButton;
            this.txtOtherPrice.Size = new System.Drawing.Size(200, 29);
            this.txtOtherPrice.TabIndex = 5;
            this.txtOtherPrice.Text = "0";
            this.txtOtherPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOtherPrice.Value = 0D;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(106, 3);
            this.saveButton.Margin = new System.Windows.Forms.Padding(10);
            this.saveButton.Name = "saveButton";
            this.saveButton.NextControl = null;
            this.saveButton.Size = new System.Drawing.Size(81, 34);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "ثبت";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.label11.Location = new System.Drawing.Point(736, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 22);
            this.label11.TabIndex = 10;
            this.label11.Text = "‎هزينه ها :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtArzPrice
            // 
            this.txtArzPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArzPrice.BackColor = System.Drawing.Color.White;
            this.txtArzPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArzPrice.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.txtArzPrice.ForeColor = System.Drawing.Color.Black;
            this.txtArzPrice.Location = new System.Drawing.Point(269, 61);
            this.txtArzPrice.Margin = new System.Windows.Forms.Padding(10);
            this.txtArzPrice.Name = "txtArzPrice";
            this.txtArzPrice.NextControl = this.saveButton;
            this.txtArzPrice.Size = new System.Drawing.Size(172, 29);
            this.txtArzPrice.TabIndex = 4;
            this.txtArzPrice.Text = "0";
            this.txtArzPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtArzPrice.Value = 0D;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.label7.Location = new System.Drawing.Point(454, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "نرخ ارز :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.label6.Location = new System.Drawing.Point(739, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "نوع ارز :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbArz
            // 
            this.cmbArz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbArz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbArz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbArz.FormattingEnabled = true;
            this.cmbArz.Location = new System.Drawing.Point(529, 62);
            this.cmbArz.Margin = new System.Windows.Forms.Padding(10);
            this.cmbArz.Name = "cmbArz";
            this.cmbArz.NextControl = null;
            this.cmbArz.Size = new System.Drawing.Size(200, 30);
            this.cmbArz.TabIndex = 3;
            this.cmbArz.Leave += new System.EventHandler(this.CmbArz_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.label5.Location = new System.Drawing.Point(189, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "تاريخ :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateControl
            // 
            this.dateControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateControl.CanGoBackward = true;
            this.dateControl.CanGoForward = false;
            this.dateControl.Location = new System.Drawing.Point(55, 28);
            this.dateControl.Name = "dateControl";
            this.dateControl.NextControl = null;
            this.dateControl.NowShamsi10Cahracter = "1397/12/27";
            this.dateControl.NowShamsi8Character = "1397/12/27";
            this.dateControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateControl.Size = new System.Drawing.Size(120, 20);
            this.dateControl.TabIndex = 2;
            this.dateControl.Text = "dateControl1";
            this.dateControl.Value10Cahracter = null;
            this.dateControl.Value8Character = null;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Location = new System.Drawing.Point(7, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 37);
            this.panel1.TabIndex = 6;
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
            // txtBuyPrice
            // 
            this.txtBuyPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuyPrice.BackColor = System.Drawing.Color.White;
            this.txtBuyPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuyPrice.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.txtBuyPrice.ForeColor = System.Drawing.Color.Black;
            this.txtBuyPrice.Location = new System.Drawing.Point(269, 26);
            this.txtBuyPrice.Margin = new System.Windows.Forms.Padding(10);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.NextControl = this.saveButton;
            this.txtBuyPrice.Size = new System.Drawing.Size(172, 29);
            this.txtBuyPrice.TabIndex = 1;
            this.txtBuyPrice.Text = "0";
            this.txtBuyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuyPrice.Value = 0D;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.label2.Location = new System.Drawing.Point(454, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "قيمت خريد";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNaka
            // 
            this.txtNaka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNaka.BackColor = System.Drawing.Color.White;
            this.txtNaka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNaka.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.txtNaka.ForeColor = System.Drawing.Color.Black;
            this.txtNaka.Location = new System.Drawing.Point(529, 26);
            this.txtNaka.Margin = new System.Windows.Forms.Padding(10);
            this.txtNaka.Name = "txtNaka";
            this.txtNaka.NextControl = this.txtBuyPrice;
            this.txtNaka.Size = new System.Drawing.Size(200, 29);
            this.txtNaka.TabIndex = 0;
            this.txtNaka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.label1.Location = new System.Drawing.Point(742, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام كالا :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.groupBox2);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 365);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(800, 135);
            this.pnlFooter.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOtherPriceEdit);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtArzPriceEdit);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbArzEdit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateControlEdit);
            this.groupBox2.Controls.Add(this.txtBuyPriceEdit);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNakaEdit);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 135);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ويرايش كالاي تعريف شده";
            // 
            // txtOtherPriceEdit
            // 
            this.txtOtherPriceEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtherPriceEdit.BackColor = System.Drawing.Color.White;
            this.txtOtherPriceEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtherPriceEdit.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.txtOtherPriceEdit.ForeColor = System.Drawing.Color.Black;
            this.txtOtherPriceEdit.Location = new System.Drawing.Point(529, 98);
            this.txtOtherPriceEdit.Margin = new System.Windows.Forms.Padding(10);
            this.txtOtherPriceEdit.Name = "txtOtherPriceEdit";
            this.txtOtherPriceEdit.NextControl = this.saveButton;
            this.txtOtherPriceEdit.Size = new System.Drawing.Size(200, 29);
            this.txtOtherPriceEdit.TabIndex = 5;
            this.txtOtherPriceEdit.Text = "0";
            this.txtOtherPriceEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOtherPriceEdit.Value = 0D;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.label12.Location = new System.Drawing.Point(736, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 22);
            this.label12.TabIndex = 16;
            this.label12.Text = "‎هزينه ها :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtArzPriceEdit
            // 
            this.txtArzPriceEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArzPriceEdit.BackColor = System.Drawing.Color.White;
            this.txtArzPriceEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArzPriceEdit.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.txtArzPriceEdit.ForeColor = System.Drawing.Color.Black;
            this.txtArzPriceEdit.Location = new System.Drawing.Point(269, 60);
            this.txtArzPriceEdit.Margin = new System.Windows.Forms.Padding(10);
            this.txtArzPriceEdit.Name = "txtArzPriceEdit";
            this.txtArzPriceEdit.NextControl = this.saveButton;
            this.txtArzPriceEdit.Size = new System.Drawing.Size(172, 29);
            this.txtArzPriceEdit.TabIndex = 4;
            this.txtArzPriceEdit.Text = "0";
            this.txtArzPriceEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtArzPriceEdit.Value = 0D;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.label9.Location = new System.Drawing.Point(454, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "نرخ ارز :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.label10.Location = new System.Drawing.Point(739, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 22);
            this.label10.TabIndex = 12;
            this.label10.Text = "نوع ارز :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbArzEdit
            // 
            this.cmbArzEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbArzEdit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbArzEdit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbArzEdit.FormattingEnabled = true;
            this.cmbArzEdit.Location = new System.Drawing.Point(529, 61);
            this.cmbArzEdit.Margin = new System.Windows.Forms.Padding(10);
            this.cmbArzEdit.Name = "cmbArzEdit";
            this.cmbArzEdit.NextControl = null;
            this.cmbArzEdit.Size = new System.Drawing.Size(200, 30);
            this.cmbArzEdit.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.label3.Location = new System.Drawing.Point(187, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "تاريخ :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateControlEdit
            // 
            this.dateControlEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateControlEdit.CanGoBackward = true;
            this.dateControlEdit.CanGoForward = false;
            this.dateControlEdit.Location = new System.Drawing.Point(53, 23);
            this.dateControlEdit.Name = "dateControlEdit";
            this.dateControlEdit.NextControl = null;
            this.dateControlEdit.NowShamsi10Cahracter = "1397/12/27";
            this.dateControlEdit.NowShamsi8Character = "1397/12/27";
            this.dateControlEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateControlEdit.Size = new System.Drawing.Size(120, 20);
            this.dateControlEdit.TabIndex = 2;
            this.dateControlEdit.Text = "dateControl2";
            this.dateControlEdit.Value10Cahracter = null;
            this.dateControlEdit.Value8Character = null;
            // 
            // txtBuyPriceEdit
            // 
            this.txtBuyPriceEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuyPriceEdit.BackColor = System.Drawing.Color.White;
            this.txtBuyPriceEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuyPriceEdit.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.txtBuyPriceEdit.ForeColor = System.Drawing.Color.Black;
            this.txtBuyPriceEdit.Location = new System.Drawing.Point(267, 21);
            this.txtBuyPriceEdit.Margin = new System.Windows.Forms.Padding(10);
            this.txtBuyPriceEdit.Name = "txtBuyPriceEdit";
            this.txtBuyPriceEdit.NextControl = this.saveButton;
            this.txtBuyPriceEdit.Size = new System.Drawing.Size(172, 29);
            this.txtBuyPriceEdit.TabIndex = 1;
            this.txtBuyPriceEdit.Text = "0";
            this.txtBuyPriceEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuyPriceEdit.Value = 0D;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.label4.Location = new System.Drawing.Point(452, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "قيمت خريد";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNakaEdit
            // 
            this.txtNakaEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNakaEdit.BackColor = System.Drawing.Color.White;
            this.txtNakaEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNakaEdit.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.txtNakaEdit.ForeColor = System.Drawing.Color.Black;
            this.txtNakaEdit.Location = new System.Drawing.Point(527, 21);
            this.txtNakaEdit.Margin = new System.Windows.Forms.Padding(10);
            this.txtNakaEdit.Name = "txtNakaEdit";
            this.txtNakaEdit.NextControl = this.txtBuyPriceEdit;
            this.txtNakaEdit.Size = new System.Drawing.Size(200, 29);
            this.txtNakaEdit.TabIndex = 0;
            this.txtNakaEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.label8.Location = new System.Drawing.Point(740, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "نام كالا :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.cancelButtonEdit);
            this.panel2.Controls.Add(this.saveButtonEdit);
            this.panel2.Location = new System.Drawing.Point(5, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 40);
            this.panel2.TabIndex = 6;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(89, 2);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(10);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.NextControl = null;
            this.deleteButton.Size = new System.Drawing.Size(81, 34);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "حذف";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // cancelButtonEdit
            // 
            this.cancelButtonEdit.BackColor = System.Drawing.Color.White;
            this.cancelButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButtonEdit.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.cancelButtonEdit.ForeColor = System.Drawing.Color.Gray;
            this.cancelButtonEdit.Location = new System.Drawing.Point(4, 2);
            this.cancelButtonEdit.Name = "cancelButtonEdit";
            this.cancelButtonEdit.NextControl = null;
            this.cancelButtonEdit.Size = new System.Drawing.Size(81, 34);
            this.cancelButtonEdit.TabIndex = 2;
            this.cancelButtonEdit.Text = "انصراف";
            this.cancelButtonEdit.UseVisualStyleBackColor = false;
            this.cancelButtonEdit.Click += new System.EventHandler(this.CancelButtonEdit_Click);
            // 
            // saveButtonEdit
            // 
            this.saveButtonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.saveButtonEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.saveButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButtonEdit.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.saveButtonEdit.ForeColor = System.Drawing.Color.White;
            this.saveButtonEdit.Location = new System.Drawing.Point(175, 3);
            this.saveButtonEdit.Margin = new System.Windows.Forms.Padding(10);
            this.saveButtonEdit.Name = "saveButtonEdit";
            this.saveButtonEdit.NextControl = null;
            this.saveButtonEdit.Size = new System.Drawing.Size(81, 34);
            this.saveButtonEdit.TabIndex = 0;
            this.saveButtonEdit.Text = "ثبت";
            this.saveButtonEdit.UseVisualStyleBackColor = false;
            this.saveButtonEdit.Click += new System.EventHandler(this.SaveButtonEdit_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox3);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 131);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 234);
            this.pnlMain.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.txtsearch);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 234);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "كالاهاي تعريف شده";
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
            this.dataGridView1.Size = new System.Drawing.Size(794, 177);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
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
            this.txtsearch.TextChanged += new System.EventHandler(this.Txtsearch_TextChanged);
            this.txtsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtsearch_KeyDown);
            // 
            // GoodsDefinition
            // 
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlTop);
            this.Name = "GoodsDefinition";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(800, 500);
            this.pnlTop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (txtNaka.Text.Trim() == string.Empty)
            {
                PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "نام كالا نميتواند خالي باشد", "e");
                txtNaka.Focus();
                return;
            }
            if (cmbArz.SelectedValue == null)
            {
                PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "هيچ ارزي انتخاب نشده است", "e");
                cmbArz.Focus();
                return;
            }
            if (Connection.CrudService.GoodsCrud.Create(new Connection.Model.AllGoods() { ActDate = dateControl.GetDateFullChar(), OtherPrices = decimal.Parse(txtOtherPrice.Text), ArzName = cmbArz.Text, ArzID = int.Parse(cmbArz.SelectedValue.ToString()), BuyPrice = decimal.Parse(txtBuyPrice.Text), GoodsName = txtNaka.Text,ArzPrice=decimal.Parse(txtArzPrice.Text) }))
            {
                PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "ثبت با موفقيت انجام شد");
                LoadData();
            }
            else
            {
                PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "ثبت با خطا مواجه شد", "e");
            }
        }
        private void SetActiveRow(PersianUI.Controls.DataGridView DG, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                string ColName = "GoodsName";
                int selected = 0;
                if (DG.RowCount > 0)
                {
                    if (DG.CurrentRow == null)
                    {
                        DG.CurrentCell = DG.Rows[0].Cells[ColName];
                    }
                    else
                    {
                        selected = DG.CurrentRow.Index;
                    }
                }

                if (txtsearch.Text.StartsWith(" "))
                {
                    txtsearch.Text = "";
                }
                if (e.KeyCode == System.Windows.Forms.Keys.Down && DG.RowCount > 0)
                {
                    if (selected < DG.Rows.Count - 1)
                        DG.CurrentCell = DG.Rows[selected + 1].Cells[ColName];
                    else
                        DG.CurrentCell = DG.Rows[0].Cells[ColName];
                    System.Windows.Forms.SendKeys.Send("{END}");
                }
                else if (e.KeyCode == System.Windows.Forms.Keys.Up && DG.RowCount > 0)
                {
                    if (selected > 0)
                        DG.CurrentCell = DG.Rows[selected - 1].Cells[ColName];
                    else
                        DG.CurrentCell = DG.Rows[DG.Rows.Count - 1].Cells[ColName];
                    System.Windows.Forms.SendKeys.Send("{END}");
                }
                else if (e.KeyCode == System.Windows.Forms.Keys.PageDown)
                {
                    DG.Focus();
                    txtsearch.Focus();
                    if (DG.RowCount > 0)
                    {
                        int CountRows = DG.RowCount;
                        int CurrentPosition = DG.CurrentRow.Index;
                        int NextPosition = CurrentPosition + 10;
                        int RemainTolast = (CountRows - 1) - CurrentPosition;
                        if (CurrentPosition < CountRows - 1)
                        {
                            if (NextPosition < CountRows - 1)
                            {
                                DG.Rows[DG.CurrentRow.Index].Selected = false;
                                DG.Rows[DG.CurrentRow.Index + 10].Selected = true;
                                DG.CurrentCell = DG.Rows[DG.CurrentRow.Index + 10].Cells[ColName];
                            }
                            else
                            {
                                DG.Rows[DG.CurrentRow.Index].Selected = false;
                                DG.Rows[DG.CurrentRow.Index + RemainTolast].Selected = true;
                                DG.CurrentCell = DG.Rows[DG.CurrentRow.Index + RemainTolast].Cells[ColName];
                            }

                        }
                    }
                    System.Windows.Forms.SendKeys.Send("{END}");
                }
                else if (e.KeyCode == System.Windows.Forms.Keys.PageUp)
                {
                    DG.Focus();
                    txtsearch.Focus();
                    if (DG.RowCount > 0)
                    {
                        int CountRows = DG.RowCount;
                        int CurrentPosition = DG.CurrentRow.Index;
                        int NextPosition = CurrentPosition - 10;
                        int RemainToFirst = CurrentPosition;
                        if (CurrentPosition > 0)
                        {
                            if (RemainToFirst > 10)
                            {
                                DG.Rows[DG.CurrentRow.Index].Selected = false;
                                DG.Rows[DG.CurrentRow.Index - 10].Selected = true;
                                DG.CurrentCell = DG.Rows[DG.CurrentRow.Index - 10].Cells[ColName];
                            }
                            else
                            {
                                DG.Rows[DG.CurrentRow.Index].Selected = false;
                                DG.Rows[DG.CurrentRow.Index - RemainToFirst].Selected = true;
                                DG.CurrentCell = DG.Rows[DG.CurrentRow.Index - RemainToFirst].Cells[ColName];
                            }

                        }
                    }
                    System.Windows.Forms.SendKeys.Send("{END}");
                }
                else if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                {
                    OpenAct();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }
        private void Txtsearch_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            SetActiveRow(dataGridView1, e);
        }
        private void Txtsearch_TextChanged(object sender, EventArgs e)
        {
            var ResStr = txtsearch.Text.Trim();
            dataGridView1.DataSource = ResStr == string.Empty ? Result : Result.Where(a => a.ActDate.Contains(ResStr) || a.ArzName.Contains(ResStr) || a.BuyPrice.ToString().Contains(ResStr) || a.GoodsName.Contains(ResStr) || a.OtherPrices.ToString().Contains(ResStr)).ToList();
        }
        private void CmbArz_Leave(object sender, EventArgs e)
        {
            if (cmbArz.SelectedValue != null)
            {
                var ArzID = int.Parse(cmbArz.SelectedValue.ToString());
                txtArzPrice.Text = ResultArz.FirstOrDefault(a=>a.ArzID==ArzID).Price.ToString("#,0");
            }
        }
        private void DataGridView1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                e.SuppressKeyPress = true;
                OpenAct();
            }
        }
        private void DataGridView1_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            OpenAct();
        }
        private void OpenAct()
        {
            if (dataGridView1.RowCount > 0)
            {
                if (dataGridView1.CurrentRow == null) dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells["GoodsName"];
                ResultEdit = (Connection.Model.AllGoods)dataGridView1.CurrentRow.DataBoundItem;
                cmbArzEdit.DataSource = ResultArzEdit;
                cmbArzEdit.ValueMember = "ArzID";
                cmbArzEdit.DisplayMember = "ArzName";
                txtNakaEdit.Text = ResultEdit.GoodsName;
                txtArzPriceEdit.Text = ResultEdit.ArzPrice.ToString("#,0");
                txtBuyPriceEdit.Text = ResultEdit.BuyPrice.ToString("#,0");
                txtOtherPriceEdit.Text = ResultEdit.OtherPrices.ToString("#,0");
                cmbArzEdit.SelectedIndex = ResultArzEdit.FindIndex(a => a.ArzID == ResultEdit.ArzID);
                PersianUI.Controls.DateControl.SetDateControl10Char(ref dateControlEdit, ResultEdit.ActDate);
                pnlFooter.Visible = true;
                txtNakaEdit.Focus();
            }
        }
        private void CancelButtonEdit_Click(object sender, EventArgs e)
        {
            pnlFooter.Visible = false;
            txtsearch.Focus();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "آيا از حذف اطمينان داريد؟", "w") == System.Windows.Forms.DialogResult.Yes)
            {
                if (Connection.CrudService.GoodsCrud.Delete(ResultEdit.GoodsID))
                {
                    PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "حذف با موفقيت انجام شد");
                    LoadData();
                }
                else
                {
                    PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "حذف با خطا مواجه شد", "e");
                }
            }
        }
        private void SaveButtonEdit_Click(object sender, EventArgs e)
        {
            if (txtNakaEdit.Text.Trim() == string.Empty)
            {
                PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "نام كالا نميتواند خالي باشد", "e");
                txtNakaEdit.Focus();
                return;
            }
            if (cmbArzEdit.SelectedValue == null)
            {
                PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "هيچ ارزي انتخاب نشده است", "e");
                cmbArzEdit.Focus();
                return;
            }
            if (Connection.CrudService.GoodsCrud.Update(new Connection.Model.AllGoods() {ActDate=dateControlEdit.GetDateFullChar(),GoodsID=ResultEdit.GoodsID,ArzID=int.Parse(cmbArzEdit.SelectedValue.ToString()),ArzName=cmbArzEdit.Text,ArzPrice=decimal.Parse(txtArzPriceEdit.Text),BuyPrice=decimal.Parse(txtBuyPriceEdit.Text),GoodsName=txtNakaEdit.Text,OtherPrices=decimal.Parse(txtOtherPriceEdit.Text) }))
            {
                PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "ويرايش با موفقيت انجام شد");
                LoadData();
            }
            else
            {
                PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "ثبت با خطا مواجه شد", "e");
            }
        }
    }
}
