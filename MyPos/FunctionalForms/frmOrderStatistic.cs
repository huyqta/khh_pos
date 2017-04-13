using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessEntity;
using System.Data.Entity;

namespace MyPos.FunctionalForms
{
    public partial class frmOrderStatistic : DevExpress.XtraEditors.XtraForm
    {
        ProductModel model = new ProductModel();

        public frmOrderStatistic()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dtFrom.DateTime != null && dtTo.DateTime != null)
            {
                gcOrderList.DataSource = model.Orders.Where(o => DbFunctions.TruncateTime(o.OrderDateTime) >= dtFrom.DateTime && DbFunctions.TruncateTime(o.OrderDateTime) < dtTo.DateTime).ToList();
            }
            else
            {
                MessageBox.Show("Chọn từ ngày, đến ngày đi em!!!!");
            }
        }

        private void frmOrderStatistic_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khh_posDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.khh_posDataSet.Orders);
            // TODO: This line of code loads data into the 'khh_posDataSet.Customers' table. You can move, or remove it, as needed.
            this.orderDetailsTableAdapter.Fill(this.khh_posDataSet.OrderDetails);

            dtTo.DateTime = DateTime.Now.Date;
            dtFrom.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            // TODO: This line of code loads data into the 'khh_posDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.khh_posDataSet.Customers);

        }
    }
}