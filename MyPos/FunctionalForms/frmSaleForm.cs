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
    public partial class frmSaleForm : DevExpress.XtraEditors.XtraForm
    {
        ProductModel model = new ProductModel();
        private List<Order> listOrders = new List<Order>();
        private List<OrderDetail> listOrderDetails = new List<OrderDetail>();

        public frmSaleForm()
        {
            InitializeComponent();
        }

        private void frmSaleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khh_posDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.khh_posDataSet.Categories);
            LoadOrders(DateTime.Now);
            SetDataForTest();
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
            gcOrders.DataSource = listOrders;
        }

        //private void gvOrders_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        //{
        //    gcOrderDetail.DataSource = listOrderDetails.Where(o => o.OrderId == (int)gvOrders.GetFocusedDataRow()["Id"]).ToList();
        //}


        private void SetDataForTest()
        {
            listOrders.Add(new Order() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), OrderCode = "001", Description = "abc", OrderDateTime = DateTime.Now, OrderDetails = null, TotalPrice = 10000 });
            listOrders.Add(new Order() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), OrderCode = "002", Description = "abc", OrderDateTime = DateTime.Now, OrderDetails = null, TotalPrice = 10000 });
            listOrders.Add(new Order() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), OrderCode = "003", Description = "abc", OrderDateTime = DateTime.Now, OrderDetails = null, TotalPrice = 10000 });
            listOrders.Add(new Order() { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), OrderCode = "004", Description = "abc", OrderDateTime = DateTime.Now, OrderDetails = null, TotalPrice = 10000 });
            listOrders.Add(new Order() { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), OrderCode = "005", Description = "abc", OrderDateTime = DateTime.Now, OrderDetails = null, TotalPrice = 10000 });
            listOrders.Add(new Order() { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), OrderCode = "006", Description = "abc", OrderDateTime = DateTime.Now, OrderDetails = null, TotalPrice = 10000 });

            listOrderDetails.Add(new OrderDetail() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), OrderId = Guid.Parse("00000000-0000-0000-0000-000000000001"), CategoryId = 0, ProductId = 0, Quanlity = 1, UnitPrice = 10, TotalPrice = 10, UnitId = 0 });
            listOrderDetails.Add(new OrderDetail() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), OrderId = Guid.Parse("00000000-0000-0000-0000-000000000002"), CategoryId = 0, ProductId = 0, Quanlity = 1, UnitPrice = 10, TotalPrice = 10, UnitId = 0 });
            listOrderDetails.Add(new OrderDetail() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), OrderId = Guid.Parse("00000000-0000-0000-0000-000000000002"), CategoryId = 0, ProductId = 0, Quanlity = 1, UnitPrice = 10, TotalPrice = 10, UnitId = 0 });
            listOrderDetails.Add(new OrderDetail() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), OrderId = Guid.Parse("00000000-0000-0000-0000-000000000003"), CategoryId = 0, ProductId = 0, Quanlity = 1, UnitPrice = 10, TotalPrice = 10, UnitId = 0 });
            listOrderDetails.Add(new OrderDetail() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), OrderId = Guid.Parse("00000000-0000-0000-0000-000000000003"), CategoryId = 0, ProductId = 0, Quanlity = 1, UnitPrice = 10, TotalPrice = 10, UnitId = 0 });
            listOrderDetails.Add(new OrderDetail() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), OrderId = Guid.Parse("00000000-0000-0000-0000-000000000003"), CategoryId = 0, ProductId = 0, Quanlity = 1, UnitPrice = 10, TotalPrice = 10, UnitId = 0 });
        }

        private void gvOrders_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Order selectedOrder = (Order)gvOrders.GetFocusedRow();
            gcOrderDetail.DataSource = listOrderDetails.Where(o => o.OrderId == selectedOrder.Id).ToList();
        }
    }
}