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
using System.Data.Entity;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

namespace MyPos.CustomControls
{
    public partial class ucSingleReceipt2 : DevExpress.XtraEditors.XtraUserControl
    {
        private ProductModel model = new ProductModel();
        private DateTime orderDateTime = DateTime.Now;
        public Order Order { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

        public ucSingleReceipt2()
        {
            InitializeComponent();
        }

        private void ucSingleReceipt2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khh_posDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.khh_posDataSet.Customers);
            // TODO: This line of code loads data into the 'khh_posDataSet.Units' table. You can move, or remove it, as needed.
            this.unitsTableAdapter.Fill(this.khh_posDataSet.Units);
            // TODO: This line of code loads data into the 'khh_posDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.khh_posDataSet.Products);

            orderDateTime = DateTime.Now;

            lblOrderDateTime.Text = orderDateTime.ToString("dd/MM/yyyy");
            lookCustomer.EditValue = 1;

            if (this.Order == null)
            {
                this.Order = new Order();
                this.Order.Id = Guid.NewGuid();
                this.Order.OrderCode = string.Format("BH{0}", orderDateTime.ToString("yyyyMMdd_HHmm"));
                this.Order.OrderDateTime = orderDateTime;
                this.Order.TotalPrice = 0;
                this.Order.CustomerId = 1;
            }
            
        }

        public void AddProduct(Product product)
        {
            if (this.OrderDetails == null) this.OrderDetails = new List<OrderDetail>();
            if (this.OrderDetails.Any(o => o.ProductId == product.Id))
            {
                var selectedOrderDetail = this.OrderDetails.Where(o => o.ProductId == product.Id).FirstOrDefault();
                selectedOrderDetail.Quantity++;
                selectedOrderDetail.TotalPrice = selectedOrderDetail.Quantity * selectedOrderDetail.UnitPrice;
            }
            else
            {
                OrderDetail orderDetail = new OrderDetail()
                {
                    Id = Guid.NewGuid(),
                    OrderId = Order.Id,
                    CategoryId = product.CategoryId,
                    ProductId = product.Id,
                    ProductName = product.Name,
                    Quantity = 1,
                    UnitId = product.UnitId,
                    UnitPrice = product.DefaultPrice,
                    TotalPrice = product.DefaultPrice
                };
                this.OrderDetails.Add(orderDetail);
            }
            gcOrderDetail.DataSource = this.OrderDetails;
            gcOrderDetail.RefreshDataSource();
        }

        private void gvOrderDetail_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var selectedOrderDetail = gvOrderDetail.GetRow(gvOrderDetail.FocusedRowHandle) as OrderDetail;
            int productId = selectedOrderDetail.ProductId;
            //Product product = model.Products.Where(p => p.Id == productId).FirstOrDefault();
            //OrderDetail orderDetail = model.OrderDetails.Where(od => od.OrderId == order.Id && od.ProductId == productId).FirstOrDefault();
            var orderDetail = this.OrderDetails.Find(o => o == selectedOrderDetail);
            switch (e.Column.FieldName)
            {
                case "Quantity":
                    orderDetail.TotalPrice = orderDetail.Quantity * orderDetail.UnitPrice;
                    break;
                case "UnitPrice":
                    orderDetail.TotalPrice = orderDetail.Quantity * orderDetail.UnitPrice;
                    break;
            }
            RecalculateOrderSummary();

            gcOrderDetail.DataSource = this.OrderDetails;
            gcOrderDetail.RefreshDataSource();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Order = new Order();
            this.OrderDetails = new List<OrderDetail>();

            gcOrderDetail.DataSource = this.OrderDetails;
            gcOrderDetail.RefreshDataSource();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveOrder();
            InventoryHelpers.UPDATE_INVENTORY(this.OrderDetails, InventoryHelpers.ActionType.Export);
            MessageBox.Show("Lưu đơn hàng thành công!");
        }

        private void btnSaveAndPrint_Click(object sender, EventArgs e)
        {
            SaveOrder();
            Reports.rpReceipt rp = new Reports.rpReceipt(this.Order);
            rp.ShowPreview();

            MessageBox.Show("Lưu đơn hàng thành công!");
        }

        public void SaveOrder()
        {
            if (this.Order == null)
            {
                DateTime orderDateTime = DateTime.Now;
                this.Order = new Order();
                this.Order.Id = Guid.NewGuid();
                this.Order.OrderCode = string.Format("BH{0}", orderDateTime.ToString("yyyyMMdd_HHmm"));
                this.Order.OrderDateTime = orderDateTime;
                this.Order.TotalPrice = this.OrderDetails.Sum(o => o.TotalPrice);

                model.Orders.Add(this.Order);
                model.OrderDetails.AddRange(this.OrderDetails);
            }
            if (!model.Orders.Any(o=>o.Id == this.Order.Id))
            {
                model.Orders.Add(this.Order);
                model.OrderDetails.AddRange(this.OrderDetails);
            }
            else
            {
                model.Orders.Attach(this.Order);
                model.Entry(this.Order).State = EntityState.Modified;
                foreach (var od in this.OrderDetails)
                {
                    if (!model.OrderDetails.Any(o => o.Id == od.Id))
                    {
                        model.OrderDetails.Add(od);
                    }
                    else
                    {
                        model.OrderDetails.Attach(od);
                        model.Entry(od).State = EntityState.Modified;
                    }
                }
            }
            model.SaveChanges();
            InventoryHelpers.UPDATE_INVENTORY(this.OrderDetails, InventoryHelpers.ActionType.Export);

            lblOrderCode.Text = Order.OrderCode;
        }

        private void repositoryItemButtonDeleteItem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OrderDetail seletedOrderDetail = (OrderDetail)gvOrderDetail.GetFocusedRow();
            this.OrderDetails.Remove(seletedOrderDetail);

            gcOrderDetail.DataSource = this.OrderDetails;
            gcOrderDetail.RefreshDataSource();
        }

        private void txtCustomerPay_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            //double moneyReturn = double.Parse(lblPayment.Text) - double.Parse(txtCustomerPay.EditValue.ToString());
            //lblMoneyReturn.Text = moneyReturn.ToString("{0:n0}");
        }

        private void txtCustomerPay_EditValueChanged(object sender, EventArgs e)
        {
            double moneyReturn = double.Parse(lblPayment.Text) - double.Parse(txtCustomerPay.EditValue.ToString());
            lblMoneyReturn.Text = moneyReturn.ToString("###,###,###");
        }

        public bool IsAvailableToDeleteOrder()
        {
            if (this.Order != null && (this.OrderDetails != null && this.OrderDetails.Count > 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void gvOrderDetail_RowCountChanged(object sender, EventArgs e)
        {
            RecalculateOrderSummary();
        }

        private void RecalculateOrderSummary()
        {
            this.Order.TotalPrice = this.OrderDetails.Sum(o => o.TotalPrice);
            lblTotalPrice.Text = this.Order.TotalPrice.ToString("###,###,###");
            double totalPrice = this.Order.TotalPrice - double.Parse(txtDiscount.EditValue.ToString());
            lblPayment.Text = totalPrice.ToString("###,###,###");
        }

        private void txtDiscount_EditValueChanged(object sender, EventArgs e)
        {
            RecalculateOrderSummary();
        }

        private void lblOrderCode_TextChanged(object sender, EventArgs e)
        {
            this.Parent.Text = lblOrderCode.Text;
        }
    }
}
