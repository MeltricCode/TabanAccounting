using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer;
using Accounting.DataLayer.Services;
using Accounting.DataLayer.Context;


namespace Accounting.App
{
    
    public partial class NewPayment : Form
    {
        public int create_or_edit;
        UnitOfWork customers = new UnitOfWork();
        public NewPayment()
        {

            InitializeComponent();
        }
        public void reload_dg()
        {
            DgPayment.DataSource = customers.CustomerRepository.GetAllCustomers();
            BoxName.Text = DgPayment.CurrentRow.Cells[1].Value.ToString();
        }
        private void NewPayment_Load(object sender, EventArgs e)
        {   

            DgPayment.AutoGenerateColumns = false;
            if (create_or_edit == 0)
            {
                reload_dg();
                this.Text = "ثبت سند";
            }
            else
            {
                this.Text = "ویرایش سند";
                Accounting_DBEntities db = new Accounting_DBEntities();
                GenericRepository<DataLayer.Accounting> accounting = new GenericRepository<DataLayer.Accounting>(db);

                var payment = accounting.GetById(create_or_edit);
                var payment_user = db.Customers.Find(payment.CustomerId);
                DgPayment.Rows.Add(payment_user.CustomerID, payment_user.FullName);
                BoxName.Text = DgPayment.CurrentRow.Cells[1].Value.ToString();
                if(payment.TypeId == 1)
                {
                    ReciveRadio.Checked = true;
                }
                else
                {
                    PayRadio.Checked = true;
                }
                AmountBox.Value = payment.Amount;
                DescriptionBox.Text = payment.Description;

            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchBoxPayment_TextChanged(object sender, EventArgs e)
        {
            DgPayment.DataSource = customers.CustomerRepository.GetNameCustomers(SearchBoxPayment.Text);
        }

        private void DgPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BoxName.Text = DgPayment.CurrentRow.Cells[1].Value.ToString();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if(create_or_edit == 0)
            {
                if (DgPayment.SelectedRows != null)
                {
                    if (PayRadio.Checked || ReciveRadio.Checked)
                    {
                        if (this.AmountBox.Value == 0)
                        {
                            MessageBox.Show("لطفا مبلغ را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            Accounting_DBEntities db = new Accounting_DBEntities();
                            GenericRepository<Accounting.DataLayer.Accounting> paymentrepository = new GenericRepository<DataLayer.Accounting>(db);
                            int payment_type;
                            if (PayRadio.Checked)
                            {
                                payment_type = 0;
                            }
                            else
                            {
                                payment_type = 1;
                            }
                            DataLayer.Accounting user_payment = new DataLayer.Accounting()
                            {
                                TypeId = payment_type,
                                Amount = int.Parse(AmountBox.Value.ToString()),
                                CustomerId = int.Parse(DgPayment.CurrentRow.Cells[0].Value.ToString()),
                                DateTime = DateTime.Now,
                                Description = DescriptionBox.Text

                            };
                            paymentrepository.Insert(user_payment);
                            paymentrepository.Save();

                            MessageBox.Show("سند با موفقیت ذیره شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        MessageBox.Show("لطفا نوع تراکنش را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    MessageBox.Show("لطفا طرف حساب را اتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                Accounting_DBEntities db = new Accounting_DBEntities();
                GenericRepository<DataLayer.Accounting> accounting = new GenericRepository<DataLayer.Accounting>(db);
                var payment = accounting.GetById(create_or_edit);
                payment.TypeId = (ReciveRadio.Checked) ? 1 : 2;
                payment.Amount = int.Parse(AmountBox.Value.ToString());
                payment.Description = DescriptionBox.Text;
                accounting.Update(payment);
                accounting.Save();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
