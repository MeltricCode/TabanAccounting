
namespace Accounting.App
{
    partial class NewPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPayment));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchBoxPayment = new System.Windows.Forms.TextBox();
            this.DgPayment = new System.Windows.Forms.DataGridView();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReciveRadio = new System.Windows.Forms.RadioButton();
            this.PayRadio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.AmountBox = new System.Windows.Forms.NumericUpDown();
            this.p = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchBoxPayment);
            this.groupBox1.Controls.Add(this.DgPayment);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اشخاص";
            // 
            // SearchBoxPayment
            // 
            this.SearchBoxPayment.Location = new System.Drawing.Point(6, 24);
            this.SearchBoxPayment.Multiline = true;
            this.SearchBoxPayment.Name = "SearchBoxPayment";
            this.SearchBoxPayment.Size = new System.Drawing.Size(203, 26);
            this.SearchBoxPayment.TabIndex = 1;
            this.SearchBoxPayment.TextChanged += new System.EventHandler(this.SearchBoxPayment_TextChanged);
            // 
            // DgPayment
            // 
            this.DgPayment.AllowUserToAddRows = false;
            this.DgPayment.AllowUserToDeleteRows = false;
            this.DgPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgPayment.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.DgPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.FullName});
            this.DgPayment.Location = new System.Drawing.Point(6, 57);
            this.DgPayment.Name = "DgPayment";
            this.DgPayment.ReadOnly = true;
            this.DgPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgPayment.Size = new System.Drawing.Size(203, 241);
            this.DgPayment.TabIndex = 0;
            this.DgPayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgPayment_CellClick);
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "کد کاربر";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            this.CustomerId.Visible = false;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "نام و نام خانوادگی";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // BoxName
            // 
            this.BoxName.Location = new System.Drawing.Point(243, 23);
            this.BoxName.Name = "BoxName";
            this.BoxName.Size = new System.Drawing.Size(243, 21);
            this.BoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "طرف حساب:";
            // 
            // ReciveRadio
            // 
            this.ReciveRadio.AutoSize = true;
            this.ReciveRadio.Location = new System.Drawing.Point(426, 69);
            this.ReciveRadio.Name = "ReciveRadio";
            this.ReciveRadio.Size = new System.Drawing.Size(55, 17);
            this.ReciveRadio.TabIndex = 3;
            this.ReciveRadio.TabStop = true;
            this.ReciveRadio.Text = "دریافت";
            this.ReciveRadio.UseVisualStyleBackColor = true;
            // 
            // PayRadio
            // 
            this.PayRadio.AutoSize = true;
            this.PayRadio.Location = new System.Drawing.Point(362, 69);
            this.PayRadio.Name = "PayRadio";
            this.PayRadio.Size = new System.Drawing.Size(58, 17);
            this.PayRadio.TabIndex = 4;
            this.PayRadio.TabStop = true;
            this.PayRadio.Text = "پرداخت";
            this.PayRadio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "نوع تراکنش:";
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(243, 119);
            this.AmountBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(243, 21);
            this.AmountBox.TabIndex = 6;
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Location = new System.Drawing.Point(496, 121);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(31, 13);
            this.p.TabIndex = 7;
            this.p.Text = "مبلغ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "شرح:";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(243, 159);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(243, 127);
            this.DescriptionBox.TabIndex = 9;
            this.DescriptionBox.Text = " ";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(411, 295);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitBtn.TabIndex = 10;
            this.SubmitBtn.Text = "ثبت";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // NewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(563, 328);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.p);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PayRadio);
            this.Controls.Add(this.ReciveRadio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxName);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewPayment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "NewPayment";
            this.Load += new System.EventHandler(this.NewPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgPayment;
        private System.Windows.Forms.TextBox SearchBoxPayment;
        private System.Windows.Forms.TextBox BoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ReciveRadio;
        private System.Windows.Forms.RadioButton PayRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown AmountBox;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
    }
}