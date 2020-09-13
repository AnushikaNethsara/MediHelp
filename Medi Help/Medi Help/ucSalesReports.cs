using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medi_Help
{
    public partial class ucSalesReports : UserControl
    {
        private static ucSalesReports _instance;
        public static ucSalesReports Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSalesReports();
                return _instance;
            }
        }
        public ucSalesReports()
        {
            InitializeComponent();
        }

        private void ucSales_Load(object sender, EventArgs e)
        {

        }
    }
}
