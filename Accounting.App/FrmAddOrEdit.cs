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
using Accounting.DataLayer;
using System.IO;

namespace Accounting.App
{
    public partial class FrmAddOrEdit : Form
    {
        private int _add_or_edit = 0;
        public FrmAddOrEdit()
        {
            InitializeComponent();
        }
        public int add_or_edit { set
            {
                if (value == 0) 
                {
                    _add_or_edit = 0;
                }
                else
                {
                    _add_or_edit = value;
                }
            } 
        }
        private void FrmAddOrEdit_Load(object sender, EventArgs e)
        {
            if(_add_or_edit == 0)
            {
                this.Text = "افزودن شخص";
                this.BtnSubmit.Text = "ثبت شخص";


            }
            else
            {
                using(UnitOfWork db = new UnitOfWork())
                {
                    var a = PictureBox.Image.ToString();
                    var selected_user = db.CustomerRepository.GetCustomerById(_add_or_edit);
                    string user_image_path = Application.StartupPath + "/Images/" + selected_user.CustomerImage.ToString();
                    Text = "ویرایش شخص";
                    BtnSubmit.Text = "ثبت ویرایش";
                    TextBoxFullName.Text = selected_user.FullName.ToString();
                    TextBoxMobile.Text = selected_user.Mobile.ToString();
                    TextBoxEmail.Text = selected_user.Email.ToString();
                    TextBoxAdress.Text = selected_user.Adress.ToString();
                    if (File.Exists(user_image_path))
                    {
                    PictureBox.ImageLocation = user_image_path;
                    }
                }
            }
        }

        private void BtnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                PictureBox.ImageLocation = openfile.FileName;
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (TextBoxFullName.Text != "" && TextBoxMobile.Text != "" && TextBoxEmail.Text != "" && TextBoxAdress.Text != "")
            {
                if(_add_or_edit == 0)
                {
                    try
                    {
                        string image_name_guid = Guid.NewGuid().ToString() + Path.GetExtension(PictureBox.ImageLocation);
                        string path = Application.StartupPath + "/Images/";
                        using (UnitOfWork db = new UnitOfWork())
                        {
                            if (!Directory.Exists(path))
                            {
                                Directory.CreateDirectory(path);
                            }
                            PictureBox.Image.Save(path + image_name_guid);
                            Customers customer = new Customers()
                            {
                                FullName = this.TextBoxFullName.Text,
                                Mobile = this.TextBoxMobile.Text,
                                Email = this.TextBoxEmail.Text,
                                Adress = this.TextBoxAdress.Text,
                                CustomerImage = image_name_guid
                            };
                            db.CustomerRepository.InsertCustomer(customer);
                            db.Save();
                            DialogResult = DialogResult.OK;
                            MessageBox.Show("شخص موردنظر با موفقیت ذخیره شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("خطایی هنگام ذخیره رخ داد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var selected_user = db.CustomerRepository.GetCustomerById(_add_or_edit);
                        string image_name_guid = Guid.NewGuid().ToString() + Path.GetExtension(PictureBox.ImageLocation);
                        string path = Application.StartupPath + "/Images/";

                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        if (File.Exists(path + selected_user.CustomerImage))
                        {
                            File.Delete(path + selected_user.CustomerImage);
                        }

                        selected_user.FullName = TextBoxFullName.Text;
                        selected_user.Mobile = TextBoxMobile.Text;
                        selected_user.Email = TextBoxEmail.Text;
                        selected_user.Adress = TextBoxAdress.Text;
                        selected_user.CustomerImage = image_name_guid;

                        PictureBox.Image.Save(path + image_name_guid);
                        db.CustomerRepository.UpdateCustomer(selected_user);
                        db.Save();
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("ورودی های خواسته شده را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
