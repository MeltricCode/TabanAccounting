using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.Services;

namespace Accounting.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            FrmCustomers frmCustomers = new FrmCustomers();

            frmCustomers.ShowDialog();
        }

        private void NewPaymentBtn_Click(object sender, EventArgs e)
        {
            NewPayment PaymentForm = new NewPayment();
            PaymentForm.ShowDialog();
        }

        private void ResiveReportBtn_Click(object sender, EventArgs e)
        {
            ReciveReportFrm report_frm = new ReciveReportFrm();
            report_frm.report_type = 1;
            report_frm.ShowDialog();

        }

        private void PayReportBtn_Click(object sender, EventArgs e)
        {
            ReciveReportFrm report_frm = new ReciveReportFrm();
            report_frm.report_type = 0;
            report_frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            if(loginform.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                DateLabel.Text = DateTime.Now.ToShamsi();
                ClockLabel.Text = DateTime.Now.ToString("hh:mm:ss");
            }
            else
            {
                Application.Exit();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void ChangePasswordInForm_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changepasswordform = new ChangePasswordForm();
            changepasswordform.ShowDialog();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            this.Hide();
            if(loginform.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
