namespace MyPos.FunctionalForms
{
    partial class frmSaleStatistic
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gcSaleStatistic = new DevExpress.XtraGrid.GridControl();
            this.saleStatisticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khh_posDataSet = new MyPos.khh_posDataSet();
            this.gvSaleStatistic = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOrderCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDetailId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuanlity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRevenue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnInitialDay = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.dtSelectDate = new DevExpress.XtraEditors.DateEdit();
            this.saleStatisticTableAdapter = new MyPos.khh_posDataSetTableAdapters.SaleStatisticsTableAdapter();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcSaleStatistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleStatisticBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSaleStatistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSelectDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSelectDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcSaleStatistic
            // 
            this.gcSaleStatistic.DataSource = this.saleStatisticBindingSource;
            this.gcSaleStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSaleStatistic.Location = new System.Drawing.Point(0, 79);
            this.gcSaleStatistic.MainView = this.gvSaleStatistic;
            this.gcSaleStatistic.Name = "gcSaleStatistic";
            this.gcSaleStatistic.Size = new System.Drawing.Size(1526, 717);
            this.gcSaleStatistic.TabIndex = 0;
            this.gcSaleStatistic.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSaleStatistic});
            this.gcSaleStatistic.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gcSaleStatistic_ProcessGridKey);
            this.gcSaleStatistic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcSaleStatistic_KeyDown);
            // 
            // saleStatisticBindingSource
            // 
            this.saleStatisticBindingSource.DataMember = "SaleStatistics";
            this.saleStatisticBindingSource.DataSource = this.khh_posDataSet;
            // 
            // khh_posDataSet
            // 
            this.khh_posDataSet.DataSetName = "khh_posDataSet";
            this.khh_posDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvSaleStatistic
            // 
            this.gvSaleStatistic.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderCode,
            this.colOrderDetailId,
            this.colCustomerName,
            this.colProductId,
            this.colProductName,
            this.colUnitId,
            this.colUnitName,
            this.colQuanlity,
            this.colUnitPrice,
            this.colTotalPrice,
            this.colRevenue,
            this.colCustomerId});
            this.gvSaleStatistic.GridControl = this.gcSaleStatistic;
            this.gvSaleStatistic.GroupCount = 1;
            this.gvSaleStatistic.Name = "gvSaleStatistic";
            this.gvSaleStatistic.OptionsView.ShowFooter = true;
            this.gvSaleStatistic.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colOrderCode, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colOrderCode
            // 
            this.colOrderCode.Caption = "Mã đơn hàng";
            this.colOrderCode.FieldName = "OrderCode";
            this.colOrderCode.Name = "colOrderCode";
            this.colOrderCode.OptionsColumn.AllowEdit = false;
            this.colOrderCode.Visible = true;
            this.colOrderCode.VisibleIndex = 0;
            // 
            // colOrderDetailId
            // 
            this.colOrderDetailId.FieldName = "OrderDetailId";
            this.colOrderDetailId.Name = "colOrderDetailId";
            this.colOrderDetailId.OptionsColumn.AllowEdit = false;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Khách hàng";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsColumn.AllowEdit = false;
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
            this.colCustomerName.Width = 372;
            // 
            // colProductId
            // 
            this.colProductId.FieldName = "ProductId";
            this.colProductId.Name = "colProductId";
            this.colProductId.OptionsColumn.AllowEdit = false;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Hàng hóa";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.AllowEdit = false;
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            this.colProductName.Width = 258;
            // 
            // colUnitId
            // 
            this.colUnitId.FieldName = "UnitId";
            this.colUnitId.Name = "colUnitId";
            this.colUnitId.OptionsColumn.AllowEdit = false;
            // 
            // colUnitName
            // 
            this.colUnitName.Caption = "ĐVT";
            this.colUnitName.FieldName = "UnitName";
            this.colUnitName.Name = "colUnitName";
            this.colUnitName.OptionsColumn.AllowEdit = false;
            this.colUnitName.Visible = true;
            this.colUnitName.VisibleIndex = 2;
            this.colUnitName.Width = 85;
            // 
            // colQuanlity
            // 
            this.colQuanlity.Caption = "Số lượng";
            this.colQuanlity.FieldName = "Quanlity";
            this.colQuanlity.Name = "colQuanlity";
            this.colQuanlity.OptionsColumn.AllowEdit = false;
            this.colQuanlity.Visible = true;
            this.colQuanlity.VisibleIndex = 3;
            this.colQuanlity.Width = 106;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "Đơn giá";
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.OptionsColumn.AllowEdit = false;
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 4;
            this.colUnitPrice.Width = 155;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "Thành tiền";
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.OptionsColumn.AllowEdit = false;
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 5;
            this.colTotalPrice.Width = 212;
            // 
            // colRevenue
            // 
            this.colRevenue.Caption = "Tiền lời";
            this.colRevenue.FieldName = "Revenue";
            this.colRevenue.Name = "colRevenue";
            this.colRevenue.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Revenue", "{0:n0}")});
            this.colRevenue.Visible = true;
            this.colRevenue.VisibleIndex = 6;
            this.colRevenue.Width = 304;
            // 
            // colCustomerId
            // 
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.Name = "colCustomerId";
            // 
            // btnInitialDay
            // 
            this.btnInitialDay.Location = new System.Drawing.Point(6, 12);
            this.btnInitialDay.Name = "btnInitialDay";
            this.btnInitialDay.Size = new System.Drawing.Size(351, 53);
            this.btnInitialDay.TabIndex = 1;
            this.btnInitialDay.Text = "Tổng hợp bán hàng trong ngày";
            this.btnInitialDay.Click += new System.EventHandler(this.btnInitialDay_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(363, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(218, 53);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu doanh thu";
            // 
            // dtSelectDate
            // 
            this.dtSelectDate.EditValue = null;
            this.dtSelectDate.Location = new System.Drawing.Point(587, 23);
            this.dtSelectDate.Name = "dtSelectDate";
            this.dtSelectDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtSelectDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtSelectDate.Size = new System.Drawing.Size(231, 34);
            this.dtSelectDate.TabIndex = 2;
            this.dtSelectDate.DateTimeChanged += new System.EventHandler(this.dtSelectDate_DateTimeChanged);
            // 
            // saleStatisticTableAdapter
            // 
            this.saleStatisticTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.btnInitialDay);
            this.groupControl1.Controls.Add(this.dtSelectDate);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1526, 79);
            this.groupControl1.TabIndex = 3;
            // 
            // frmSaleStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 796);
            this.Controls.Add(this.gcSaleStatistic);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSaleStatistic";
            this.Text = "Thống kê bán hàng";
            this.Load += new System.EventHandler(this.frmSaleStatistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcSaleStatistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleStatisticBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSaleStatistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSelectDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSelectDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcSaleStatistic;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSaleStatistic;
        private DevExpress.XtraEditors.SimpleButton btnInitialDay;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.DateEdit dtSelectDate;
        private khh_posDataSet khh_posDataSet;
        private System.Windows.Forms.BindingSource saleStatisticBindingSource;
        private khh_posDataSetTableAdapters.SaleStatisticsTableAdapter saleStatisticTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderCode;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDetailId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitId;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuanlity;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colRevenue;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}