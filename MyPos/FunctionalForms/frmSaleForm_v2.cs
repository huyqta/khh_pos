using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessEntity;
using System.Data.Entity;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using MyPos.Helper;
using MyPos.CustomControls;
using DevExpress.XtraTab;
using DevExpress.XtraEditors;

namespace MyPos.FunctionalForms
{
    public partial class frmSaleForm_v2 : DevExpress.XtraEditors.XtraForm
    {
        ProductModel model = new ProductModel();
        Order order = new Order();

        private List<Order> listOrders = new List<Order>();
        private List<OrderDetail> listOrderDetails = new List<OrderDetail>();

        public frmSaleForm_v2()
        {
            InitializeComponent();
            //dtSelectDateOrder.DateTime = DateTime.Now;
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
            //dtSelectDateOrder.Enabled = rdSelectDateOrder.SelectedIndex == 2;
            //if (rdSelectDateOrder.SelectedIndex == 1)
            //{
            //    LoadOrders(DateTime.Now.AddDays(-1));
            //}
            //else if (rdSelectDateOrder.SelectedIndex == 0)
            //{
            //    LoadOrders(DateTime.Now);
            //}
            //else
            //{
            //    LoadOrders(dtSelectDateOrder.DateTime);
            //}
        }

        private void LoadOrders(DateTime datetimeOrder)
        {
            //gcOrders.DataSource = model.Orders.Where(o => DbFunctions.TruncateTime(o.OrderDateTime) == datetimeOrder.Date).ToList();
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

            order = new Order();
            order.Id = Guid.NewGuid();
            order.OrderDateTime = DateTime.Now;
            order.CustomerId = 1;
            model.Orders.Add(order);


            model.SaveChanges();
            rdSelectDateOrder_SelectedIndexChanged(null, null);
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            InventoryHelpers.UPDATE_INVENTORY(listOrderDetails, InventoryHelpers.ActionType.Export);
            order = new Order();
            model.SaveChanges();
        }

        private void winExplorerView_Product_ItemDoubleClick(object sender, DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewItemDoubleClickEventArgs e)
        {
            Product pr = e.ItemInfo.Row.RowKey as Product;
            ucSingleReceipt2 xuc = (ucSingleReceipt2)xtraTabControl1.SelectedTabPage.Controls.Find("ucSingleReceipt2", false).FirstOrDefault();
            xuc.AddProduct(pr);
            //if (order == null || string.IsNullOrEmpty(order.OrderCode))
            //{
            //    //btnNewOrder.PerformClick();
            //}
            //listOrderDetails = model.OrderDetails.Where(od => od.OrderId == order.Id).ToList();
            //if (listOrderDetails.Any(l => l.ProductId == pr.Id))
            //{
            //    OrderDetail focusedOrderDetail = model.OrderDetails.Where(od => od.ProductId == pr.Id && od.OrderId == order.Id).FirstOrDefault();
            //    focusedOrderDetail.Quantity++;
            //    focusedOrderDetail.TotalPrice = focusedOrderDetail.Quantity * focusedOrderDetail.UnitPrice;
            //    order.TotalPrice = model.OrderDetails.Local.Where(od => od.OrderId == order.Id).Sum(od => od.TotalPrice);
            //}
            //else
            //{
            //    OrderDetail orderDetail = new OrderDetail();
            //    orderDetail.Id = Guid.NewGuid();
            //    orderDetail.OrderId = order.Id;
            //    orderDetail.ProductName = pr.Name;
            //    orderDetail.ProductId = pr.Id;
            //    orderDetail.CategoryName = model.Categories.Where(c => c.Id == pr.CategoryId).Select(c => c.Name).FirstOrDefault().ToString();
            //    orderDetail.CategoryId = pr.CategoryId;
            //    orderDetail.Quantity = 1;
            //    orderDetail.UnitName = model.Units.Where(u => u.Id == pr.UnitId).Select(u => u.Name).FirstOrDefault().ToString();
            //    orderDetail.UnitId = pr.UnitId;
            //    orderDetail.UnitPrice = pr.DefaultPrice;
            //    orderDetail.TotalPrice = pr.DefaultPrice;
            //    model.OrderDetails.Add(orderDetail);
            //}
            //order.TotalPrice = model.OrderDetails.Local.Where(od => od.OrderId == order.Id).Sum(od => od.TotalPrice);

            //model.SaveChanges();
            //rdSelectDateOrder_SelectedIndexChanged(null, null);
        }

        private void gvOrderDetail_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //var selectedOrderDetail = gvOrderDetail.GetRow(gvOrderDetail.FocusedRowHandle) as OrderDetail;
            //int productId = selectedOrderDetail.ProductId;
            //Product product = model.Products.Where(p => p.Id == productId).FirstOrDefault();
            //OrderDetail orderDetail = model.OrderDetails.Where(od => od.OrderId == order.Id && od.ProductId == productId).FirstOrDefault();
            //switch (e.Column.FieldName)
            //{
            //    case "ProductId":
            //        orderDetail.ProductName = product.Name;

            //        gvOrderDetail.SetFocusedRowCellValue(gvOrderDetail.Columns["CategoryId"], product.CategoryId);
            //        orderDetail.CategoryName = model.Categories.Where(c => c.Id == product.CategoryId).Select(c => c.Name).FirstOrDefault().ToString();
            //        orderDetail.CategoryId = product.CategoryId;

            //        gvOrderDetail.SetFocusedRowCellValue(gvOrderDetail.Columns["UnitId"], product.UnitId);
            //        orderDetail.UnitName = model.Units.Where(u => u.Id == product.UnitId).Select(u => u.Name).FirstOrDefault().ToString();
            //        orderDetail.UnitId = product.UnitId;

            //        gvOrderDetail.SetFocusedRowCellValue(gvOrderDetail.Columns["UnitPrice"], product.DefaultPrice);
            //        gvOrderDetail.SetFocusedRowCellValue(gvOrderDetail.Columns["Quantity"], 1);
            //        gvOrderDetail.SetFocusedRowCellValue(gvOrderDetail.Columns["TotalPrice"], product.DefaultPrice);
            //        break;
            //    case "Quantity":
            //        if (model.OrderDetails.Local.Any(l => l.ProductId == product.Id))
            //        {
            //            OrderDetail focusedOrderDetail = model.OrderDetails.Local.Where(od => od.ProductId == product.Id && od.OrderId == order.Id).FirstOrDefault();
            //            focusedOrderDetail.Quantity = double.Parse(e.Value.ToString());
            //            focusedOrderDetail.TotalPrice = focusedOrderDetail.Quantity * focusedOrderDetail.UnitPrice;
            //            model.SaveChanges();
            //            order.TotalPrice = model.OrderDetails.Local.Where(od => od.OrderId == order.Id).Sum(od => od.TotalPrice);
            //        }
            //        model.SaveChanges();
            //        gcOrderDetail.DataSource = model.OrderDetails.Where(od => od.OrderId == order.Id).ToList();
            //        //gcOrders.RefreshDataSource();
            //        break;
            //    case "UnitPrice":
            //        if (model.OrderDetails.Local.Any(l => l.ProductId == product.Id))
            //        {
            //            OrderDetail focusedOrderDetail = model.OrderDetails.Local.Where(od => od.ProductId == product.Id && od.OrderId == order.Id).FirstOrDefault();
            //            focusedOrderDetail.UnitPrice = int.Parse(e.Value.ToString());
            //            focusedOrderDetail.TotalPrice = focusedOrderDetail.Quantity * focusedOrderDetail.UnitPrice;
            //            model.SaveChanges();
            //            order.TotalPrice = model.OrderDetails.Local.Where(od => od.OrderId == order.Id).Sum(od => od.TotalPrice);
            //        }
            //        model.SaveChanges();
            //        gcOrderDetail.DataSource = model.OrderDetails.Where(od => od.OrderId == order.Id).ToList();
            //        //gcOrders.RefreshDataSource();
            //        break;
            //}
        }

        private void gvOrderDetail_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }

        private void gvOrders_DoubleClick(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void lookUpCustomer_EditValueChanged(object sender, EventArgs e)
        {
            //order.CustomerId = int.Parse(lookUpCustomer.EditValue.ToString());
            model.SaveChanges();
        }

        private void LoadOrder()
        {
            //order = (Order)gvOrders.GetFocusedRow();
            //if (order != null)
            //{
            //    lblOrderCode.Text = order.OrderCode;
            //    lookUpCustomer.EditValue = order.CustomerId;
            //    listOrderDetails = model.OrderDetails.Where(o => o.OrderId == order.Id).ToList();
            //    gcOrderDetail.DataSource = listOrderDetails;
            //}
        }

        private void gcCategory_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("In phieu tinh tien");
        }

        private void gvOrders_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            // Check if the right mouse button has been pressed 
            if (e.Button == MouseButtons.Right)
                DoShowMenu(view.CalcHitInfo(new Point(e.X, e.Y)));
        }

        private void DoShowMenu(DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hi)
        {
            // Create the menu. 
            DevExpress.XtraGrid.Menu.GridViewMenu menu = null;
            // Check whether the header panel button has been clicked. 
            if (hi.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.ColumnButton)
            {
                menu = new GridViewColumnButtonMenu(hi.View);
                menu.Init(hi);
                // Display the menu. 
                menu.Show(hi.HitPoint);
            }
        }

        private void toolStripMenu_PrintReceipt_Click(object sender, EventArgs e)
        {
            ////Reports.frmReports frm = new Reports.frmReports();
            ////ReportDesignTool designTool = new ReportDesignTool(frm);
            ////// Invoke the Ribbon End-User Designer form.   
            ////designTool.ShowRibbonDesigner();

            ////// Invoke the Ribbon End-User Designer form modally  
            ////// with the specified look and feel settings.  
            //////designTool.ShowRibbonDesignerDialog(UserLookAndFeel.Default);

            ////// Invoke the standard End-User Designer form.   
            ////designTool.ShowDesigner();

            ////// Invoke the standard End-User Designer form modally  
            ////// with the specified look and feel settings.  
            //////designTool.ShowDesignerDialog(UserLookAndFeel.Default);
            //Order orderPrint = (Order)gvOrders.GetFocusedRow();
            //Reports.rpReceipt rp = new Reports.rpReceipt(orderPrint);
            //rp.ShowPreview();
            ////rp.Print();
        }

        private void xtraTabControl1_CustomHeaderButtonClick(object sender, DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventArgs e)
        {
            ucSingleReceipt2 uc;
            switch (e.Button.Kind.ToString())
            {
                case "Plus":
                    uc = new ucSingleReceipt2();
                    XtraTabPage tab = new XtraTabPage();
                    tab.Controls.Add(uc);
                    uc.Dock = DockStyle.Fill;
                    tab.Text = "#" + xtraTabControl1.TabPages.Count.ToString();
                    xtraTabControl1.TabPages.Add(tab);
                    break;
                case "Minus":
                    uc = (ucSingleReceipt2)xtraTabControl1.SelectedTabPage.Controls.Find("ucSingleReceipt2", false).FirstOrDefault();
                    if (!uc.IsAvailableToDeleteOrder())
                    {
                        return;
                    }
                    xtraTabControl1.TabPages.Remove(xtraTabControl1.SelectedTabPage);
                    break;
                case "OK":
                    uc = (ucSingleReceipt2)xtraTabControl1.SelectedTabPage.Controls.Find("ucSingleReceipt2", false).FirstOrDefault();
                    uc.SaveOrder();
                    xtraTabControl1.TabPages.Remove(xtraTabControl1.SelectedTabPage);
                    break;
            }
        }
    }
}