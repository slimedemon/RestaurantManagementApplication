using RestaurantManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class AccountForm : Form
    {
        public AccountForm(Account acc)
        {
            InitializeComponent();
            this.CenterToScreen();
            txtUsername.Text = acc.username;
        }

        #region Method
        private bool checkUsernameAndPassword(string token)
        {
            if (token.Length > 100) return false;

            foreach (var e in token)
            {
                if (e >= 'a' && e <= 'z' || e >= 'A' && e <= 'Z' || e >= '0' && e <= '9') continue;
                else return false;
            }

            return true;
        }

        private string getHashPassword(string pass)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(txtOldPass.Text);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }

            return hasPass;
        }

        private void changePassword()
        {
            using (RestaurantManagementDBEntities db = new RestaurantManagementDBEntities())
            {
                if (checkUsernameAndPassword(txtUsername.Text) && checkUsernameAndPassword(txtNewPass.Text) && checkUsernameAndPassword(txtNewPass.Text) && checkUsernameAndPassword(txtConfirmPass.Text))
                {
                   

                    Account acc = db.Accounts.Where(p => p.username == txtUsername.Text && p.password == getHashPassword(txtOldPass.Text)).SingleOrDefault();

                    if (acc != null && txtNewPass.Text == txtConfirmPass.Text && txtNewPass.Text != "")
                    {

                        acc.password = getHashPassword(txtNewPass.Text);
                        db.SaveChanges();
                        MessageBox.Show("Thay đổi mật khẩu thành công!!!");
                    }
                    else
                    {
                        MessageBox.Show("Bị lỗi, không thay đổi mật khẩu thành công!!!");
                    }
                }

                txtNewPass.Text = txtConfirmPass.Text = txtOldPass.Text = "";
            }
        }
        #endregion

        #region Event
        private void btnSave_Click(object sender, EventArgs e)
        {
            changePassword();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
