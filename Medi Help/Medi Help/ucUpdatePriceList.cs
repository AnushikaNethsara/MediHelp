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

namespace Medi_Help
{
    public partial class ucUpdatePriceList : UserControl
    {
        private static ucUpdatePriceList _instance;
        public static ucUpdatePriceList Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucUpdatePriceList();
                return _instance;
            }
        }
        public ucUpdatePriceList()
        {
            InitializeComponent();
        }

        private void ucEmployees_Load(object sender, EventArgs e)
        {
            displayPriceList();
            txtName.ReadOnly = true;
        }
        private void clear()
        {
            txtName.Text = "";
            txtPrice.Text = "";
        }


        private void displayPriceList()
        {
            DBconnection connection5 = new DBconnection();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(connection5.diplayPriceList());
            da.Fill(dt);
            dataGrid.DataSource = dt;
            connection5.getConnection().Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtName.Text;
                double price = Convert.ToDouble(txtPrice.Text);

                DBconnection ob = new DBconnection();
                ob.updatePriceList(name,price);
                clear();
                displayPriceList();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Error Update! \n"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];

                txtName.Text = row.Cells["ReportName"].Value.ToString();

                txtPrice.Text = row.Cells["Price"].Value.ToString();


            }
        }
    }
}
