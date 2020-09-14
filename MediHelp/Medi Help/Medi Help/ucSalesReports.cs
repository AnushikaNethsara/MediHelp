using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;

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
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();

            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,10),
                        new ObservablePoint(4,7),
                        new ObservablePoint(5,3),
                        new ObservablePoint(7,6),
                        new ObservablePoint(10,8)
                    },
                    PointGeometrySize = 15
                },
                 new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,6),
                        new ObservablePoint(4,5),
                        new ObservablePoint(6,3),
                        new ObservablePoint(7,10),
                        new ObservablePoint(10,2)
                    },
                    PointGeometrySize = 15
                },
                  new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,8),
                        new ObservablePoint(2,2),
                        new ObservablePoint(5,3),
                        new ObservablePoint(7,3),
                        new ObservablePoint(9,8)
                    },
                    PointGeometrySize = 15
                },
            };


        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
