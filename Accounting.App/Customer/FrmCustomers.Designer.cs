
namespace Accounting.App
{
    partial class FrmCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomers));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnAddFrmCustomers = new System.Windows.Forms.ToolStripButton();
            this.BtnEditFrmCustomers = new System.Windows.Forms.ToolStripButton();
            this.BtnDeleteFrmCustomers = new System.Windows.Forms.ToolStripButton();
            this.BtnRefreshFrmCustomers = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.SearchBoxFrmCustomers = new System.Windows.Forms.ToolStripTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgCustomers = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAddFrmCustomers,
            this.BtnEditFrmCustomers,
            this.BtnDeleteFrmCustomers,
            this.BtnRefreshFrmCustomers,
            this.toolStripLabel1,
            this.SearchBoxFrmCustomers});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(616, 72);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnAddFrmCustomers
            // 
            this.BtnAddFrmCustomers.Image = global::Accounting.App.Properties.Resources.icons8_add_user_50;
            this.BtnAddFrmCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnAddFrmCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAddFrmCustomers.Name = "BtnAddFrmCustomers";
            this.BtnAddFrmCustomers.Size = new System.Drawing.Size(80, 69);
            this.BtnAddFrmCustomers.Text = "افزودن شخص";
            this.BtnAddFrmCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAddFrmCustomers.Click += new System.EventHandler(this.BtnAddFrmCustomers_Click);
            // 
            // BtnEditFrmCustomers
            // 
            this.BtnEditFrmCustomers.Image = global::Accounting.App.Properties.Resources.icons8_edit_48;
            this.BtnEditFrmCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnEditFrmCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEditFrmCustomers.Name = "BtnEditFrmCustomers";
            this.BtnEditFrmCustomers.Size = new System.Drawing.Size(83, 69);
            this.BtnEditFrmCustomers.Text = "ویرایش شخص";
            this.BtnEditFrmCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEditFrmCustomers.Click += new System.EventHandler(this.BtnEditFrmCustomers_Click);
            // 
            // BtnDeleteFrmCustomers
            // 
            this.BtnDeleteFrmCustomers.Image = global::Accounting.App.Properties.Resources.icons8_delete_48;
            this.BtnDeleteFrmCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnDeleteFrmCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDeleteFrmCustomers.Name = "BtnDeleteFrmCustomers";
            this.BtnDeleteFrmCustomers.Size = new System.Drawing.Size(72, 69);
            this.BtnDeleteFrmCustomers.Text = "حذف شخص";
            this.BtnDeleteFrmCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDeleteFrmCustomers.Click += new System.EventHandler(this.BtnDeleteFrmCustomers_Click);
            // 
            // BtnRefreshFrmCustomers
            // 
            this.BtnRefreshFrmCustomers.Image = global::Accounting.App.Properties.Resources.icons8_refresh_50;
            this.BtnRefreshFrmCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnRefreshFrmCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRefreshFrmCustomers.Name = "BtnRefreshFrmCustomers";
            this.BtnRefreshFrmCustomers.Size = new System.Drawing.Size(73, 69);
            this.BtnRefreshFrmCustomers.Text = "به روز رسانی";
            this.BtnRefreshFrmCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnRefreshFrmCustomers.Click += new System.EventHandler(this.BtnRefreshFrmCustomers_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 69);
            this.toolStripLabel1.Text = "جستوجو:";
            // 
            // SearchBoxFrmCustomers
            // 
            this.SearchBoxFrmCustomers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchBoxFrmCustomers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBoxFrmCustomers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchBoxFrmCustomers.Name = "SearchBoxFrmCustomers";
            this.SearchBoxFrmCustomers.Size = new System.Drawing.Size(200, 72);
            this.SearchBoxFrmCustomers.TextChanged += new System.EventHandler(this.SearchBoxFrmCustomers_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.DgCustomers);
            this.groupBox1.Location = new System.Drawing.Point(0, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 301);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "طرف حساب ها";
            // 
            // DgCustomers
            // 
            this.DgCustomers.AllowUserToAddRows = false;
            this.DgCustomers.AllowUserToDeleteRows = false;
            this.DgCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgCustomers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.FullName,
            this.Mobile,
            this.Email,
            this.Adress,
            this.Image});
            this.DgCustomers.Location = new System.Drawing.Point(0, 18);
            this.DgCustomers.Name = "DgCustomers";
            this.DgCustomers.ReadOnly = true;
            this.DgCustomers.Size = new System.Drawing.Size(616, 290);
            this.DgCustomers.TabIndex = 0;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "کد شخص";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "نام و نام خانوادگی";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "موبایل";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "ایمیل";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Adress
            // 
            this.Adress.DataPropertyName = "Adress";
            this.Adress.HeaderText = "آدرس";
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            this.Adress.Visible = false;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "CustomerImage";
            this.Image.HeaderText = "تصویر";
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Visible = false;
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Accounting.App.Properties.Resources.MainFormBg_00000;
            this.ClientSize = new System.Drawing.Size(616, 371);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCustomers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "طرف حساب ها";
            this.Load += new System.EventHandler(this.FrmCustomers_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnAddFrmCustomers;
        private System.Windows.Forms.ToolStripButton BtnEditFrmCustomers;
        private System.Windows.Forms.ToolStripButton BtnDeleteFrmCustomers;
        private System.Windows.Forms.ToolStripButton BtnRefreshFrmCustomers;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox SearchBoxFrmCustomers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
    }
}