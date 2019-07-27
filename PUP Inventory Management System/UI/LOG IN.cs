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

        static string connstring = ConfigurationManager.ConnectionStrings["PUP_Inventory_Management_System.Properties.Settings.Setting"].ConnectionString;
        SqlConnection conn = new SqlConnection(connstring);
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
            z.employee_number = textBox_EmployeeNumber.Text;
            z.username = textBox_Username.Text;
            z.password = textBox_Password.Text;

            bool success = dal.logCheck(z);
            if (success == true)
            {
                LoggedUser = textBox_Username.Text;
                LoggedUserID = textBox_EmployeeNumber.Text;

                this.Visible = false;

                DASHBOARD homepage = new DASHBOARD();
                homepage.Show();
            }
            else
            {
                MessageBox.Show("Please check your login details then try again.", "Log In Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void button_Login_Click(object sender, EventArgs e)
        {
            Validate_Login();
        }

        private void textBox_EmployeeNumber_Click(object sender, EventArgs e)
        {
            if (textBox_EmployeeNumber.Text == "")
            {
                label_employeenumber.Visible = false;
            }
            else if (textBox_EmployeeNumber.Text.Length > 0)
            {
                label_employeenumber.Visible = false;
            }
            else
            {
                label_employeenumber.Visible = true;
            }
        }

        private void textBox_EmployeeNumber_Leave(object sender, EventArgs e)
        {
            if (textBox_EmployeeNumber.Text == "")
            {
                label_employeenumber.Visible = true;
            }
            else if (textBox_EmployeeNumber.Text.Length > 0)
            {
                label_employeenumber.Visible = false;
            }
        }

        private void textBox_Username_Click(object sender, EventArgs e)
        {
            if (textBox_Username.Text == "")
            {
                label_username.Visible = false;
            }
            else if (textBox_Username.Text.Length > 0)
            {
                label_username.Visible = false;
            }
            else
            {
                label_username.Visible = true;
            }
        }

        private void textBox_Username_Leave(object sender, EventArgs e)
        {
            if (textBox_Username.Text == "")
            {
                label_username.Visible = true;
            }
            else if (textBox_Username.Text.Length > 0)
            {
                label_username.Visible = false;
            }
        }

        private void textBox_Password_Click(object sender, EventArgs e)
        {
            if (textBox_Password.Text == "")
            {
                label_password.Visible = false;
            }
            else if (textBox_Password.Text.Length > 0)
            {
                label_password.Visible = false;
            }
            else
            {
                label_password.Visible = true;
            }
        }

        private void textBox_Password_Leave(object sender, EventArgs e)
        {
            if (textBox_Password.Text == "")
            {
                label_password.Visible = true;
            }
            else if (textBox_Password.Text.Length > 0)
            {
                label_password.Visible = false;
            }
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            textBox_Password.UseSystemPasswordChar = true;
        }

        private void textBox_EmployeeNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox_EmployeeNumber_TextChanged(object sender, EventArgs e)
        {
            if (textBox_EmployeeNumber.Text == "")
            {
                label_employeenumber.Visible = false;
            }
            else if (textBox_EmployeeNumber.Text.Length > 0)
            {
                label_employeenumber.Visible = false;
            }
            else
            {
                label_employeenumber.Visible = true;
            }
        }

        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Username.Text == "")
            {
                label_username.Visible = false;
            }
            else if (textBox_Username.Text.Length > 0)
            {
                label_username.Visible = false;
            }
            else
            {
                label_username.Visible = true;
            }
        }
    }
}
