namespace MyPos.Reports
{
    partial class rpReceipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpReceipt));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabelTotalPrice = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelUnitPrice = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelQuantity = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelProductName = new DevExpress.XtraReports.UI.XRLabel();
            this.efDataSource1 = new DevExpress.DataAccess.EntityFramework.EFDataSource(this.components);
            this.xrTableOrderDetail = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellProduct = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellQuantity = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellUnitPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellTotalPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.orderDetailsTableAdapter1 = new MyPos.khh_posDataSetTableAdapters.OrderDetailsTableAdapter();
            this.orderDetailsTableAdapter2 = new MyPos.khh_posDataSetTableAdapters.OrderDetailsTableAdapter();
            this.khh_posDataSet1 = new MyPos.khh_posDataSet();
            this.unitsTableAdapter = new MyPos.khh_posDataSetTableAdapters.UnitsTableAdapter();
            this.khh_posDataSet2 = new MyPos.khh_posDataSet();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrLabelSumTotal = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            this.xrLabelStt = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.efDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabelStt,
            this.xrLabelTotalPrice,
            this.xrLabelUnitPrice,
            this.xrLabelQuantity,
            this.xrLabelProductName});
            this.Detail.HeightF = 30F;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabelTotalPrice
            // 
            this.xrLabelTotalPrice.BorderColor = System.Drawing.Color.Gray;
            this.xrLabelTotalPrice.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabelTotalPrice.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabelTotalPrice.Font = new System.Drawing.Font("Oswald", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabelTotalPrice.LocationFloat = new DevExpress.Utils.PointFloat(409.0174F, 0F);
            this.xrLabelTotalPrice.Name = "xrLabelTotalPrice";
            this.xrLabelTotalPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F);
            this.xrLabelTotalPrice.SizeF = new System.Drawing.SizeF(118.9826F, 30F);
            this.xrLabelTotalPrice.StylePriority.UseBorderColor = false;
            this.xrLabelTotalPrice.StylePriority.UseBorderDashStyle = false;
            this.xrLabelTotalPrice.StylePriority.UseBorders = false;
            this.xrLabelTotalPrice.StylePriority.UseFont = false;
            this.xrLabelTotalPrice.StylePriority.UsePadding = false;
            this.xrLabelTotalPrice.StylePriority.UseTextAlignment = false;
            this.xrLabelTotalPrice.Text = "xxx";
            this.xrLabelTotalPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabelUnitPrice
            // 
            this.xrLabelUnitPrice.BorderColor = System.Drawing.Color.Gray;
            this.xrLabelUnitPrice.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabelUnitPrice.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabelUnitPrice.Font = new System.Drawing.Font("Oswald", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabelUnitPrice.LocationFloat = new DevExpress.Utils.PointFloat(342.0972F, 0F);
            this.xrLabelUnitPrice.Name = "xrLabelUnitPrice";
            this.xrLabelUnitPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F);
            this.xrLabelUnitPrice.SizeF = new System.Drawing.SizeF(66.9201F, 30F);
            this.xrLabelUnitPrice.StylePriority.UseBorderColor = false;
            this.xrLabelUnitPrice.StylePriority.UseBorderDashStyle = false;
            this.xrLabelUnitPrice.StylePriority.UseBorders = false;
            this.xrLabelUnitPrice.StylePriority.UseFont = false;
            this.xrLabelUnitPrice.StylePriority.UsePadding = false;
            this.xrLabelUnitPrice.StylePriority.UseTextAlignment = false;
            this.xrLabelUnitPrice.Text = "xxx";
            this.xrLabelUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabelQuantity
            // 
            this.xrLabelQuantity.BorderColor = System.Drawing.Color.Gray;
            this.xrLabelQuantity.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabelQuantity.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabelQuantity.Font = new System.Drawing.Font("Oswald", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabelQuantity.LocationFloat = new DevExpress.Utils.PointFloat(286.3134F, 0F);
            this.xrLabelQuantity.Name = "xrLabelQuantity";
            this.xrLabelQuantity.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F);
            this.xrLabelQuantity.SizeF = new System.Drawing.SizeF(55.78384F, 30F);
            this.xrLabelQuantity.StylePriority.UseBorderColor = false;
            this.xrLabelQuantity.StylePriority.UseBorderDashStyle = false;
            this.xrLabelQuantity.StylePriority.UseBorders = false;
            this.xrLabelQuantity.StylePriority.UseFont = false;
            this.xrLabelQuantity.StylePriority.UsePadding = false;
            this.xrLabelQuantity.StylePriority.UseTextAlignment = false;
            this.xrLabelQuantity.Text = "xxx";
            this.xrLabelQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabelProductName
            // 
            this.xrLabelProductName.BorderColor = System.Drawing.Color.Gray;
            this.xrLabelProductName.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabelProductName.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabelProductName.Font = new System.Drawing.Font("Oswald", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabelProductName.LocationFloat = new DevExpress.Utils.PointFloat(24.3097F, 0F);
            this.xrLabelProductName.Name = "xrLabelProductName";
            this.xrLabelProductName.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F);
            this.xrLabelProductName.SizeF = new System.Drawing.SizeF(262.0037F, 30F);
            this.xrLabelProductName.StylePriority.UseBorderColor = false;
            this.xrLabelProductName.StylePriority.UseBorderDashStyle = false;
            this.xrLabelProductName.StylePriority.UseBorders = false;
            this.xrLabelProductName.StylePriority.UseFont = false;
            this.xrLabelProductName.StylePriority.UsePadding = false;
            this.xrLabelProductName.StylePriority.UseTextAlignment = false;
            this.xrLabelProductName.Text = "xxx";
            this.xrLabelProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // efDataSource1
            // 
            this.efDataSource1.ConnectionParameters = null;
            this.efDataSource1.Name = "efDataSource1";
            // 
            // xrTableOrderDetail
            // 
            this.xrTableOrderDetail.LocationFloat = new DevExpress.Utils.PointFloat(0F, 167F);
            this.xrTableOrderDetail.Name = "xrTableOrderDetail";
            this.xrTableOrderDetail.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6,
            this.xrTableRow2,
            this.xrTableRow3});
            this.xrTableOrderDetail.SizeF = new System.Drawing.SizeF(528F, 56.25F);
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell14,
            this.xrTableCell15,
            this.xrTableCell16,
            this.xrTableCell21});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 1D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCell14.StylePriority.UseFont = false;
            this.xrTableCell14.StylePriority.UsePadding = false;
            this.xrTableCell14.StylePriority.UseTextAlignment = false;
            this.xrTableCell14.Text = "Đơn hàng số:";
            this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell14.Weight = 0.896875361441693D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCell15.StylePriority.UseFont = false;
            this.xrTableCell15.StylePriority.UsePadding = false;
            this.xrTableCell15.StylePriority.UseTextAlignment = false;
            this.xrTableCell15.Text = "0001";
            this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell15.Weight = 1.57563328656195D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCell16.StylePriority.UseFont = false;
            this.xrTableCell16.StylePriority.UsePadding = false;
            this.xrTableCell16.StylePriority.UseTextAlignment = false;
            this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell16.Weight = 0.797985091779144D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCell21.StylePriority.UseFont = false;
            this.xrTableCell21.StylePriority.UsePadding = false;
            this.xrTableCell21.StylePriority.UseTextAlignment = false;
            this.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell21.Weight = 2.0095062777309D;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell17,
            this.xrTableCell22});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UsePadding = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.Text = "Ngày xuất:";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell6.Weight = 0.896875361441693D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.StylePriority.UsePadding = false;
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = "12/12/2012";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell7.Weight = 1.57563328656195D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCell17.StylePriority.UseFont = false;
            this.xrTableCell17.StylePriority.UsePadding = false;
            this.xrTableCell17.StylePriority.UseTextAlignment = false;
            this.xrTableCell17.Text = "Địa chỉ:";
            this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell17.Weight = 0.797985091779144D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCell22.StylePriority.UseFont = false;
            this.xrTableCell22.StylePriority.UsePadding = false;
            this.xrTableCell22.StylePriority.UseTextAlignment = false;
            this.xrTableCell22.Text = "100 Ông Ích Khiêm, TP Đà Nẵng";
            this.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell22.Weight = 2.0095062777309D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell8,
            this.xrTableCell9,
            this.xrTableCell18,
            this.xrTableCell23});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.StylePriority.UsePadding = false;
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.Text = "Khách hàng:";
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell8.Weight = 0.896875361441693D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCell9.StylePriority.UseFont = false;
            this.xrTableCell9.StylePriority.UsePadding = false;
            this.xrTableCell9.StylePriority.UseTextAlignment = false;
            this.xrTableCell9.Text = "Khách hàng lẻ";
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell9.Weight = 1.57563328656195D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCell18.StylePriority.UseFont = false;
            this.xrTableCell18.StylePriority.UsePadding = false;
            this.xrTableCell18.StylePriority.UseTextAlignment = false;
            this.xrTableCell18.Text = "Số điện thoại:";
            this.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell18.Weight = 0.797985091779144D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCell23.StylePriority.UseFont = false;
            this.xrTableCell23.StylePriority.UsePadding = false;
            this.xrTableCell23.StylePriority.UseTextAlignment = false;
            this.xrTableCell23.Text = "0905.123.456";
            this.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell23.Weight = 2.0095062777309D;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 110F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(528F, 56.99998F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "HÓA ĐƠN BÁN HÀNG";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.xrLabel3,
            this.xrPictureBox1,
            this.xrLabel1,
            this.xrTableOrderDetail});
            this.TopMargin.HeightF = 233.25F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Oswald", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.ForeColor = System.Drawing.Color.Gray;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(114.0374F, 40.4343F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(346.875F, 60.19071F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Địa chỉ: 146 Triệu Nữ Vương, P. Hải Châu, Q. Hải Châu, TP Đà Nẵng\r\nĐiện thoại: 02" +
    "36.3.689.696 - Di động: 0935.445.545\r\nEmail: kimhuyhoang.dng@gmail.com\r\nWebsite:" +
    " www.kimhuyhoang.net";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Stencil Std", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(114.0374F, 10.00001F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(233.6539F, 30.43429F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UsePadding = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "KIM HUY HOÀNG";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(100F, 100F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrTable1
            // 
            this.xrTable1.Font = new System.Drawing.Font("DejaVu Sans Mono", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(528F, 30F);
            this.xrTable1.StylePriority.UseFont = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCellProduct,
            this.xrTableCellQuantity,
            this.xrTableCellUnitPrice,
            this.xrTableCellTotalPrice});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell1.BorderColor = System.Drawing.Color.Gray;
            this.xrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell1.BorderWidth = 3F;
            this.xrTableCell1.Font = new System.Drawing.Font("Oswald", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell1.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCell1.StylePriority.UseBackColor = false;
            this.xrTableCell1.StylePriority.UseBorderColor = false;
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseBorderWidth = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseForeColor = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell1.Weight = 0.204407415499971D;
            // 
            // xrTableCellProduct
            // 
            this.xrTableCellProduct.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCellProduct.BorderColor = System.Drawing.Color.Gray;
            this.xrTableCellProduct.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCellProduct.BorderWidth = 3F;
            this.xrTableCellProduct.Font = new System.Drawing.Font("Oswald", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCellProduct.ForeColor = System.Drawing.Color.Black;
            this.xrTableCellProduct.Name = "xrTableCellProduct";
            this.xrTableCellProduct.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCellProduct.StylePriority.UseBackColor = false;
            this.xrTableCellProduct.StylePriority.UseBorderColor = false;
            this.xrTableCellProduct.StylePriority.UseBorders = false;
            this.xrTableCellProduct.StylePriority.UseBorderWidth = false;
            this.xrTableCellProduct.StylePriority.UseFont = false;
            this.xrTableCellProduct.StylePriority.UseForeColor = false;
            this.xrTableCellProduct.StylePriority.UsePadding = false;
            this.xrTableCellProduct.StylePriority.UseTextAlignment = false;
            this.xrTableCellProduct.Text = "Hàng hóa";
            this.xrTableCellProduct.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCellProduct.Weight = 2.20305103474705D;
            // 
            // xrTableCellQuantity
            // 
            this.xrTableCellQuantity.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCellQuantity.BorderColor = System.Drawing.Color.Gray;
            this.xrTableCellQuantity.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCellQuantity.BorderWidth = 3F;
            this.xrTableCellQuantity.Font = new System.Drawing.Font("Oswald", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCellQuantity.ForeColor = System.Drawing.Color.Black;
            this.xrTableCellQuantity.Name = "xrTableCellQuantity";
            this.xrTableCellQuantity.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F);
            this.xrTableCellQuantity.StylePriority.UseBackColor = false;
            this.xrTableCellQuantity.StylePriority.UseBorderColor = false;
            this.xrTableCellQuantity.StylePriority.UseBorders = false;
            this.xrTableCellQuantity.StylePriority.UseBorderWidth = false;
            this.xrTableCellQuantity.StylePriority.UseFont = false;
            this.xrTableCellQuantity.StylePriority.UseForeColor = false;
            this.xrTableCellQuantity.StylePriority.UsePadding = false;
            this.xrTableCellQuantity.StylePriority.UseTextAlignment = false;
            this.xrTableCellQuantity.Text = "Số lượng";
            this.xrTableCellQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCellQuantity.Weight = 0.46905695862117D;
            // 
            // xrTableCellUnitPrice
            // 
            this.xrTableCellUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCellUnitPrice.BorderColor = System.Drawing.Color.Gray;
            this.xrTableCellUnitPrice.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCellUnitPrice.BorderWidth = 3F;
            this.xrTableCellUnitPrice.Font = new System.Drawing.Font("Oswald", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCellUnitPrice.ForeColor = System.Drawing.Color.Black;
            this.xrTableCellUnitPrice.Name = "xrTableCellUnitPrice";
            this.xrTableCellUnitPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F);
            this.xrTableCellUnitPrice.StylePriority.UseBackColor = false;
            this.xrTableCellUnitPrice.StylePriority.UseBorderColor = false;
            this.xrTableCellUnitPrice.StylePriority.UseBorders = false;
            this.xrTableCellUnitPrice.StylePriority.UseBorderWidth = false;
            this.xrTableCellUnitPrice.StylePriority.UseFont = false;
            this.xrTableCellUnitPrice.StylePriority.UseForeColor = false;
            this.xrTableCellUnitPrice.StylePriority.UsePadding = false;
            this.xrTableCellUnitPrice.StylePriority.UseTextAlignment = false;
            this.xrTableCellUnitPrice.Text = "Đơn giá";
            this.xrTableCellUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCellUnitPrice.Weight = 0.562695641231759D;
            // 
            // xrTableCellTotalPrice
            // 
            this.xrTableCellTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCellTotalPrice.BorderColor = System.Drawing.Color.Gray;
            this.xrTableCellTotalPrice.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCellTotalPrice.BorderWidth = 3F;
            this.xrTableCellTotalPrice.Font = new System.Drawing.Font("Oswald", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCellTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.xrTableCellTotalPrice.Name = "xrTableCellTotalPrice";
            this.xrTableCellTotalPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F);
            this.xrTableCellTotalPrice.StylePriority.UseBackColor = false;
            this.xrTableCellTotalPrice.StylePriority.UseBorderColor = false;
            this.xrTableCellTotalPrice.StylePriority.UseBorders = false;
            this.xrTableCellTotalPrice.StylePriority.UseBorderWidth = false;
            this.xrTableCellTotalPrice.StylePriority.UseFont = false;
            this.xrTableCellTotalPrice.StylePriority.UseForeColor = false;
            this.xrTableCellTotalPrice.StylePriority.UsePadding = false;
            this.xrTableCellTotalPrice.StylePriority.UseTextAlignment = false;
            this.xrTableCellTotalPrice.Text = "Thành tiền";
            this.xrTableCellTotalPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCellTotalPrice.Weight = 1.00046268444029D;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 15.10417F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrControlStyle1
            // 
            this.xrControlStyle1.Name = "xrControlStyle1";
            this.xrControlStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // orderDetailsTableAdapter1
            // 
            this.orderDetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // orderDetailsTableAdapter2
            // 
            this.orderDetailsTableAdapter2.ClearBeforeFill = true;
            // 
            // khh_posDataSet1
            // 
            this.khh_posDataSet1.DataSetName = "khh_posDataSet";
            this.khh_posDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unitsTableAdapter
            // 
            this.unitsTableAdapter.ClearBeforeFill = true;
            // 
            // khh_posDataSet2
            // 
            this.khh_posDataSet2.DataSetName = "khh_posDataSet";
            this.khh_posDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel2});
            this.PageFooter.HeightF = 143.2292F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrLabelSumTotal
            // 
            this.xrLabelSumTotal.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "OrderDetails.TotalPrice")});
            this.xrLabelSumTotal.Font = new System.Drawing.Font("Oswald", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabelSumTotal.LocationFloat = new DevExpress.Utils.PointFloat(409.0173F, 0F);
            this.xrLabelSumTotal.Name = "xrLabelSumTotal";
            this.xrLabelSumTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F);
            this.xrLabelSumTotal.SizeF = new System.Drawing.SizeF(118.9826F, 30F);
            this.xrLabelSumTotal.StylePriority.UseBackColor = false;
            this.xrLabelSumTotal.StylePriority.UseFont = false;
            this.xrLabelSumTotal.StylePriority.UseForeColor = false;
            this.xrLabelSumTotal.StylePriority.UsePadding = false;
            this.xrLabelSumTotal.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:n0}";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabelSumTotal.Summary = xrSummary1;
            this.xrLabelSumTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Font = new System.Drawing.Font("Oswald", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(342.0971F, 0F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(66.92014F, 30F);
            this.xrLabel10.StylePriority.UseBackColor = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseForeColor = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "TỔNG CỘNG:";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.GroupHeader1.HeightF = 30F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabelSumTotal,
            this.xrLabel10});
            this.GroupFooter1.HeightF = 30F;
            this.GroupFooter1.Level = 1;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // formattingRule1
            // 
            this.formattingRule1.Name = "formattingRule1";
            // 
            // xrLabelStt
            // 
            this.xrLabelStt.BorderColor = System.Drawing.Color.Gray;
            this.xrLabelStt.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabelStt.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabelStt.Font = new System.Drawing.Font("Oswald", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabelStt.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabelStt.Name = "xrLabelStt";
            this.xrLabelStt.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F);
            this.xrLabelStt.SizeF = new System.Drawing.SizeF(24.30969F, 30F);
            this.xrLabelStt.StylePriority.UseBorderColor = false;
            this.xrLabelStt.StylePriority.UseBorderDashStyle = false;
            this.xrLabelStt.StylePriority.UseBorders = false;
            this.xrLabelStt.StylePriority.UseFont = false;
            this.xrLabelStt.StylePriority.UsePadding = false;
            this.xrLabelStt.StylePriority.UseTextAlignment = false;
            this.xrLabelStt.Text = "xxx";
            this.xrLabelStt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Oswald", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 28.14585F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(237.2509F, 20.74998F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Người mua hàng";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Oswald", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(286.3134F, 10.00001F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(231.6866F, 18.14585F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Đà Nẵng, ngày ... tháng ... năm 2017";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Oswald", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(286.3134F, 28.14585F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(231.6866F, 20.74998F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Người bán hàng";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // rpReceipt
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageFooter,
            this.GroupHeader1,
            this.GroupFooter1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.efDataSource1});
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1});
            this.Margins = new System.Drawing.Printing.Margins(27, 28, 233, 15);
            this.PageHeight = 827;
            this.PageWidth = 583;
            this.PaperKind = System.Drawing.Printing.PaperKind.A5;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.xrControlStyle1});
            this.Version = "15.1";
            ((System.ComponentModel.ISupportInitialize)(this.efDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyle1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRTable xrTableOrderDetail;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellProduct;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellQuantity;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellUnitPrice;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellTotalPrice;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell14;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell15;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell16;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell21;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell17;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell22;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell18;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell23;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private khh_posDataSetTableAdapters.OrderDetailsTableAdapter orderDetailsTableAdapter1;
        private khh_posDataSetTableAdapters.OrderDetailsTableAdapter orderDetailsTableAdapter2;
        private khh_posDataSet khh_posDataSet1;
        private khh_posDataSetTableAdapters.UnitsTableAdapter unitsTableAdapter;
        private khh_posDataSet khh_posDataSet2;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabelSumTotal;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.DataAccess.EntityFramework.EFDataSource efDataSource1;
        private DevExpress.XtraReports.UI.XRLabel xrLabelProductName;
        private DevExpress.XtraReports.UI.XRLabel xrLabelTotalPrice;
        private DevExpress.XtraReports.UI.XRLabel xrLabelUnitPrice;
        private DevExpress.XtraReports.UI.XRLabel xrLabelQuantity;
        private DevExpress.XtraReports.UI.FormattingRule formattingRule1;
        private DevExpress.XtraReports.UI.XRLabel xrLabelStt;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
    }
}
