
namespace Accounting.App
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BtnSetting = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnCustomers = new System.Windows.Forms.ToolStripButton();
            this.NewPaymentBtn = new System.Windows.Forms.ToolStripButton();
            this.ResiveReportBtn = new System.Windows.Forms.ToolStripButton();
            this.PayReportBtn = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.DateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ClockLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ChangePasswordInForm = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSetting});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(707, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // BtnSetting
            // 
            this.BtnSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangePasswordInForm,
            this.LogOutBtn});
            this.BtnSetting.Image = ((System.Drawing.Image)(resources.GetObject("BtnSetting.Image")));
            this.BtnSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSetting.Name = "BtnSetting";
            this.BtnSetting.Size = new System.Drawing.Size(63, 22);
            this.BtnSetting.Text = "تنظیمات";
            this.BtnSetting.ToolTipText = "تنظیمات";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCustomers,
            this.NewPaymentBtn,
            this.ResiveReportBtn,
            this.PayReportBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(707, 72);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.AutoSize = false;
            this.BtnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("BtnCustomers.Image")));
            this.BtnCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.Size = new System.Drawing.Size(85, 69);
            this.BtnCustomers.Text = "طرف حساب ها";
            this.BtnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // NewPaymentBtn
            // 
            this.NewPaymentBtn.Image = global::Accounting.App.Properties.Resources.icons8_online_payment_50;
            this.NewPaymentBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NewPaymentBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewPaymentBtn.Name = "NewPaymentBtn";
            this.NewPaymentBtn.Size = new System.Drawing.Size(72, 69);
            this.NewPaymentBtn.Text = "تراکنش جدید";
            this.NewPaymentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NewPaymentBtn.Click += new System.EventHandler(this.NewPaymentBtn_Click);
            // 
            // ResiveReportBtn
            // 
            this.ResiveReportBtn.Image = global::Accounting.App.Properties.Resources.icons8_receive_cash_50;
            this.ResiveReportBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ResiveReportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResiveReportBtn.Name = "ResiveReportBtn";
            this.ResiveReportBtn.Size = new System.Drawing.Size(98, 69);
            this.ResiveReportBtn.Text = "گزارش دریافتی ها";
            this.ResiveReportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ResiveReportBtn.Click += new System.EventHandler(this.ResiveReportBtn_Click);
            // 
            // PayReportBtn
            // 
            this.PayReportBtn.Image = global::Accounting.App.Properties.Resources.icons8_payment2_50;
            this.PayReportBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PayReportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PayReportBtn.Name = "PayReportBtn";
            this.PayReportBtn.Size = new System.Drawing.Size(97, 69);
            this.PayReportBtn.Text = "گزارش پرداختی ها";
            this.PayReportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PayReportBtn.Click += new System.EventHandler(this.PayReportBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DateLabel,
            this.ClockLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 452);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(707, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // DateLabel
            // 
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(59, 17);
            this.DateLabel.Text = "DateLabel";
            // 
            // ClockLabel
            // 
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(65, 17);
            this.ClockLabel.Text = "ClockLabel";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ChangePasswordInForm
            // 
            this.ChangePasswordInForm.Name = "ChangePasswordInForm";
            this.ChangePasswordInForm.Size = new System.Drawing.Size(180, 22);
            this.ChangePasswordInForm.Text = "تغییر رمز عبور";
            this.ChangePasswordInForm.Click += new System.EventHandler(this.ChangePasswordInForm_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(180, 22);
            this.LogOutBtn.Text = "خروج از حساب کاربری";
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Accounting.App.Properties.Resources.MainFormBg_00000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(707, 474);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نرم افزار حسابداری تابان";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton BtnSetting;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnCustomers;
        private System.Windows.Forms.ToolStripButton NewPaymentBtn;
        private System.Windows.Forms.ToolStripButton ResiveReportBtn;
        private System.Windows.Forms.ToolStripButton PayReportBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel DateLabel;
        private System.Windows.Forms.ToolStripStatusLabel ClockLabel;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordInForm;
        private System.Windows.Forms.ToolStripMenuItem LogOutBtn;
    }
}

