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
using System.Data.Common;

namespace MyPos.ListForms
{
    public partial class frmListCategory : DevExpress.XtraEditors.XtraForm
    {
        ProductModel model = new ProductModel();

        public frmListCategory()
        {
            InitializeComponent();
        }

        private void gcCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                DbHelper.UpdateDatasource(gcCategory, categoriesTableAdapter.Adapter, khh_posDataSet.Tables["Categories"]);
            }
        }

        private void frmListCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khh_posDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.khh_posDataSet.Categories);
        }

        private void gvCategory_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.png|*.jpg|*.jpeg";
            openFileDialog1.Title = "Chọn hình ảnh";
            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowDialog();

            string imageUrl = openFileDialog1.FileName;

            DataRow dr = gvCategory.GetFocusedDataRow();
            dr["ImageUrl"] = imageUrl;
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            openFileDialog1.Filter = "PNG|*.png|JPG|*.jpg|JPEG|*.jpeg";
            openFileDialog1.Title = "Chọn hình ảnh";
            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowDialog();

            string imageUrl = openFileDialog1.FileName;

            DataRow dr = gvCategory.GetFocusedDataRow();
            dr["ImageUrl"] = imageUrl;
        }
    }
}