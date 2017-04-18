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
using System.Data.Entity;

namespace MyPos.FunctionalForms
{
    public partial class frmImport : DevExpress.XtraEditors.XtraForm
    {
        Import import;
        List<ImportDetail> importDetails = new List<ImportDetail>();
        ProductModel model = new ProductModel();

        public frmImport()
        {
            InitializeComponent();
            lblOrderCode.Text = string.Empty;
            dtSelectDateOrder.DateTime = DateTime.Now;
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khh_posDataSet.Imports' table. You can move, or remove it, as needed.
            this.importsTableAdapter.Fill(this.khh_posDataSet.Imports);
            // TODO: This line of code loads data into the 'khh_posDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.khh_posDataSet.Products);
            // TODO: This line of code loads data into the 'khh_posDataSet.Units' table. You can move, or remove it, as needed.
            this.unitsTableAdapter.Fill(this.khh_posDataSet.Units);
            // TODO: This line of code loads data into the 'khh_posDataSet.ImportDetails' table. You can move, or remove it, as needed.
            this.importDetailsTableAdapter.Fill(this.khh_posDataSet.ImportDetails);
            // TODO: This line of code loads data into the 'khh_posDataSet.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter.Fill(this.khh_posDataSet.Vendors);

            lookUpVendor.Properties.DataSource = model.Vendors.ToList();
            lookUpVendor.Properties.DisplayMember = "Name";
            lookUpVendor.Properties.ValueMember = "Id";
            lookUpVendor.Properties.PopulateColumns();
            for (int i = 0; i< lookUpVendor.Properties.Columns.Count; i++)
            {
                if (lookUpVendor.Properties.Columns[i].FieldName != "Name")
                {
                    lookUpVendor.Properties.Columns[i].Visible = false;
                }
            }

            lookUpProduct.Properties.DataSource = model.Products.Where(p=>p.isCheckInventory == true).ToList();
            lookUpProduct.Properties.DisplayMember = "Name";
            lookUpProduct.Properties.ValueMember = "Id";
            lookUpProduct.Properties.PopulateColumns();
            for (int i = 0; i < lookUpProduct.Properties.Columns.Count; i++)
            {
                if (lookUpProduct.Properties.Columns[i].FieldName != "Name")
                {
                    lookUpProduct.Properties.Columns[i].Visible = false;
                }
            }

            LoadOrders(DateTime.Now);
        }

        private void LoadOrders(DateTime datetimeOrder)
        {
            gcOrders.DataSource = model.Imports.Where(o => DbFunctions.TruncateTime(o.ImportDateTime) == datetimeOrder.Date).ToList();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (import == null)
            {
                btnNewOrder.PerformClick();
            }
            Product product = (Product)lookUpProduct.GetSelectedDataRow();
            if (importDetails.Any(i => i.ProductId == product.Id))
            {
                ImportDetail focusedOrderDetail = model.ImportDetails.Where(od => od.ProductId == product.Id && od.ImportId == import.Id).FirstOrDefault();
                focusedOrderDetail.Quantity++;
                focusedOrderDetail.TotalPrice = focusedOrderDetail.Quantity * focusedOrderDetail.UnitPrice;
                //import.TotalPrice = model.ImportDetails.Local.Where(od => od.ImportId == import.Id).Sum(od => od.TotalPrice);
            }
            else
            {
                ImportDetail importDetail = new ImportDetail();
                importDetail.Id = Guid.NewGuid();
                importDetail.ImportId = import.Id;
                importDetail.ProductId = product.Id;
                importDetail.Quantity = 0;
                importDetail.UnitId = product.UnitId;
                importDetail.UnitPrice = product.DefaultPrice;
                importDetail.TotalPrice = importDetail.Quantity * importDetail.UnitPrice;
                importDetails.Add(importDetail);
                model.ImportDetails.Add(importDetail);
            }
            import.TotalPrice = model.ImportDetails.Local.Where(od => od.ImportId == import.Id).Sum(od => od.TotalPrice);

            model.SaveChanges();
            gcOrderDetail.DataSource = model.ImportDetails.Where(od => od.ImportId == import.Id).ToList();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            Vendor vendor = null;
            if (lookUpVendor.GetSelectedDataRow() != null)
            {
                vendor = (Vendor)lookUpVendor.GetSelectedDataRow();
            }

            lblOrderCode.Text = DateTime.Now.ToString("ddMMyyyyHHmmss");
            import = new Import();
            import.Id = Guid.NewGuid();
            import.ImportCode = lblOrderCode.Text;
            import.ImportDateTime = DateTime.Now;
            import.TotalPrice = 0;
            import.VendorId = vendor == null ? -1 : vendor.Id;

            importDetails = new List<ImportDetail>();

            model.Imports.Add(import);

            gcOrderDetail.DataSource = model.ImportDetails.Local.Where(od => od.ImportId == import.Id).ToList();

            model.SaveChanges();
            rdSelectDateOrder_SelectedIndexChanged(null, null);
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            InventoryHelpers.UPDATE_INVENTORY(importDetails, InventoryHelpers.ActionType.Import);
            lblOrderCode.Text = string.Empty;
            import = new Import();
            model.SaveChanges();

            gcOrderDetail.DataSource = model.ImportDetails.Where(od => od.ImportId == import.Id).ToList();
            gcOrders.RefreshDataSource();
        }

        private void gvOrderDetail_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var selectedOrderDetail = gvOrderDetail.GetRow(gvOrderDetail.FocusedRowHandle) as ImportDetail;
            int productId = selectedOrderDetail.ProductId;
            Product product = model.Products.Where(p => p.Id == productId).FirstOrDefault();
            ImportDetail importDetail = model.ImportDetails.Where(od => od.ImportId == import.Id && od.ProductId == productId).FirstOrDefault();
            switch (e.Column.FieldName)
            {
                case "ProductId":
                    gvOrderDetail.SetFocusedRowCellValue(gvOrderDetail.Columns["CategoryId"], product.CategoryId);
                    importDetail.CategoryId = product.CategoryId;

                    gvOrderDetail.SetFocusedRowCellValue(gvOrderDetail.Columns["UnitId"], product.UnitId);
                    importDetail.UnitId = product.UnitId;

                    gvOrderDetail.SetFocusedRowCellValue(gvOrderDetail.Columns["UnitPrice"], product.DefaultPrice);
                    gvOrderDetail.SetFocusedRowCellValue(gvOrderDetail.Columns["Quantity"], 1);
                    gvOrderDetail.SetFocusedRowCellValue(gvOrderDetail.Columns["TotalPrice"], product.DefaultPrice);
                    break;
                case "Quantity":
                    if (model.ImportDetails.Local.Any(l => l.ProductId == product.Id))
                    {
                        ImportDetail focusedOrderDetail = model.ImportDetails.Local.Where(od => od.ProductId == product.Id && od.ImportId == import.Id).FirstOrDefault();
                        focusedOrderDetail.Quantity = double.Parse(e.Value.ToString());
                        focusedOrderDetail.TotalPrice = focusedOrderDetail.Quantity * focusedOrderDetail.UnitPrice;
                        model.SaveChanges();
                        import.TotalPrice = model.ImportDetails.Local.Where(od => od.ImportId == import.Id).Sum(od => od.TotalPrice);
                    }
                    model.SaveChanges();
                    gcOrderDetail.DataSource = model.ImportDetails.Where(od => od.ImportId == import.Id).ToList();
                    gcOrders.RefreshDataSource();
                    break;
                case "UnitPrice":
                    if (model.ImportDetails.Local.Any(l => l.ProductId == product.Id))
                    {
                        ImportDetail focusedOrderDetail = model.ImportDetails.Local.Where(od => od.ProductId == product.Id && od.ImportId == import.Id).FirstOrDefault();
                        focusedOrderDetail.UnitPrice = int.Parse(e.Value.ToString());
                        focusedOrderDetail.TotalPrice = focusedOrderDetail.Quantity * focusedOrderDetail.UnitPrice;
                        model.SaveChanges();
                        import.TotalPrice = model.ImportDetails.Local.Where(od => od.ImportId == import.Id).Sum(od => od.TotalPrice);
                    }
                    model.SaveChanges();
                    gcOrderDetail.DataSource = model.ImportDetails.Where(od => od.ImportId == import.Id).ToList();
                    gcOrders.RefreshDataSource();
                    break;
            }
        }

        private void rdSelectDateOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtSelectDateOrder.Enabled = rdSelectDateOrder.SelectedIndex == 2;
            if (rdSelectDateOrder.SelectedIndex == 1)
            {
                LoadOrders(DateTime.Now.AddDays(-1));
            }
            else if (rdSelectDateOrder.SelectedIndex == 0)
            {
                LoadOrders(DateTime.Now);
            }
            else
            {
                LoadOrders(dtSelectDateOrder.DateTime);
            }
        }

        private void gvOrders_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadOrder();
        }

        private void LoadOrder()
        {
            import = (Import)gvOrders.GetFocusedRow();
            if (import != null)
            {
                lblOrderCode.Text = import.ImportCode;
                lookUpVendor.EditValue = import.VendorId;
                importDetails = model.ImportDetails.Where(o => o.ImportId == import.Id).ToList();
                gcOrderDetail.DataSource = importDetails;
            }
        }
    }
}