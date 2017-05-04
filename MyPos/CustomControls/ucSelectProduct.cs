using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessEntity;
using MyPos.Helper;

namespace MyPos.CustomControls
{
    public partial class ucSelectProduct : DevExpress.XtraEditors.XtraForm
    {
        private ProductModel model = new ProductModel();
        public List<Product> SelectedProducts { get; set; }
        private List<Product> listProducts = new List<Product>();

        public ucSelectProduct()
        {
            InitializeComponent();
            this.SelectedProducts = new List<Product>();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void ucSelectProduct_Load(object sender, EventArgs e)
        {
            gcCategory.DataSource = model.Categories.ToList();
            gvCategory.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Medium;
            gvCategory.ColumnSet.TextColumn = gvCategory.Columns["Name"];
            gvCategory.ColumnSet.MediumImageColumn = gvCategory.Columns["ImageBinary"];

            gvSelectedItem.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Medium;
            gvSelectedItem.ColumnSet.TextColumn = gvCategory.Columns["Name"];
            gvSelectedItem.ColumnSet.MediumImageColumn = gvCategory.Columns["ImageBinary"];
        }

        private void gvCategory_ItemClick(object sender, DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewItemClickEventArgs e)
        {
            Type selectedCat = e.ItemInfo.Row.RowKey.GetType();
            Category cr = e.ItemInfo.Row.RowKey as Category;
            listProducts = model.Products.Where(c => c.CategoryId == cr.Id).ToList();
            gcProduct.DataSource = listProducts;
            gvProducts.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Medium;
            gvProducts.ColumnSet.TextColumn = gvCategory.Columns["Name"];
            gvProducts.ColumnSet.MediumImageColumn = gvCategory.Columns["ImageBinary"];
        }

        private void gvProducts_ItemDoubleClick(object sender, DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewItemDoubleClickEventArgs e)
        {
            Type selectedCat = e.ItemInfo.Row.RowKey.GetType();
            Product pr = e.ItemInfo.Row.RowKey as Product;
            SelectedProducts.Add(pr);
            if (SelectedProducts.Count == 1)
            {
                gcSelectedItem.DataSource = SelectedProducts;
                //gvSelectedItem.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Medium;
                //gvSelectedItem.ColumnSet.TextColumn = gvCategory.Columns["Name"];
                //gvSelectedItem.ColumnSet.MediumImageColumn = gvCategory.Columns["ImageBinary"];
            }
            else
            {
                gcSelectedItem.RefreshDataSource();
            }

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            string a = UtilityHelper.ReplaceNonEnglishChars(textEdit1.Text.Trim());
            listProducts = model.Products.ToList().Where(l => UtilityHelper.ReplaceNonEnglishChars(l.Name.ToLower().Trim()).Contains(a.ToLower())).ToList();
            gcProduct.DataSource = listProducts;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvSelectedItem_ItemDoubleClick(object sender, DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewItemDoubleClickEventArgs e)
        {
            Type selectedCat = e.ItemInfo.Row.RowKey.GetType();
            Product pr = e.ItemInfo.Row.RowKey as Product;
            SelectedProducts.Remove(pr);
            gcSelectedItem.RefreshDataSource();
        }
    }
}
