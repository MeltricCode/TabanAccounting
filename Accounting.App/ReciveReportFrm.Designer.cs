
namespace Accounting.App
{
    partial class ReciveReportFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReciveReportFrm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.EditReportBtn = new System.Windows.Forms.ToolStripButton();
            this.DeleteBtn = new System.Windows.Forms.ToolStripButton();
            this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.PrintBtn = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GetReport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ToDateTimeBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FromDateTimeBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerCombo = new System.Windows.Forms.ComboBox();
            this.DgReport = new System.Windows.Forms.DataGridView();
            this.PaymentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StiReport = new Stimulsoft.Report.StiReport();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgReport)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditReportBtn,
            this.DeleteBtn,
            this.RefreshBtn,
            this.PrintBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(715, 72);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // EditReportBtn
            // 
            this.EditReportBtn.Image = global::Accounting.App.Properties.Resources.icons8_edit_48;
            this.EditReportBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditReportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditReportBtn.Name = "EditReportBtn";
            this.EditReportBtn.Size = new System.Drawing.Size(52, 69);
            this.EditReportBtn.Text = "ویرایش";
            this.EditReportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditReportBtn.Click += new System.EventHandler(this.EditReportBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Image = global::Accounting.App.Properties.Resources.icons8_delete_48;
            this.DeleteBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(52, 69);
            this.DeleteBtn.Text = "حذف";
            this.DeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Image = global::Accounting.App.Properties.Resources.icons8_refresh_50;
            this.RefreshBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(73, 69);
            this.RefreshBtn.Text = "به روز رسانی";
            this.RefreshBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Image = global::Accounting.App.Properties.Resources.icons8_print_48;
            this.PrintBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PrintBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(52, 69);
            this.PrintBtn.Text = "چاپ";
            this.PrintBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.GetReport);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ToDateTimeBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FromDateTimeBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CustomerCombo);
            this.groupBox1.Location = new System.Drawing.Point(0, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جست و جو";
            // 
            // GetReport
            // 
            this.GetReport.Location = new System.Drawing.Point(17, 23);
            this.GetReport.Name = "GetReport";
            this.GetReport.Size = new System.Drawing.Size(75, 23);
            this.GetReport.TabIndex = 2;
            this.GetReport.Text = "گزارشگیری";
            this.GetReport.UseVisualStyleBackColor = true;
            this.GetReport.Click += new System.EventHandler(this.GetReport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "تا تاریخ و ساعت:";
            // 
            // ToDateTimeBox
            // 
            this.ToDateTimeBox.Location = new System.Drawing.Point(100, 25);
            this.ToDateTimeBox.Mask = "0000/00/00";
            this.ToDateTimeBox.Name = "ToDateTimeBox";
            this.ToDateTimeBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToDateTimeBox.Size = new System.Drawing.Size(100, 21);
            this.ToDateTimeBox.TabIndex = 4;
            this.ToDateTimeBox.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "از تاریخ و ساعت:";
            // 
            // FromDateTimeBox
            // 
            this.FromDateTimeBox.Location = new System.Drawing.Point(297, 25);
            this.FromDateTimeBox.Mask = "0000/00/00";
            this.FromDateTimeBox.Name = "FromDateTimeBox";
            this.FromDateTimeBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FromDateTimeBox.Size = new System.Drawing.Size(100, 21);
            this.FromDateTimeBox.TabIndex = 2;
            this.FromDateTimeBox.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(638, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "طرف حساب:";
            // 
            // CustomerCombo
            // 
            this.CustomerCombo.FormattingEnabled = true;
            this.CustomerCombo.Location = new System.Drawing.Point(493, 25);
            this.CustomerCombo.Name = "CustomerCombo";
            this.CustomerCombo.Size = new System.Drawing.Size(141, 21);
            this.CustomerCombo.TabIndex = 0;
            // 
            // DgReport
            // 
            this.DgReport.AllowUserToAddRows = false;
            this.DgReport.AllowUserToDeleteRows = false;
            this.DgReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgReport.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DgReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentId,
            this.CustomerID,
            this.FullName,
            this.Amount,
            this.DateTime});
            this.DgReport.Location = new System.Drawing.Point(10, 133);
            this.DgReport.Name = "DgReport";
            this.DgReport.ReadOnly = true;
            this.DgReport.Size = new System.Drawing.Size(696, 266);
            this.DgReport.TabIndex = 2;
            // 
            // PaymentId
            // 
            this.PaymentId.DataPropertyName = "Id";
            this.PaymentId.HeaderText = "کد تراکنش";
            this.PaymentId.Name = "PaymentId";
            this.PaymentId.ReadOnly = true;
            this.PaymentId.Visible = false;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerId";
            this.CustomerID.HeaderText = "کد مشتری";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "CustomerId";
            this.FullName.HeaderText = "نام";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "مبلغ";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // DateTime
            // 
            this.DateTime.DataPropertyName = "DateTime";
            this.DateTime.HeaderText = "تاریخ";
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            // 
            // StiReport
            // 
            this.StiReport.CookieContainer = null;
            this.StiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.StiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.StiReport.ReportAlias = "Report";
            this.StiReport.ReportGuid = "4bb3eebd23744d87b962a5ba70a34ade";
            this.StiReport.ReportName = "Report";
            this.StiReport.ReportSource = null;
            this.StiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.StiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.StiReport.UseProgressInThread = false;
            // 
            // ReciveReportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Accounting.App.Properties.Resources.MainFormBg_00000;
            this.ClientSize = new System.Drawing.Size(715, 405);
            this.Controls.Add(this.DgReport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReciveReportFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "گزارش دریافتی ها";
            this.Load += new System.EventHandler(this.ReciveReportFrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton EditReportBtn;
        private System.Windows.Forms.ToolStripButton DeleteBtn;
        private System.Windows.Forms.ToolStripButton RefreshBtn;
        private System.Windows.Forms.ToolStripButton PrintBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button GetReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox ToDateTimeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox FromDateTimeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CustomerCombo;
        private System.Windows.Forms.DataGridView DgReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private Stimulsoft.Report.StiReport StiReport;
    }
}