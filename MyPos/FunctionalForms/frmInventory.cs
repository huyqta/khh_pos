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
    public partial class frmInventory : DevExpress.XtraEditors.XtraForm
    {
        ProductModel model = new ProductModel();

        public frmInventory()
        {
            InitializeComponent();
            gcInventory.DataSource = model.Inventories.ToList();
        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            List<Product> products = model.Products.Where(p => p.isCheckInventory == true).ToList();
            foreach (var product in products)
            {
                if (!model.Inventories.Any(o=>o.ProductId == product.Id))
                {
                    model.Inventories.Add(new Inventory()
                    {
                        Id = Guid.NewGuid(),
                        ProductId = product.Id,
                        ProductName = product.Name,
                        Quantity = 0,
                        UnitId = product.UnitId,
                        MinQuantity = 0
                    });
                }
            }
            model.SaveChanges();

            gcInventory.DataSource = model.Inventories.ToList();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khh_posDataSet.Units' table. You can move, or remove it, as needed.
            this.unitsTableAdapter.Fill(this.khh_posDataSet.Units);
            // TODO: This line of code loads data into the 'khh_posDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.khh_posDataSet.Products);

        }

        private void gcInventory_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                model.SaveChanges();
                MessageBox.Show("Cập nhật thành công!");
            }
        }

        private void chkShowRedItemOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowRedItemOnly.Checked)
            {
                gcInventory.DataSource = ListProductUnderMinimumQuantity();
            }
            else
            {
                gcInventory.DataSource = model.Inventories.ToList();
            }
        }

        private List<Inventory> ListProductUnderMinimumQuantity()
        {
            return model.Inventories.Where(o => o.MinQuantity >= o.Quantity).ToList();
        }

        private void gvInventory_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            Inventory inv = (Inventory)gvInventory.GetRow(e.RowHandle);
            if (inv != null && (inv.MinQuantity >= inv.Quantity))
            {
                e.Appearance.BackColor = Color.LightPink;
                e.Appearance.ForeColor = Color.DarkRed;
            }
        }
    }
}