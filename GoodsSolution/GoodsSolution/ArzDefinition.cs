using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsSolution
{
    public class ArzDefinition : PersianUI.Controls.UserControl
    {
        private System.Windows.Forms.Panel pnlTop;
        private PersianUI.Controls.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlFooter;
        private PersianUI.Controls.Label label1;
        public PersianUI.Controls.TextBoxes.TextBox txtArz;
        private PersianUI.Controls.Label label2;
        private PersianUI.Controls.FloatTextBox txtPrice;
        private PersianUI.Controls.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private PersianUI.Controls.Buttons.CancelButton cancelButton;
        private PersianUI.Controls.Buttons.SaveButton saveButton;
        private System.Windows.Forms.Panel panel2;
        private PersianUI.Controls.Buttons.CancelButton cancelButtonEdit;
        private PersianUI.Controls.Buttons.SaveButton saveButtonEdit;
        private PersianUI.Controls.FloatTextBox txtPriceEdit;
        private PersianUI.Controls.Label label3;
        private PersianUI.Controls.TextBoxes.TextBox txtArzEdit;
        private PersianUI.Controls.Label label4;
        private System.Windows.Forms.Panel pnlMain;
        private System.Threading.Thread threadLoad;
        private PersianUI.Controls.Buttons.DeleteButton deleteButton;
        private System.Threading.ThreadStart threadStartLoad;
        private PersianUI.Controls.GroupBox groupBox3;
        private PersianUI.Controls.DataGridView dataGridView1;
        private PersianUI.Controls.TextBoxes.TextBox txtsearch;
        private List<Connection.Model.Arz> Result = new List<Connection.Model.Arz>();
        private Connection.Model.Arz ResultEdit = new Connection.Model.Arz();
        public ArzDefinition()
        {
            InitializeComponent();
            LoadData();
            txtArz.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txtArzEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txtsearch.SendTabKey = false;
        }
        private void LoadData()
        {
            txtArz.Text = txtArzEdit.Text = txtPrice.Text = txtPriceEdit.Text = string.Empty;
            pnlFooter.Visible = false;
            Result = Connection.CrudService.ArzCrud.ReturnArz();
            dataGridView1.DataSource = Result;
            txtArz.Focus();
            SetGrid();
        }
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.groupBox1 = new PersianUI.Controls.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelButton = new PersianUI.Controls.Buttons.CancelButton();
            this.saveButton = new PersianUI.Controls.Buttons.SaveButton();
            this.txtPrice = new PersianUI.Controls.FloatTextBox();
            this.label2 = new PersianUI.Controls.Label();
            this.txtArz = new PersianUI.Controls.TextBoxes.TextBox();
            this.label1 = new PersianUI.Controls.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.groupBox2 = new PersianUI.Controls.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteButton = new PersianUI.Controls.Buttons.DeleteButton();
            this.cancelButtonEdit = new PersianUI.Controls.Buttons.CancelButton();
            this.saveButtonEdit = new PersianUI.Controls.Buttons.SaveButton();
            this.txtPriceEdit = new PersianUI.Controls.FloatTextBox();
            this.label3 = new PersianUI.Controls.Label();
            this.txtArzEdit = new PersianUI.Controls.TextBoxes.TextBox();
            this.label4 = new PersianUI.Controls.Label();
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
            this.pnlTop.Size = new System.Drawing.Size(800, 76);
            this.pnlTop.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtArz);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تعريف ارز";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Location = new System.Drawing.Point(20, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 37);
            this.panel1.TabIndex = 2;
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
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Location = new System.Drawing.Point(232, 38);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(10);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.NextControl = this.saveButton;
            this.txtPrice.Size = new System.Drawing.Size(200, 29);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.label2.Location = new System.Drawing.Point(445, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "نرخ ارز";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtArz
            // 
            this.txtArz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArz.BackColor = System.Drawing.Color.White;
            this.txtArz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArz.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.txtArz.ForeColor = System.Drawing.Color.Black;
            this.txtArz.Location = new System.Drawing.Point(541, 38);
            this.txtArz.Margin = new System.Windows.Forms.Padding(10);
            this.txtArz.Name = "txtArz";
            this.txtArz.NextControl = this.txtPrice;
            this.txtArz.Size = new System.Drawing.Size(200, 29);
            this.txtArz.TabIndex = 0;
            this.txtArz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.label1.Location = new System.Drawing.Point(754, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام ارز";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.groupBox2);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 435);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(800, 65);
            this.pnlFooter.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.txtPriceEdit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtArzEdit);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 65);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ويرايش ارز تعريف شده";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.cancelButtonEdit);
            this.panel2.Controls.Add(this.saveButtonEdit);
            this.panel2.Location = new System.Drawing.Point(-38, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 40);
            this.panel2.TabIndex = 2;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(111, 2);
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
            this.cancelButtonEdit.Location = new System.Drawing.Point(26, 2);
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
            this.saveButtonEdit.Location = new System.Drawing.Point(197, 3);
            this.saveButtonEdit.Margin = new System.Windows.Forms.Padding(10);
            this.saveButtonEdit.Name = "saveButtonEdit";
            this.saveButtonEdit.NextControl = null;
            this.saveButtonEdit.Size = new System.Drawing.Size(81, 34);
            this.saveButtonEdit.TabIndex = 0;
            this.saveButtonEdit.Text = "ثبت";
            this.saveButtonEdit.UseVisualStyleBackColor = false;
            this.saveButtonEdit.Click += new System.EventHandler(this.SaveButtonEdit_Click);
            // 
            // txtPriceEdit
            // 
            this.txtPriceEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriceEdit.BackColor = System.Drawing.Color.White;
            this.txtPriceEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPriceEdit.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.txtPriceEdit.ForeColor = System.Drawing.Color.Black;
            this.txtPriceEdit.Location = new System.Drawing.Point(246, 27);
            this.txtPriceEdit.Margin = new System.Windows.Forms.Padding(10);
            this.txtPriceEdit.Name = "txtPriceEdit";
            this.txtPriceEdit.NextControl = this.saveButtonEdit;
            this.txtPriceEdit.Size = new System.Drawing.Size(200, 29);
            this.txtPriceEdit.TabIndex = 1;
            this.txtPriceEdit.Text = "0";
            this.txtPriceEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.label3.Location = new System.Drawing.Point(447, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "نرخ ارز";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtArzEdit
            // 
            this.txtArzEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArzEdit.BackColor = System.Drawing.Color.White;
            this.txtArzEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArzEdit.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.txtArzEdit.ForeColor = System.Drawing.Color.Black;
            this.txtArzEdit.Location = new System.Drawing.Point(539, 27);
            this.txtArzEdit.Margin = new System.Windows.Forms.Padding(10);
            this.txtArzEdit.Name = "txtArzEdit";
            this.txtArzEdit.NextControl = this.txtPriceEdit;
            this.txtArzEdit.Size = new System.Drawing.Size(200, 29);
            this.txtArzEdit.TabIndex = 0;
            this.txtArzEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.label4.Location = new System.Drawing.Point(752, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "نام ارز";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox3);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 76);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 359);
            this.pnlMain.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.txtsearch);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 359);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ارزهاي تعريف شده";
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
            this.dataGridView1.Size = new System.Drawing.Size(794, 302);
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
            // ArzDefinition
            // 
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlTop);
            this.Name = "ArzDefinition";
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
        //================================================================
        /// <summary>
        ///  Load User Control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserControl_Load(object sender, EventArgs e)
        {
            try
            {
                MTF_UserControl();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// Starting Thread
        /// </summary>
        private void MTF_UserControl()
        {
            try
            {
                threadStartLoad = new System.Threading.ThreadStart(MTF_UserControlLoad_Load);
                threadLoad = new System.Threading.Thread(threadStartLoad)
                {
                    Priority = System.Threading.ThreadPriority.AboveNormal,
                    IsBackground = true //<— Set the thread to work in background
                };
                //
                threadLoad.Start();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// Act Thread
        /// </summary>
        /// 
        private void MTF_UserControlLoad_Load()
        {
            Invoke(new System.Windows.Forms.MethodInvoker(delegate ()
            {
                txtArz.Focus();
            }));
        }
        private void CancelButtonEdit_Click(object sender, EventArgs e)
        {
            pnlFooter.Visible = false;
            txtsearch.Focus();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainForm.pnlMain.Controls.Clear();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (txtArz.Text.Trim() == string.Empty)
            {
                PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "نام ارز نمي‌تواند خالي باشد", "e");
                return;
            }
            if (txtPrice.Text == "0")
            {
                PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "مبلغ ارز نمي‌تواند خالي باشد", "e");
                return;
            }
            if (Connection.CrudService.ArzCrud.Create(new Connection.Model.Arz() { ArzName = txtArz.Text.Trim(), Price = decimal.Parse(txtPrice.Text) }))
            {
                PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "ثبت با موفقيت انجام شد");
                LoadData();
            }
            else
            {
                PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "ثبت با خطا مواجه شد", "e");
            }
        }
        private void SetGrid()
        {
            foreach (System.Windows.Forms.DataGridViewColumn item in dataGridView1.Columns)
            {
                item.Visible = false;
            }
            dataGridView1.Columns["ArzID"].Visible = true;
            dataGridView1.Columns["ArzName"].Visible = true;
            dataGridView1.Columns["Price"].Visible = true;
            dataGridView1.Columns["ArzID"].HeaderText = "رديف";
            dataGridView1.Columns["ArzName"].HeaderText = "نام ارز";
            dataGridView1.Columns["Price"].HeaderText = "مبلغ";
            dataGridView1.Columns["Price"].Width = 200;
            dataGridView1.Columns["ArzID"].Width = 60;
            dataGridView1.Columns["ArzName"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Price"].DefaultCellStyle.Format = "0.##";
            dataGridView1.AutoGenerateColumns = false;
        }
        private void SetActiveRow(PersianUI.Controls.DataGridView DG, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                string ColName = "ArzName";
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
            dataGridView1.DataSource = txtsearch.Text.Trim() == string.Empty ? Result : Result.Where(a => a.ArzName.Contains(txtsearch.Text.Trim())).ToList();
        }
        private void OpenAct()
        {
            if (dataGridView1.RowCount > 0)
            {
                if (dataGridView1.CurrentRow == null) dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells["ArzName"];
                ResultEdit = (Connection.Model.Arz)dataGridView1.CurrentRow.DataBoundItem;
                txtArzEdit.Text = ResultEdit.ArzName;
                txtPriceEdit.Text = ResultEdit.Price.ToString("0.##");
                pnlFooter.Visible = true;
                txtArzEdit.Focus();
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
        private void SaveButtonEdit_Click(object sender, EventArgs e)
        {
            if (txtArzEdit.Text.Trim() == string.Empty)
            {
                PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "نام ارز نمي‌تواند خالي باشد", "e");
                return;
            }
            if (txtPriceEdit.Text == "0")
            {
                PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "مبلغ ارز نمي‌تواند خالي باشد", "e");
                return;
            }
            if (Connection.CrudService.ArzCrud.Update(new Connection.Model.Arz() { ArzID = ResultEdit.ArzID, ArzName = txtArzEdit.Text.Trim(), Price = decimal.Parse(txtPriceEdit.Text) }))
            {
                PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "ويرايش با موفقيت انجام شد");
                LoadData();
            }
            else
            {
                PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "ثبت با خطا مواجه شد", "e");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام","آيا از حذف اطمينان داريد؟","w")==System.Windows.Forms.DialogResult.Yes)
            {
                if (Connection.CrudService.ArzCrud.Delete(ResultEdit.ArzID))
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
    }
}
