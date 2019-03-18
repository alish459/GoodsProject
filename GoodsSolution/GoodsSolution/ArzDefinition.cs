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
        private PersianUI.Controls.NumericTextBoxWithSeperator txtPrice;
        private PersianUI.Controls.TextBoxes.TextBox textBox1;
        private PersianUI.Controls.DataGridView dataGridView1;
        private PersianUI.Controls.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private PersianUI.Controls.Buttons.CancelButton cancelButton;
        private PersianUI.Controls.Buttons.SaveButton saveButton;
        private System.Windows.Forms.Panel panel2;
        private PersianUI.Controls.Buttons.CancelButton cancelButtonEdit;
        private PersianUI.Controls.Buttons.SaveButton saveButtonEdit;
        private PersianUI.Controls.NumericTextBoxWithSeperator txtPriceEdit;
        private PersianUI.Controls.Label label3;
        private PersianUI.Controls.TextBoxes.TextBox txtArzEdit;
        private PersianUI.Controls.Label label4;
        private System.Windows.Forms.Panel pnlMain;
        private System.Threading.Thread threadLoad;
        private PersianUI.Controls.Buttons.DeleteButton deleteButton;
        private System.Threading.ThreadStart threadStartLoad;
        private List<Connection.Model.Arz> Result = new List<Connection.Model.Arz>();
        public ArzDefinition()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            txtArz.Text = txtArzEdit.Text = txtPrice.Text = txtPriceEdit.Text = string.Empty;
            pnlFooter.Visible = false;
            Result = Connection.CrudService.ArzCrud.ReturnArz();
            dataGridView1.DataSource = Result;
            txtArz.Focus();
        }
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.groupBox1 = new PersianUI.Controls.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelButton = new PersianUI.Controls.Buttons.CancelButton();
            this.saveButton = new PersianUI.Controls.Buttons.SaveButton();
            this.txtPrice = new PersianUI.Controls.NumericTextBoxWithSeperator();
            this.label2 = new PersianUI.Controls.Label();
            this.txtArz = new PersianUI.Controls.TextBoxes.TextBox();
            this.label1 = new PersianUI.Controls.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.groupBox2 = new PersianUI.Controls.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteButton = new PersianUI.Controls.Buttons.DeleteButton();
            this.cancelButtonEdit = new PersianUI.Controls.Buttons.CancelButton();
            this.saveButtonEdit = new PersianUI.Controls.Buttons.SaveButton();
            this.txtPriceEdit = new PersianUI.Controls.NumericTextBoxWithSeperator();
            this.label3 = new PersianUI.Controls.Label();
            this.txtArzEdit = new PersianUI.Controls.TextBoxes.TextBox();
            this.label4 = new PersianUI.Controls.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dataGridView1 = new PersianUI.Controls.DataGridView();
            this.textBox1 = new PersianUI.Controls.TextBoxes.TextBox();
            this.pnlTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.groupBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1200, 76);
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
            this.groupBox1.Size = new System.Drawing.Size(1200, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تعريف ارز";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Location = new System.Drawing.Point(420, 30);
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
            this.txtPrice.Location = new System.Drawing.Point(632, 38);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(10);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.NextControl = this.saveButton;
            this.txtPrice.Size = new System.Drawing.Size(200, 29);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.Value = 0D;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.label2.Location = new System.Drawing.Point(845, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "ارزش ارز به ريال";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtArz
            // 
            this.txtArz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArz.BackColor = System.Drawing.Color.White;
            this.txtArz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArz.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.txtArz.ForeColor = System.Drawing.Color.Black;
            this.txtArz.Location = new System.Drawing.Point(941, 38);
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
            this.label1.Location = new System.Drawing.Point(1154, 40);
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
            this.pnlFooter.Size = new System.Drawing.Size(1200, 65);
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
            this.groupBox2.Size = new System.Drawing.Size(1200, 65);
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
            this.panel2.Location = new System.Drawing.Point(332, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 40);
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
            // 
            // txtPriceEdit
            // 
            this.txtPriceEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriceEdit.BackColor = System.Drawing.Color.White;
            this.txtPriceEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPriceEdit.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.txtPriceEdit.ForeColor = System.Drawing.Color.Black;
            this.txtPriceEdit.Location = new System.Drawing.Point(630, 27);
            this.txtPriceEdit.Margin = new System.Windows.Forms.Padding(10);
            this.txtPriceEdit.Name = "txtPriceEdit";
            this.txtPriceEdit.NextControl = null;
            this.txtPriceEdit.Size = new System.Drawing.Size(200, 29);
            this.txtPriceEdit.TabIndex = 1;
            this.txtPriceEdit.Text = "0";
            this.txtPriceEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPriceEdit.Value = 0D;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.label3.Location = new System.Drawing.Point(843, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "ارزش ارز به ريال";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtArzEdit
            // 
            this.txtArzEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArzEdit.BackColor = System.Drawing.Color.White;
            this.txtArzEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArzEdit.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.txtArzEdit.ForeColor = System.Drawing.Color.Black;
            this.txtArzEdit.Location = new System.Drawing.Point(939, 27);
            this.txtArzEdit.Margin = new System.Windows.Forms.Padding(10);
            this.txtArzEdit.Name = "txtArzEdit";
            this.txtArzEdit.NextControl = null;
            this.txtArzEdit.Size = new System.Drawing.Size(200, 29);
            this.txtArzEdit.TabIndex = 0;
            this.txtArzEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.label4.Location = new System.Drawing.Point(1152, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "نام ارز";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dataGridView1);
            this.pnlMain.Controls.Add(this.textBox1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 76);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1200, 359);
            this.pnlMain.TabIndex = 2;
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1200, 330);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10);
            this.textBox1.Name = "textBox1";
            this.textBox1.NextControl = null;
            this.textBox1.Size = new System.Drawing.Size(1200, 29);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ArzDefinition
            // 
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlTop);
            this.Name = "ArzDefinition";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1200, 500);
            this.pnlTop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
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
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainForm.pnlMain.Controls.Clear();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (txtArz.Text.Trim()==string.Empty)
            {
                PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "نام ارز نمي‌تواند خالي باشد", "e");
                return;
            }
            if (txtPrice.Text=="0")
            {
                PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "مبلغ ارز نمي‌تواند خالي باشد", "e");
                return;
            }
            if (Connection.CrudService.ArzCrud.Create(new Connection.Model.Arz() {ArzName=txtArz.Text.Trim(),Price=decimal.Parse(txtPrice.Text) }))
            {
                PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "ثبت با موفقيت انجام شد");
                LoadData();
            }
            else
            {
                PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "ثبت با خطا مواجه شد", "e");
            }
        }
    }
}
