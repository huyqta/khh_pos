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
using DevExpress.XtraPrinting;

namespace MyPos.Reports
{
    public partial class rpReceipt : DevExpress.XtraReports.UI.XtraReport
    {
        public Order OrderPrint { get; set; }
        public OrderDetail OrderDetailPrint { get; set; }
        public rpReceipt(Order orderPrint)
        {
            InitializeComponent();
            OrderPrint = orderPrint;
            FillDataToReceipt();
        }

        private void FillDataToReceipt()
        {
            ProductModel model = new ProductModel();
            List<OrderDetail> listOD = new List<OrderDetail>();
            listOD = model.OrderDetails.Where(o => o.OrderId == OrderPrint.Id).ToList();
            this.DataSource = listOD;
            xrLabelProductName.DataBindings.Add("Text", null, "ProductName");
            xrLabelQuantity.DataBindings.Add("Text", null, "Quantity", "{0:n0}");
            xrLabelUnitPrice.DataBindings.Add("Text", null, "UnitPrice", "{0:n0}");
            xrLabelTotalPrice.DataBindings.Add("Text", null, "TotalPrice", "{0:n0}");

            xrLabelStt.DataBindings.Add("Text", null, "ProductName", "{0:n0}");
            xrLabelStt.Summary.Func = SummaryFunc.RecordNumber;
            xrLabelStt.Summary.Running = SummaryRunning.Report;

            xrLabelSumTotal.DataBindings.Add("Text", null, "TotalPrice", "{0:n0}");
            xrLabelSumTotal.Summary.Func = SummaryFunc.Sum;
            xrLabelSumTotal.Summary.Running = SummaryRunning.Report;
        }

        public void AddBoundLabel(string bindingMember)
        {
            // Create a label. 
            XRLabel label = new XRLabel();
            label.Font = new Font("Oswald", 8, FontStyle.Regular);
            // Add the label to the report's Detail band. 
            Detail.Controls.Add(label);

            // Set its location and size. 
            //label.Location = bounds.Location;
            //label.Size = bounds.Size;
            //label.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;

            // Bind it to the bindingMember data field. 
            // When the dataSource parameter is null, the report's data source is used. 
            label.DataBindings.Add("Text", null, bindingMember);
        }

        private int ConvertFloatToInt(float value)
        {
            return (int)Math.Ceiling(value);
        }
    }
}
