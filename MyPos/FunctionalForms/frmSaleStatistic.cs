﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MyPos.Helper;
using BusinessEntity;
using System.Data.Entity;

namespace MyPos.FunctionalForms
{
    public partial class frmSaleStatistic : DevExpress.XtraEditors.XtraForm
    {
        ProductModel model = new ProductModel();

        public frmSaleStatistic()
        {
            InitializeComponent();
        }

        private void frmSaleStatistic_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khh_posDataSet.SaleStatistic' table. You can move, or remove it, as needed.
            this.saleStatisticTableAdapter.Fill(this.khh_posDataSet.SaleStatistics);
            dtSelectDate.DateTime = DateTime.Now;
            gcSaleStatistic.DataSource = model.SaleStatistics.ToList();
            gvSaleStatistic.ExpandAllGroups();
        }

        private void gcSaleStatistic_ProcessGridKey(object sender, KeyEventArgs e)
        {

        }

        private void gcSaleStatistic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                model.SaveChanges();
                gvSaleStatistic.ExpandAllGroups();
                MessageBox.Show("Saved successfull!");
            }
            
        }

        private void btnInitialDay_Click(object sender, EventArgs e)
        {
            List<Order> listOrders = new List<Order>();
            listOrders = LoadOrders(dtSelectDate.DateTime);

            foreach (var order in listOrders)
            {
                List<OrderDetail> listOrderDetails = new List<OrderDetail>();
                listOrderDetails = model.OrderDetails.Where(od => od.OrderId == order.Id).ToList();
                foreach (var orderDetail in listOrderDetails)
                {
                    if (!model.SaleStatistics.Local.Any(s=>s.OrderDetailId == orderDetail.Id))
                    {
                        SaleStatistic ss = new SaleStatistic();
                        ss.Id = Guid.NewGuid();
                        ss.OrderCode = order.OrderCode;
                        ss.OrderDetailId = orderDetail.Id;
                        ss.ProductId = orderDetail.ProductId;
                        ss.ProductName = orderDetail.ProductName;
                        ss.Quanlity = orderDetail.Quanlity;
                        ss.UnitId = orderDetail.UnitId;
                        ss.UnitName = orderDetail.UnitName;
                        ss.UnitPrice = orderDetail.UnitPrice;
                        ss.TotalPrice = orderDetail.TotalPrice;
                        ss.CustomerId = order.CustomerId;
                        ss.CustomerName = model.Customers.Where(c => c.Id == order.CustomerId).FirstOrDefault().Name.ToString();
                        model.SaleStatistics.Add(ss);
                    }                                
                }
            }

            gcSaleStatistic.DataSource = model.SaleStatistics.Local.ToList();
            gvSaleStatistic.ExpandAllGroups();
        }

        private List<Order> LoadOrders(DateTime datetimeOrder)
        {
            return model.Orders.Where(o => DbFunctions.TruncateTime(o.OrderDateTime) == datetimeOrder.Date).ToList();
        }

        private void dtSelectDate_DateTimeChanged(object sender, EventArgs e)
        {
            gcSaleStatistic.DataSource = LoadOrders(dtSelectDate.DateTime);
            gvSaleStatistic.ExpandAllGroups();
        }
    }
}