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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string user_name = UserNameBox.Text;
            string password = PasswordBox.Text;
            Accounting_DBEntities db = new Accounting_DBEntities();
            GenericRepository<Users> users = new GenericRepository<Users>(db);
            bool any_user = users.Get(c => c.UserName == user_name && c.Password == password).Any();
            if (user_name != "" && password != "")
            {
                if (any_user)
                {
                    DialogResult=DialogResult.OK;
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("نام کاربری و یا رمز عبور اشتباه است", "کاربر یافت نشد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("لطفا نام کاربری و رمز عبور خود را وارد کنید", "خطای کاربر", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        { 

        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changepasswordform = new ChangePasswordForm();
            Accounting_DBEntities db = new Accounting_DBEntities();
            GenericRepository<Users> user = new GenericRepository<Users>(db);
            bool my_user = user.Get(c => c.UserName == UserNameBox.Text && c.Password == PasswordBox.Text).Any();
            if(UserNameBox.Text != "" && PasswordBox.Text != "")
            {
                if (my_user)
                {
                    changepasswordform.current_password = PasswordBox.Text;
                    changepasswordform.ShowDialog();
                }
                else
                {
                    MessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "خطای کاربر", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("لطفا نام کاربری و رمز عبور خود را وارد کنید", "خطای کاربر", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
