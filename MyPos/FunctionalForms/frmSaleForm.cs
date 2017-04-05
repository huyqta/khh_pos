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
            // TODO: This line of code loads data into the 'khh_posDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.khh_posDataSet.Categories);
            LoadOrders(DateTime.Now);
        }

        private void rdSelectDateOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (rdSelectDateOrder.SelectedIndex == 0)
            //{
            dtSelectDateOrder.Enabled = rdSelectDateOrder.SelectedIndex == 2;
            //}
        }

        private void LoadOrders(DateTime datetimeOrder)
        {
            //listOrders = model.Orders.Where(o => o.OrderDateTime.Date == dtSelectDateOrder.DateTime.Date).ToList();
            gcOrders.DataSource = model.Orders.Where(o => DbFunctions.TruncateTime(o.OrderDateTime) == datetimeOrder.Date).ToList();
        }

        //private void gvOrders_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        //{
        //    gcOrderDetail.DataSource = listOrderDetails.Where(o => o.OrderId == (int)gvOrders.GetFocusedDataRow()["Id"]).ToList();
        //}


        //private void SetDataForTest()
        //{
        //    listOrders.Add(new Order() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), OrderCode = "001", Description = "abc", OrderDateTime = DateTime.Now, OrderDetails = null, TotalPrice = 10000 });
        //    listOrders.Add(new Order() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), OrderCode = "002", Description = "abc", OrderDateTime = DateTime.Now, OrderDetails = null, TotalPrice = 10000 });
        //    listOrders.Add(new Order() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), OrderCode = "003", Description = "abc", OrderDateTime = DateTime.Now, OrderDetails = null, TotalPrice = 10000 });
        //    listOrders.Add(new Order() { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), OrderCode = "004", Description = "abc", OrderDateTime = DateTime.Now, OrderDetails = null, TotalPrice = 10000 });
        //    listOrders.Add(new Order() { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), OrderCode = "005", Description = "abc", OrderDateTime = DateTime.Now, OrderDetails = null, TotalPrice = 10000 });
        //    listOrders.Add(new Order() { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), OrderCode = "006", Description = "abc", OrderDateTime = DateTime.Now, OrderDetails = null, TotalPrice = 10000 });

        //    listOrderDetails.Add(new OrderDetail() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), OrderId = Guid.Parse("00000000-0000-0000-0000-000000000001"), CategoryId = 0, ProductId = 0, Quanlity = 1, UnitPrice = 10, TotalPrice = 10, UnitId = 0 });
        //    listOrderDetails.Add(new OrderDetail() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), OrderId = Guid.Parse("00000000-0000-0000-0000-000000000002"), CategoryId = 0, ProductId = 0, Quanlity = 1, UnitPrice = 10, TotalPrice = 10, UnitId = 0 });
        //    listOrderDetails.Add(new OrderDetail() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), OrderId = Guid.Parse("00000000-0000-0000-0000-000000000002"), CategoryId = 0, ProductId = 0, Quanlity = 1, UnitPrice = 10, TotalPrice = 10, UnitId = 0 });
        //    listOrderDetails.Add(new OrderDetail() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), OrderId = Guid.Parse("00000000-0000-0000-0000-000000000003"), CategoryId = 0, ProductId = 0, Quanlity = 1, UnitPrice = 10, TotalPrice = 10, UnitId = 0 });
        //    listOrderDetails.Add(new OrderDetail() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), OrderId = Guid.Parse("00000000-0000-0000-0000-000000000003"), CategoryId = 0, ProductId = 0, Quanlity = 1, UnitPrice = 10, TotalPrice = 10, UnitId = 0 });
        //    listOrderDetails.Add(new OrderDetail() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), OrderId = Guid.Parse("00000000-0000-0000-0000-000000000003"), CategoryId = 0, ProductId = 0, Quanlity = 1, UnitPrice = 10, TotalPrice = 10, UnitId = 0 });
        //}

        private void gvOrders_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Order selectedOrder = (Order)gvOrders.GetFocusedRow();
            gcOrderDetail.DataSource = listOrderDetails.Where(o => o.OrderId == selectedOrder.Id).ToList();
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
            model.Orders.Add(order);

            model.SaveChanges();
            gcOrders.DataSource = model.Orders.ToList();
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            lblOrderCode.Text = string.Empty;
            model.SaveChanges();
        }

        private void winExplorerView_Product_ItemDoubleClick(object sender, DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewItemDoubleClickEventArgs e)
        {
            Product pr = e.ItemInfo.Row.RowKey as Product;
            if (string.IsNullOrEmpty(lblOrderCode.Text))
            {
                lblOrderCode.Text = DateTime.Now.ToString("ddMMyyyyHHmmss");
                order = new Order();
                order.Id = Guid.NewGuid();
                order.OrderCode = lblOrderCode.Text;
                order.OrderDateTime = DateTime.Now;
            }
            OrderDetail orderDetail = new OrderDetail();
            orderDetail.Id = Guid.NewGuid();
            orderDetail.OrderId = order.Id;
            orderDetail.ProductId = pr.Id;
            orderDetail.Quanlity = 1;
            //orderDetail.UnitId = pr.unitId
            orderDetail.UnitPrice = pr.DefaultPrice;
            orderDetail.TotalPrice = pr.DefaultPrice;
            model.OrderDetails.Add(orderDetail);

            model.SaveChanges();
            gcOrderDetail.DataSource = model.OrderDetails.ToList();
        }

        private void gvOrderDetail_Click(object sender, EventArgs e)
        {
            var orderId = Guid.Parse(gvOrders.GetFocusedDataRow()["Id"].ToString());
            gcOrderDetail.DataSource = model.OrderDetails.Where(od => od.OrderId == orderId).ToList();
        }
    }
}