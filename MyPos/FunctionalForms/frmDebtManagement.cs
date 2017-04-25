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

namespace MyPos.FunctionalForms
{
    public partial class frmDebtManagement : DevExpress.XtraEditors.XtraForm
    {
        ProductModel model = new ProductModel();

        public frmDebtManagement()
        {
            InitializeComponent();
        }

        private void frmDebtManagement_Load(object sender, EventArgs e)
        {
            gcCustomer.DataSource = model.DebtManagements.Where(d => d.DebtAmount > 0 && d.IsVendor == false).ToList();

        }
    }
}