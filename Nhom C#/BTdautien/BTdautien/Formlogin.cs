using BTdautien.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTdautien
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }
        userQ user;

        private void Formlogin_Load(object sender, EventArgs e)
        {

        }
        private void FrmLogin_Click(object sender, EventArgs e)
       {
if(!string.IsNullOrEmpty(txtUsername.Text))
{
    if(!string.IsNullOrEmpty(txtPassword.Text))
    {
        user = new userQ();
       if( KiemTraDangNhap(txtUsername.Text, txtPassword.Text));
       {
           this.Close();
       }
    }
}
        }
        private bool KiemTraDangNhap(String UserName,String Password)
        {
            if (user.user.UserName.Equals(UserName)&&user.user.PassWord.Equals(Password))
            {
                return true;
            }
            return false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
