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

namespace Accounting.App
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }
        public string current_password = "";
        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            if(current_password != "")
            {
                CurrentPasswordBox.Text = current_password;
            }
        }

        private void ChangePassBtn_Click(object sender, EventArgs e)
        {
            if(CurrentPasswordBox.Text != "" && NewPasswordBox.Text != "")
            {
                Accounting_DBEntities db = new Accounting_DBEntities();
                GenericRepository<Users> user = new GenericRepository<Users>(db);
                Users app_user =user.Get(c => c.Password == CurrentPasswordBox.Text).FirstOrDefault();
                if(app_user != null)
                {
                    if(app_user.Password.ToString() == CurrentPasswordBox.Text.ToString())
                    {
                        app_user.Password = NewPasswordBox.Text;
                        user.Update(app_user);
                        user.Save();
                        this.Close();
                        MessageBox.Show("رمز عبور شما با موفقیت تغییر کرد", "عملیات موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("رمز عبور فعلی اشتباه است", "خطای کاربر", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
                else
                {
                    MessageBox.Show("رمز عبور فعلی اشتباه است", "خطای کاربر", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("لطفا تمامی اطلاعات خواسته ده را وارد کنید", "خطای کاربر", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
