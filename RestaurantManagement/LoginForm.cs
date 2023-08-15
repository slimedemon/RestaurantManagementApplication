using CafeManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        #region method

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
        #endregion

        #region event
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // check username and password, character is a->z, A -> Z, 0 -> 9
            // => No sql injection
            if (!checkUsernameAndPassword(txtUsername.Text) || !checkUsernameAndPassword(txtPass.Text))
            {
                MessageBox.Show("username và password chỉ chứa các chữ cái thường, hoa và các chữ số từ 0 -> 9. Lưu ý: Số ký tự tối đa là 100");
                return;
            }

            // check valid username and password
            using (RestaurantManagementDBEntities db = new RestaurantManagementDBEntities())
            {
                byte[] temp = ASCIIEncoding.ASCII.GetBytes(txtPass.Text);
                byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
                string hasPass = "";
                foreach (byte item in hasData)
                {
                    hasPass += item;
                }

                Account acc = db.Accounts.Where(p => p.username == txtUsername.Text && p.password == hasPass).SingleOrDefault();

                if (acc == null)
                {
                    MessageBox.Show("Login không thành công!!!");
                    return;
                }

                this.Tag = acc;
                this.Hide();
                TableManagementForm table = new TableManagementForm();
                table.Tag = acc;
                table.ShowDialog();
                this.Show();
            }
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
