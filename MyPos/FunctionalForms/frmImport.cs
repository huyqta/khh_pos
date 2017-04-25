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
using MyPos.CustomControls;

namespace MyPos.FunctionalForms
{
    public partial class frmImport : DevExpress.XtraEditors.XtraForm
    {
        Import import;
        List<ImportDetail> importDetails = new List<ImportDetail>();
        ProductModel model = new ProductModel();
        double debtAmount = 0;

        public frmImport()
        {
            InitializeComponent();
            lblOrderCode.Text = string.Empty;
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
            lblImportDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            import = new Import();
            import.Id = Guid.NewGuid();
            import.ImportCode = lblOrderCode.Text;
            import.ImportDateTime = DateTime.Now;
            import.TotalPrice = 0;
            import.VendorId = vendor == null ? 1 : vendor.Id;

            importDetails = new List<ImportDetail>();

            model.Imports.Add(import);

            gcOrderDetail.DataSource = model.ImportDetails.Local.Where(od => od.ImportId == import.Id).ToList();

            model.SaveChanges();
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            InventoryHelpers.UPDATE_INVENTORY(importDetails, InventoryHelpers.ActionType.Import);
            //if (this.debtAmount > 0)
            //{
            //    DebtManagement debt = new DebtManagement();
            //    debt.Id = Guid.NewGuid();
            //    debt.DebtAmount = this.debtAmount;
            //    debt.IsVendor = false;
            //    debt.PartnerId = Order.CustomerId;
            //    debt.ReceiptId = this.Order.Id;
            //    model.DebtManagements.Add(debt);
            //    model.Entry(debt).State = EntityState.Added;
            //}
            model.SaveChanges();

            gcOrderDetail.DataSource = model.ImportDetails.Where(od => od.ImportId == import.Id).ToList();
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
                    break;
            }
        }

        private void btnListOrder_Click(object sender, EventArgs e)
        {
            ucListItem uc = new ucListItem();
            
            uc.ListFields = "Id,VendorName,ImportCode,ImportDateTime,TotalPrice";
            uc.ListColumns = "Id,Nhà cung cấp,Mã đơn hàng,Ngày nhập kho,Tổng tiền";
            uc.ListDataSources = ",Vendors,,,";
            uc.SqlQuery = @"SELECT imp.Id, imp.ImportCode, imp.ImportDateTime, imp.TotalPrice, vd.Name as VendorName FROM Imports imp INNER JOIN Vendors vd ON imp.VendorId = vd.Id";
            uc.SetDataSource(model.Imports.ToList());
            uc.ShowDialog();
            if (uc.ReturnId != null)
            {
                Guid importId = Guid.Parse(uc.ReturnId.ToString());
                this.import = model.Imports.Where(i => i.Id == importId).FirstOrDefault();
                lblId.Text = this.import.ImportCode.ToString();
                lblOrderCode.Text = this.import.ImportCode;
                lblImportDate.Text = this.import.ImportDateTime.ToString("dd/MM/yyyy");
                lookUpVendor.EditValue = this.import.VendorId;
                this.importDetails = model.ImportDetails.Where(id => id.ImportId == this.import.Id).ToList();
                gcOrderDetail.DataSource = this.importDetails.ToList();
            }
        }

        private void lookUpProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddProduct.PerformClick();
            }
        }
    }
}