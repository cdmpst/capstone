using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUP_Inventory_Management_System.UI
{
    public partial class DASHBOARD : Form
    {
        public DASHBOARD()
        {
            InitializeComponent();
            SidePanel.Height = button_StockMonitoring.Height;
            SidePanel.Top = button_StockMonitoring.Top;
        }

        private void button_StockMonitoring_Click(object sender, EventArgs e)
        {
            uC_StockMonitoring1.BringToFront();
            SidePanel.Height = button_StockMonitoring.Height;
            SidePanel.Top = button_StockMonitoring.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_Borrowing_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button_Borrowing.Height;
            SidePanel.Top = button_Borrowing.Top;
        }

        private void button_Scheduling_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button_Scheduling.Height;
            SidePanel.Top = button_Scheduling.Top;
        }

        private void button_Reports_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button_Reports.Height;
            SidePanel.Top = button_Reports.Top;
        }
    }
}
