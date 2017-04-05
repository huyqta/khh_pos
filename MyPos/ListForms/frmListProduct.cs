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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MyPos.Helper;

namespace MyPos.ListForms
{
    public partial class frmListProduct : DevExpress.XtraEditors.XtraForm
    {
        ProductModel model = new ProductModel();

        public frmListProduct()
        {
            InitializeComponent();
            LoadDataToLookUpCategory();
        }

        private void LoadDataToLookUpCategory()
        {
            lkuCategoryGrid.DataSource = model.Categories.ToList();
            lkuCategoryGrid.DisplayMember = "Name";
            lkuCategoryGrid.ValueMember = "Id";
            lkuCategoryGrid.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
        }

        private void gcList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                DbHelper.UpdateDatasource(gcList, productsTableAdapter.Adapter, khh_posDataSet.Tables["Products"]);
            }
        }

        private void gcList_ProcessGridKey(object sender, KeyEventArgs e)
        {
            var grid = sender as GridControl;
            var view = grid.FocusedView as GridView;
            if (e.KeyData == Keys.Delete)
            {
                view.DeleteSelectedRows();
                e.Handled = true;
            }
        }

        private void gvList_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gvList.GetDataRow(e.RowHandle);
            row["Name"] = "";
            row["DefaultPrice"] = 0;
            row["Description"] = "";
            row["CategoryId"] = 1;
        }

        private void frmListProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khh_posDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.khh_posDataSet.Products);

        }

        private void gvList_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            productsTableAdapter.Update(khh_posDataSet);
        }
    }
}