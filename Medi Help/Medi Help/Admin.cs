using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medi_Help
{
    public partial class Admin : Form
    {
        private static Admin _instance;
        public static Admin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Admin();
                return _instance;
            }
        }
        public Admin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!panelAdmin.Controls.Contains(ucDailyCahReports.Instance))
            {
                panelAdmin.Controls.Add(ucDailyCahReports.Instance);
                ucDailyCahReports.Instance.Dock = DockStyle.Fill;
                ucDailyCahReports.Instance.BringToFront();
            }
            else
            {
                ucDailyCahReports.Instance.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panelAdmin.Controls.Contains(ucUser.Instance))
            {
                panelAdmin.Controls.Add(ucUser.Instance);
                ucUser.Instance.Dock = DockStyle.Fill;
                ucUser.Instance.BringToFront();
            }
            else
            {
                ucUser.Instance.BringToFront();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!panelAdmin.Controls.Contains(ucSalesReports.Instance))
            {
                panelAdmin.Controls.Add(ucSalesReports.Instance);
                ucSalesReports.Instance.Dock = DockStyle.Fill;
                ucSalesReports.Instance.BringToFront();
            }
            else
            {
                ucSalesReports.Instance.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panelAdmin.Controls.Contains(ucPatientsReports.Instance))
            {
                panelAdmin.Controls.Add(ucPatientsReports.Instance);
                ucPatientsReports.Instance.Dock = DockStyle.Fill;
                ucPatientsReports.Instance.BringToFront();
            }
            else
            {
                ucPatientsReports.Instance.BringToFront();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!panelAdmin.Controls.Contains(ucUpdatePriceList.Instance))
            {
                panelAdmin.Controls.Add(ucUpdatePriceList.Instance);
                ucUpdatePriceList.Instance.Dock = DockStyle.Fill;
                ucUpdatePriceList.Instance.BringToFront();
            }
            else
            {
                ucUpdatePriceList.Instance.BringToFront();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!panelAdmin.Controls.Contains(ucViewEmployeeDetails.Instance))
            {
                panelAdmin.Controls.Add(ucViewEmployeeDetails.Instance);
                ucViewEmployeeDetails.Instance.Dock = DockStyle.Fill;
                ucViewEmployeeDetails.Instance.BringToFront();
            }
            else
            {
                ucViewEmployeeDetails.Instance.BringToFront();
            }
        }
    }
}
