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
    public partial class frmSaleForm : DevExpress.XtraEditors.XtraForm
    {
        ProductModel model = new ProductModel();
        Order order = new Order();

        private List<Order> listOrders = new List<Order>();
        private List<OrderDetail> listOrderDetails = new List<OrderDetail>();

        public frmSaleForm()
        {
            InitializeComponent();
            lblOrderCode.Text = string.Empty;
            dtSelectDateOrder.DateTime = DateTime.Now;
        }

        private void frmSaleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khh_posDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.khh_posDataSet.Customers);
            // TODO: This line of code loads data into the 'khh_posDataSet.Units' table. You can move, or remove it, as needed.
            this.unitsTableAdapter.Fill(this.khh_posDataSet.Units);
            // TODO: This line of code loads data into the 'khh_posDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.khh_posDataSet.Products);
            // TODO: This line of code loads data into the 'khh_posDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.khh_posDataSet.Categories);
            LoadOrders(DateTime.Now);
        }

        private void rdSelectDateOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtSelectDateOrder.Enabled = rdSelectDateOrder.SelectedIndex == 2;
        }

        private void LoadOrders(DateTime datetimeOrder)
        {
            gcOrders.DataSource = model.Orders.Where(o => DbFunctions.TruncateTime(o.OrderDateTime) == datetimeOrder.Date).ToList();
        }

        private void gvOrders_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadOrder();
        }

        private void gcCategory_Click(object sender, EventArgs e)
        {

        }

        private void winExplorerView_Category_ItemClick(object sender, DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewItemClickEventArgs e)
        {
            Type selectedCat = e.ItemInfo.Row.RowKey.GetType();
            khh_posDataSet.CategoriesRow cr = e.ItemInfo.Row.RowKey as khh_posDataSet.CategoriesRow;
            gcProducts.DataSource = model.Products.Where(c => c.CategoryId == cr.Id).ToList();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            lblOrderCode.Text = DateTime.Now.ToString("ddMMyyyyHHmmss");
            order = new Order();
            order.Id = Guid.NewGuid();
            order.OrderCode = lblOrderCode.Text;
            order.OrderDateTime = DateTime.Now;
            order.CustomerId = 1;
            model.Orders.Add(order);

            gcOrderDetail.DataSource = model.OrderDetails.Local.Where(od => od.OrderId == order.Id).ToList();

            model.SaveChanges();
            gcOrders.DataSource = model.Orders.ToList();
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            lblOrderCode.Text = string.Empty;
            order.CustomerId = int.Parse(lookUpCustomer.EditValue.ToString());
            model.SaveChanges();
        }

        private void winExplorerView_Product_ItemDoubleClick(object sender, DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewItemDoubleClickEventArgs e)
        {
            Product pr = e.ItemInfo.Row.RowKey as Product;
            if (order == null)
            {
                lblOrderCode.Text = DateTime.Now.ToString("ddMMyyyyHHmmss");
                order = new Order();
                order.Id = Guid.NewGuid();
                order.OrderCode = lblOrderCode.Text;
                order.OrderDateTime = DateTime.Now;
            }
            listOrderDetails = model.OrderDetails.Where(od => od.OrderId == order.Id).ToList();
            if (listOrderDetails.Any(l => l.ProductId == pr.Id))
            {
                OrderDetail focusedOrderDetail = model.OrderDetails.Where(od => od.ProductId == pr.Id && od.OrderId == order.Id).FirstOrDefault();
                focusedOrderDetail.Quanlity++;
                focusedOrderDetail.TotalPrice = focusedOrderDetail.Quanlity * focusedOrderDetail.UnitPrice;
                order.TotalPrice = model.OrderDetails.Local.Where(od => od.OrderId == order.Id).Sum(od => od.TotalPrice);
            }
            else
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.Id = Guid.NewGuid();
                orderDetail.OrderId = order.Id;
                orderDetail.ProductId = pr.Id;
                orderDetail.Quanlity = 1;
                orderDetail.UnitId = pr.UnitId;
                orderDetail.UnitPrice = pr.DefaultPrice;
                orderDetail.TotalPrice = pr.DefaultPrice;
                model.OrderDetails.Add(orderDetail);
            }
            order.TotalPrice = model.OrderDetails.Local.Where(od => od.OrderId == order.Id).Sum(od => od.TotalPrice);

            model.SaveChanges();
            gcOrderDetail.DataSource = model.OrderDetails.Where(od => od.OrderId == order.Id).ToList();
            gcOrders.DataSource = model.Orders.ToList();
        }

        private void gvOrderDetail_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }

        private void gvOrderDetail_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var selectedOrderDetail = gvOrderDetail.GetRow(gvOrderDetail.FocusedRowHandle) as OrderDetail;
            int productId = selectedOrderDetail.ProductId;
            Product product = model.Products.Where(p => p.Id == productId).FirstOrDefault();
            switch (e.Column.FieldName)
            {
                case "ProductId":
                    //OrderDetail od = (OrderDetail)gvOrderDetail.GetFocusedRow();
                    gvOrderDetail.SetFocusedRowCellValue(gvOrderDetail.Columns["CategoryId"], product.CategoryId);
                    gvOrderDetail.SetFocusedRowCellValue(gvOrderDetail.Columns["UnitId"], product.UnitId);
                    gvOrderDetail.SetFocusedRowCellValue(gvOrderDetail.Columns["UnitPrice"], product.DefaultPrice);
                    gvOrderDetail.SetFocusedRowCellValue(gvOrderDetail.Columns["Quanlity"], 1);
                    gvOrderDetail.SetFocusedRowCellValue(gvOrderDetail.Columns["TotalPrice"], product.DefaultPrice);
                    break;
                case "Quanlity":
                    if (listOrderDetails.Any(l => l.ProductId == product.Id))
                    {
                        OrderDetail focusedOrderDetail = model.OrderDetails.Where(od => od.ProductId == product.Id && od.OrderId == order.Id).FirstOrDefault();
                        focusedOrderDetail.Quanlity = int.Parse(e.Value.ToString());
                        focusedOrderDetail.TotalPrice = focusedOrderDetail.Quanlity * focusedOrderDetail.UnitPrice;
                        model.SaveChanges();
                        order.TotalPrice = model.OrderDetails.Where(od => od.OrderId == order.Id).Sum(od => od.TotalPrice);
                    }
                    model.SaveChanges();
                    gcOrderDetail.DataSource = model.OrderDetails.Where(od => od.OrderId == order.Id).ToList();
                    gcOrders.RefreshDataSource();
                    break;
            }
        }

        private void gvOrders_DoubleClick(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void lookUpCustomer_EditValueChanged(object sender, EventArgs e)
        {
            order.CustomerId = int.Parse(lookUpCustomer.EditValue.ToString());
            model.SaveChanges();
        }

        private void LoadOrder()
        {
            order = (Order)gvOrders.GetFocusedRow();
            lblOrderCode.Text = order.OrderCode;
            lookUpCustomer.EditValue = order.CustomerId;
            gcOrderDetail.DataSource = model.OrderDetails.Where(o => o.OrderId == order.Id).ToList();
        }
    }
}