using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PUP_Inventory_Management_System
{
    class LoginDAL
    {
        static string connstring = ConfigurationManager.ConnectionStrings["PUP_Inventory_Management_System.Properties.Settings.Setting"].ConnectionString;
        SqlConnection conn = new SqlConnection(connstring);
        public bool logCheck(LoginBLL z)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(connstring);

            try
            {
                string sql = "SELECT * FROM Table_Login WHERE Employee_Number =@employee_number AND Username=@username AND Password=@password";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Employee_Number", z.employee_number);
                cmd.Parameters.AddWithValue("@Username", z.username);
                cmd.Parameters.AddWithValue("@Password", z.password);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
