using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.Context;
using System.IO;
using Accounting.DataLayer.Services;
using Accounting.DataLayer;
namespace Accounting.App

{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }
        void LoadDataToGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                DgCustomers.AutoGenerateColumns = false;
                DgCustomers.DataSource = db.CustomerRepository.GetAllCustomers();
            }
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }

        private void BtnRefreshFrmCustomers_Click(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }

        private void BtnDeleteFrmCustomers_Click(object sender, EventArgs e)
        {   
            if(MessageBox.Show("آیا از حذف سطر انتخاب شده مطمعن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        string path = Application.StartupPath + "/Images/";
                        var customer = db.CustomerRepository.GetCustomerById(int.Parse(DgCustomers.CurrentRow.Cells[0].Value.ToString()));
                        if(File.Exists(path + customer.CustomerImage))
                        {
                            File.Delete(path + customer.CustomerImage);
                        }
                        db.CustomerRepository.DeleteCustomer(customer);
                        db.Save();
                        LoadDataToGrid();
                        MessageBox.Show("سطر مورد نظر با موفقیت حذف شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("خطایی در هنگام حذف رخ داد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
 
            }
            
        }

        private void BtnEditFrmCustomers_Click(object sender, EventArgs e)
        {
            FrmAddOrEdit frmAddOrEdit = new FrmAddOrEdit();
            frmAddOrEdit.add_or_edit = int.Parse(DgCustomers.CurrentRow.Cells[0].Value.ToString());
            if(frmAddOrEdit.ShowDialog() == DialogResult.OK)
            {
                LoadDataToGrid();
            }
            
        }

        private void BtnAddFrmCustomers_Click(object sender, EventArgs e)
        {
            FrmAddOrEdit frmAddOrEdit = new FrmAddOrEdit();
            frmAddOrEdit.add_or_edit = 0;
            if (frmAddOrEdit.ShowDialog() == DialogResult.OK)
            {
                LoadDataToGrid();
            }
        }

        private void SearchBoxFrmCustomers_TextChanged(object sender, EventArgs e)
        {
            using (Accounting_DBEntities db = new Accounting_DBEntities())
            {
                GenericRepository<Customers> customers = new GenericRepository<Customers>(db);
                IEnumerable<Customers> filtred_users =  customers.Get(c => c.FullName.Contains(SearchBoxFrmCustomers.Text) || c.Email.Contains(SearchBoxFrmCustomers.Text) || c.Mobile.Contains(SearchBoxFrmCustomers.Text));
                DgCustomers.DataSource = filtred_users.ToList();

            }
        }
    }
}
