using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using PUP_Inventory_Management_System.UI;

namespace PUP_Inventory_Management_System
{
    public partial class LOG_IN : Form
    {
        LoginBLL z = new LoginBLL();
        LoginDAL dal = new LoginDAL();

        public LOG_IN()
        {
            InitializeComponent();
        }

        private void LOG_IN_Load(object sender, EventArgs e)
        {

        }

        public static string LoggedUser;
        public static string LoggedUserID;
        private void Validate_Login()
        {
            z.employee_number = textBoxEmployeeNumber.Text;
            z.username = textBoxUsername.Text;
            z.password = textBoxPassword.Text;

            bool success = dal.logCheck(z);
            if (success == true)
            {
                LoggedUser = textBoxUsername.Text;
                LoggedUserID = textBoxEmployeeNumber.Text;

                this.Visible = false;

                DASHBOARD homepage = new DASHBOARD();
                homepage.Show();
            }
            else
            {
                MessageBox.Show("Please check your login details then try again.", "Log In Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Validate_Login();
        }

        private void textBox_EmployeeNumber_Click(object sender, EventArgs e)
        {
            if (textBoxEmployeeNumber.Text == "")
            {
                labelEmployeeNumber.Visible = false;
            }
            else if (textBoxEmployeeNumber.Text.Length > 0)
            {
                labelEmployeeNumber.Visible = false;
            }
            else
            {
                labelEmployeeNumber.Visible = true;
            }
        }

        private void textBoxEmployeeNumber_Leave(object sender, EventArgs e)
        {
            if (textBoxEmployeeNumber.Text == "")
            {
                labelEmployeeNumber.Visible = true;
            }
            else if (textBoxEmployeeNumber.Text.Length > 0)
            {
                labelEmployeeNumber.Visible = false;
            }
        }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                labelUsername.Visible = false;
            }
            else if (textBoxUsername.Text.Length > 0)
            {
                labelUsername.Visible = false;
            }
            else
            {
                labelUsername.Visible = true;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                labelUsername.Visible = true;
            }
            else if (textBoxUsername.Text.Length > 0)
            {
                labelUsername.Visible = false;
            }
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                labelPassword.Visible = false;
            }
            else if (textBoxPassword.Text.Length > 0)
            {
                labelPassword.Visible = false;
            }
            else
            {
                labelPassword.Visible = true;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                labelPassword.Visible = true;
            }
            else if (textBoxPassword.Text.Length > 0)
            {
                labelPassword.Visible = false;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void textBoxEmployeeNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxEmployeeNumber_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEmployeeNumber.Text == "")
            {
                labelEmployeeNumber.Visible = false;
            }
            else if (textBoxEmployeeNumber.Text.Length > 0)
            {
                labelEmployeeNumber.Visible = false;
            }
            else
            {
                labelEmployeeNumber.Visible = true;
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                labelUsername.Visible = false;
            }
            else if (textBoxUsername.Text.Length > 0)
            {
                labelUsername.Visible = false;
            }
            else
            {
                labelUsername.Visible = true;
            }
        }
    }
}
