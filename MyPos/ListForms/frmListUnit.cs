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

namespace MyPos.ListForms
{
    public partial class frmListUnit : DevExpress.XtraEditors.XtraForm
    {
        ProductModel model = new ProductModel();

        public frmListUnit()
        {
            InitializeComponent();
            gcList.DataSource = model.Categories.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.SaveChanges();
            gcList.DataSource = model.Categories.ToList();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            model.Categories.Add(new Category() { });
            model.SaveChanges();
            gcList.DataSource = model.Categories.ToList();
        }

        private void gvList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                btnAddNew_Click(null, null);
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnSave_Click(null, null);
                MessageBox.Show("Đã lưu thành công!");
            }
        }

        private void gcList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                btnAddNew_Click(null, null);
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnSave_Click(null, null);
                MessageBox.Show("Đã lưu thành công!");
            }
        }
    }
}