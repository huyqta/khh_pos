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
            this.colProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuanlity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRevenue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnInitialDay = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.dtSelectDate = new DevExpress.XtraEditors.DateEdit();
            this.saleStatisticTableAdapter = new MyPos.khh_posDataSetTableAdapters.SaleStatisticTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcSaleStatistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleStatisticBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSaleStatistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSelectDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSelectDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSaleStatistic
            // 
            this.gcSaleStatistic.DataSource = this.saleStatisticBindingSource;
            this.gcSaleStatistic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcSaleStatistic.Location = new System.Drawing.Point(0, 77);
            this.gcSaleStatistic.MainView = this.gvSaleStatistic;
            this.gcSaleStatistic.Name = "gcSaleStatistic";
            this.gcSaleStatistic.Size = new System.Drawing.Size(1526, 719);
            this.gcSaleStatistic.TabIndex = 0;
            this.gcSaleStatistic.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSaleStatistic});
            this.gcSaleStatistic.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gcSaleStatistic_ProcessGridKey);
            this.gcSaleStatistic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcSaleStatistic_KeyDown);
            // 
            // saleStatisticBindingSource
            // 
            this.saleStatisticBindingSource.DataMember = "SaleStatistic";
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
            this.colProductId,
            this.colProductName,
            this.colUnitId,
            this.colUnitName,
            this.colQuanlity,
            this.colUnitPrice,
            this.colTotalPrice,
            this.colRevenue});
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
            // 
            // colUnitId
            // 
            this.colUnitId.FieldName = "UnitId";
            this.colUnitId.Name = "colUnitId";
            this.colUnitId.OptionsColumn.AllowEdit = false;
            // 
            // colUnitName
            // 
            this.colUnitName.Caption = "Đơn vị tính";
            this.colUnitName.FieldName = "UnitName";
            this.colUnitName.Name = "colUnitName";
            this.colUnitName.OptionsColumn.AllowEdit = false;
            this.colUnitName.Visible = true;
            this.colUnitName.VisibleIndex = 1;
            // 
            // colQuanlity
            // 
            this.colQuanlity.Caption = "Số lượng";
            this.colQuanlity.FieldName = "Quanlity";
            this.colQuanlity.Name = "colQuanlity";
            this.colQuanlity.OptionsColumn.AllowEdit = false;
            this.colQuanlity.Visible = true;
            this.colQuanlity.VisibleIndex = 2;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "Đơn giá";
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.OptionsColumn.AllowEdit = false;
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 3;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "Thành tiền";
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.OptionsColumn.AllowEdit = false;
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 4;
            // 
            // colRevenue
            // 
            this.colRevenue.Caption = "Tiền lời";
            this.colRevenue.FieldName = "Revenue";
            this.colRevenue.Name = "colRevenue";
            this.colRevenue.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Revenue", "{0:n0}")});
            this.colRevenue.Visible = true;
            this.colRevenue.VisibleIndex = 5;
            // 
            // btnInitialDay
            // 
            this.btnInitialDay.Location = new System.Drawing.Point(12, 12);
            this.btnInitialDay.Name = "btnInitialDay";
            this.btnInitialDay.Size = new System.Drawing.Size(351, 53);
            this.btnInitialDay.TabIndex = 1;
            this.btnInitialDay.Text = "Tổng hợp bán hàng trong ngày";
            this.btnInitialDay.Click += new System.EventHandler(this.btnInitialDay_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(369, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(218, 53);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu doanh thu";
            // 
            // dtSelectDate
            // 
            this.dtSelectDate.EditValue = null;
            this.dtSelectDate.Location = new System.Drawing.Point(1283, 23);
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
            // frmSaleStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 796);
            this.Controls.Add(this.dtSelectDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnInitialDay);
            this.Controls.Add(this.gcSaleStatistic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSaleStatistic";
            this.Text = "frmSaleStatistic";
            this.Load += new System.EventHandler(this.frmSaleStatistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcSaleStatistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleStatisticBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSaleStatistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSelectDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSelectDate.Properties)).EndInit();
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
        private khh_posDataSetTableAdapters.SaleStatisticTableAdapter saleStatisticTableAdapter;
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
    }
}