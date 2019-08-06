using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PUP_Inventory_Management_System
{
    public partial class UC_StockMonitoring : UserControl
    {
        static string connstring = ConfigurationManager.ConnectionStrings["PUP_Inventory_Management_System.Properties.Settings.Setting"].ConnectionString;
        SqlConnection conn = new SqlConnection(connstring);

        public UC_StockMonitoring()
        {
            InitializeComponent();
        }

        private void button_Equipment_Click(object sender, EventArgs e)
        {
            panelEquipment.BringToFront();
        }

        private void button_Supplies_Click(object sender, EventArgs e)
        {
            panelSupplies.BringToFront();
        }

        private void rectangleShape13_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_DateAcquired_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
