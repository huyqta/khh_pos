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
using MyPos.Helper;

namespace MyPos.ListForms
{
    public partial class frmListCompany : DevExpress.XtraEditors.XtraForm
    {
        ProductModel model = new ProductModel();

        public frmListCompany()
        {
            InitializeComponent();
        }

        private void gcList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                DbHelper.UpdateDatasource(gcList, customersTableAdapter.Adapter, khh_posDataSet.Tables["Customers"]);
            }
        }

        private void frmListUnit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khh_posDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.khh_posDataSet.Customers);

        }
    }
}