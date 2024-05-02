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
using Accounting.DataLayer;
using Accounting.ViewModel;
using System.Globalization;

namespace Accounting.App
{
    public partial class ReciveReportFrm : Form
    {
        public ReciveReportFrm()
        {
            InitializeComponent();
        }
        public void Refresh()
        {
            Accounting_DBEntities db = new Accounting_DBEntities();
            GenericRepository<DataLayer.Accounting> accounting = new GenericRepository<DataLayer.Accounting>(db);
            CustomerRepository customers = new CustomerRepository(db);
            DgReport.AutoGenerateColumns = false;
            DgReport.Rows.Clear();

            if (FromDateTimeBox.Text != "    /  /  " && ToDateTimeBox.Text != "    /  /  ")
            {
                DateTime fromdate = Convert.ToDateTime(FromDateTimeBox.Text).ToMiladi();
                DateTime todate = Convert.ToDateTime(ToDateTimeBox.Text).ToMiladi();
                int a = (int)CustomerCombo.SelectedValue;
                if((int)CustomerCombo.SelectedValue == 0) 
                { 
                    var resault = accounting.Get(t => t.TypeId == report_type && t.DateTime >= fromdate && t.DateTime <= todate);
                    foreach (var payment in resault)
                    {
                        var fullname = customers.GetFullnameById(payment.CustomerId);

                        DgReport.Rows.Add(payment.Id ,payment.CustomerId, fullname, payment.Amount, DateConvertor.ToShamsi(payment.DateTime));
                    } // می دونم یک مقدار منابع سیستمو درگیر می کنه ولی کاربرد این برنامه برای استفاده ساده است و زیاد سنگین نمی شه تعداد سند ها
                }
                else
                {
                    var resault = accounting.Get(t => t.TypeId == report_type && t.DateTime >= fromdate && t.DateTime <= todate && t.CustomerId == (int)CustomerCombo.SelectedValue);
                    foreach (var payment in resault)
                    {
                        var fullname = customers.GetFullnameById(payment.CustomerId);

                        DgReport.Rows.Add(payment.Id, payment.CustomerId, fullname, payment.Amount, DateConvertor.ToShamsi(payment.DateTime));
                    }
                }
            }
        }
        public int report_type = 0;
        private void ReciveReportFrm_Load(object sender, EventArgs e)
        {
            Accounting_DBEntities db = new Accounting_DBEntities();
            CustomerRepository customers = new CustomerRepository(db);
            FromDateTimeBox.Text = DateConvertor.ToShamsi(System.DateTime.Now);
            ToDateTimeBox.Text = DateConvertor.ToShamsi(System.DateTime.Now.AddDays(1));

            List<ListCustomersViewModel> list = new List<ListCustomersViewModel>();
            list.Add(new ListCustomersViewModel()
            {
                CustomerId = 0,
                FullName = "همه اشخاص"
            });
            list.AddRange(customers.GetNameCustomers());
            CustomerCombo.DataSource = list;
            CustomerCombo.DisplayMember = "FullName";
            CustomerCombo.ValueMember = "CustomerId";
            CustomerCombo.SelectedItem = CustomerCombo.Items[0];
            if (report_type == 0)
            {
                this.Text = "گزارش پرداختی ها";
            }
            else
            {
                this.Text = "گزارش دریافتی ها";
            }
        }

        private void GetReport_Click(object sender, EventArgs e)
        {
            Refresh();

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(DgReport.CurrentRow != null)
            {
                if(MessageBox.Show("آیا از حذف مطمعن هستید؟","هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    Accounting_DBEntities db = new Accounting_DBEntities();
                    GenericRepository<DataLayer.Accounting> accounting = new GenericRepository<DataLayer.Accounting>(db);
                    int id = int.Parse(DgReport.CurrentRow.Cells[0].Value.ToString());
                    accounting.Delete(id);
                    accounting.Save();
                    Refresh();
                }
                
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void EditReportBtn_Click(object sender, EventArgs e)
        {
            NewPayment newpayment = new NewPayment();
            if(DgReport.CurrentRow != null)
            {
                newpayment.create_or_edit = int.Parse(DgReport.CurrentRow.Cells[0].Value.ToString());
                if (newpayment.ShowDialog() == DialogResult.OK)
                {
                    Refresh();
                    MessageBox.Show("ویرایش با موفقیت انجام شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("لطفا تراکنش مورد نظر خود را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            DataTable data_table = new DataTable();
            data_table.Columns.Add("CustomerId");
            data_table.Columns.Add("FullName");
            data_table.Columns.Add("Amount");
            data_table.Columns.Add("DateTime");
            if(report_type == 1)
            {
                data_table.Columns.Add("SumAmountRecive");
                data_table.Columns.Add("SumAmountPay");
            }
            else
            {
                data_table.Columns.Add("SumAmountPay");
                data_table.Columns.Add("SumAmountRecive");
            }
            int sum_recive_or_pay = 0;
            foreach (DataGridViewRow row in DgReport.Rows)
            {
                sum_recive_or_pay += (Convert.ToInt32(row.Cells[3].Value.ToString()));
                data_table.Rows.Add(
                       row.Cells[1].Value.ToString(),
                       row.Cells[2].Value.ToString(),
                       row.Cells[3].Value.ToString(),
                       row.Cells[4].Value.ToString(),
                       sum_recive_or_pay,
                       "---"

                    );
            }
            StiReport.Load(Application.StartupPath + "/Report.mrt");
            StiReport.RegData("DT", data_table);
            StiReport.Show();
        }
    }
}
