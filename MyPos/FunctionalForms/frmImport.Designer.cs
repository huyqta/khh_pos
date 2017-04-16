namespace MyPos.FunctionalForms
{
    partial class frmImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImport));
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.gcOrders = new DevExpress.XtraGrid.GridControl();
            this.importsBindingSource = new System.Windows.Forms.BindingSource();
            this.khh_posDataSet = new MyPos.khh_posDataSet();
            this.gvOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.OrderCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrderDateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPrice_Order = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.rdSelectDateOrder = new DevExpress.XtraEditors.RadioGroup();
            this.dtSelectDateOrder = new DevExpress.XtraEditors.DateEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.gcOrderDetail = new DevExpress.XtraGrid.GridControl();
            this.importDetailsBindingSource = new System.Windows.Forms.BindingSource();
            this.gvOrderDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpProduct = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productsBindingSource = new System.Windows.Forms.BindingSource();
            this.UnitId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpUnit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.unitsBindingSource = new System.Windows.Forms.BindingSource();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpProduct = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpVendor = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnAddProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewOrder = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnSubmitOrder = new DevExpress.XtraEditors.SimpleButton();
            this.lblOrderCode = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource();
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource();
            this.vendorsTableAdapter = new MyPos.khh_posDataSetTableAdapters.VendorsTableAdapter();
            this.importDetailsTableAdapter = new MyPos.khh_posDataSetTableAdapters.ImportDetailsTableAdapter();
            this.unitsTableAdapter = new MyPos.khh_posDataSetTableAdapters.UnitsTableAdapter();
            this.productsTableAdapter = new MyPos.khh_posDataSetTableAdapters.ProductsTableAdapter();
            this.importsTableAdapter = new MyPos.khh_posDataSetTableAdapters.ImportsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdSelectDateOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSelectDateOrder.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSelectDateOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpVendor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.gcOrders);
            this.groupControl4.Controls.Add(this.groupControl7);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(0, 0);
            this.groupControl4.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(1455, 469);
            this.groupControl4.TabIndex = 14;
            this.groupControl4.Text = "Danh sách đơn hàng";
            // 
            // gcOrders
            // 
            this.gcOrders.DataSource = this.importsBindingSource;
            this.gcOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcOrders.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcOrders.Location = new System.Drawing.Point(3, 100);
            this.gcOrders.MainView = this.gvOrders;
            this.gcOrders.Margin = new System.Windows.Forms.Padding(4);
            this.gcOrders.Name = "gcOrders";
            this.gcOrders.Size = new System.Drawing.Size(1449, 366);
            this.gcOrders.TabIndex = 13;
            this.gcOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrders});
            // 
            // importsBindingSource
            // 
            this.importsBindingSource.DataMember = "Imports";
            this.importsBindingSource.DataSource = this.khh_posDataSet;
            // 
            // khh_posDataSet
            // 
            this.khh_posDataSet.DataSetName = "khh_posDataSet";
            this.khh_posDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvOrders
            // 
            this.gvOrders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.OrderCode,
            this.OrderDateTime,
            this.TotalPrice_Order});
            this.gvOrders.GridControl = this.gcOrders;
            this.gvOrders.Name = "gvOrders";
            this.gvOrders.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.OrderCode, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gvOrders.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvOrders_FocusedRowChanged);
            // 
            // OrderCode
            // 
            this.OrderCode.Caption = "Mã đơn hàng";
            this.OrderCode.FieldName = "OrderCode";
            this.OrderCode.Name = "OrderCode";
            this.OrderCode.OptionsColumn.AllowEdit = false;
            this.OrderCode.Visible = true;
            this.OrderCode.VisibleIndex = 0;
            // 
            // OrderDateTime
            // 
            this.OrderDateTime.Caption = "Ngày tạo";
            this.OrderDateTime.FieldName = "OrderDateTime";
            this.OrderDateTime.Name = "OrderDateTime";
            this.OrderDateTime.OptionsColumn.AllowEdit = false;
            this.OrderDateTime.Visible = true;
            this.OrderDateTime.VisibleIndex = 1;
            // 
            // TotalPrice_Order
            // 
            this.TotalPrice_Order.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TotalPrice_Order.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold);
            this.TotalPrice_Order.AppearanceCell.ForeColor = System.Drawing.Color.Maroon;
            this.TotalPrice_Order.AppearanceCell.Options.UseBackColor = true;
            this.TotalPrice_Order.AppearanceCell.Options.UseFont = true;
            this.TotalPrice_Order.AppearanceCell.Options.UseForeColor = true;
            this.TotalPrice_Order.Caption = "Tổng tiền";
            this.TotalPrice_Order.DisplayFormat.FormatString = "{0:n0}";
            this.TotalPrice_Order.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TotalPrice_Order.FieldName = "TotalPrice";
            this.TotalPrice_Order.Name = "TotalPrice_Order";
            this.TotalPrice_Order.OptionsColumn.AllowEdit = false;
            this.TotalPrice_Order.Visible = true;
            this.TotalPrice_Order.VisibleIndex = 2;
            // 
            // groupControl7
            // 
            this.groupControl7.Controls.Add(this.rdSelectDateOrder);
            this.groupControl7.Controls.Add(this.dtSelectDateOrder);
            this.groupControl7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl7.Location = new System.Drawing.Point(3, 40);
            this.groupControl7.Margin = new System.Windows.Forms.Padding(6);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.ShowCaption = false;
            this.groupControl7.Size = new System.Drawing.Size(1449, 60);
            this.groupControl7.TabIndex = 16;
            this.groupControl7.Text = "groupControl7";
            // 
            // rdSelectDateOrder
            // 
            this.rdSelectDateOrder.EditValue = true;
            this.rdSelectDateOrder.Location = new System.Drawing.Point(8, 8);
            this.rdSelectDateOrder.Margin = new System.Windows.Forms.Padding(4);
            this.rdSelectDateOrder.Name = "rdSelectDateOrder";
            this.rdSelectDateOrder.Properties.Columns = 4;
            this.rdSelectDateOrder.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Hôm nay", true, "today"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "1 ngày trước", true, "yesterday"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Chọn ngày", true, "selectdate")});
            this.rdSelectDateOrder.Size = new System.Drawing.Size(580, 46);
            this.rdSelectDateOrder.TabIndex = 14;
            this.rdSelectDateOrder.SelectedIndexChanged += new System.EventHandler(this.rdSelectDateOrder_SelectedIndexChanged);
            // 
            // dtSelectDateOrder
            // 
            this.dtSelectDateOrder.EditValue = null;
            this.dtSelectDateOrder.Location = new System.Drawing.Point(594, 8);
            this.dtSelectDateOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dtSelectDateOrder.Name = "dtSelectDateOrder";
            this.dtSelectDateOrder.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSelectDateOrder.Properties.Appearance.Options.UseFont = true;
            this.dtSelectDateOrder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtSelectDateOrder.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtSelectDateOrder.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dtSelectDateOrder.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dtSelectDateOrder.Size = new System.Drawing.Size(246, 42);
            this.dtSelectDateOrder.TabIndex = 15;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.splitContainerControl2);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1461, 1188);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Thông tin bán hàng";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(3, 40);
            this.splitContainerControl2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl5);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl4);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1455, 1145);
            this.splitContainerControl2.SplitterPosition = 666;
            this.splitContainerControl2.TabIndex = 18;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.gcOrderDetail);
            this.groupControl5.Controls.Add(this.groupControl6);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl5.Location = new System.Drawing.Point(0, 0);
            this.groupControl5.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(1455, 666);
            this.groupControl5.TabIndex = 16;
            this.groupControl5.Text = "Chi tiết đơn hàng";
            // 
            // gcOrderDetail
            // 
            this.gcOrderDetail.DataSource = this.importDetailsBindingSource;
            this.gcOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcOrderDetail.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcOrderDetail.Location = new System.Drawing.Point(3, 210);
            this.gcOrderDetail.MainView = this.gvOrderDetail;
            this.gcOrderDetail.Margin = new System.Windows.Forms.Padding(4);
            this.gcOrderDetail.Name = "gcOrderDetail";
            this.gcOrderDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpProduct,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpUnit});
            this.gcOrderDetail.Size = new System.Drawing.Size(1449, 453);
            this.gcOrderDetail.TabIndex = 13;
            this.gcOrderDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrderDetail});
            // 
            // importDetailsBindingSource
            // 
            this.importDetailsBindingSource.DataMember = "ImportDetails";
            this.importDetailsBindingSource.DataSource = this.khh_posDataSet;
            // 
            // gvOrderDetail
            // 
            this.gvOrderDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProductId,
            this.UnitId,
            this.Quantity,
            this.UnitPrice,
            this.TotalPrice});
            this.gvOrderDetail.GridControl = this.gcOrderDetail;
            this.gvOrderDetail.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", this.TotalPrice, "(Thành tiền: SUM={0:n0})")});
            this.gvOrderDetail.Name = "gvOrderDetail";
            this.gvOrderDetail.OptionsView.ShowFooter = true;
            this.gvOrderDetail.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvOrderDetail_CellValueChanged);
            // 
            // ProductId
            // 
            this.ProductId.Caption = "Hàng hóa";
            this.ProductId.ColumnEdit = this.repositoryItemLookUpProduct;
            this.ProductId.FieldName = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.Visible = true;
            this.ProductId.VisibleIndex = 0;
            // 
            // repositoryItemLookUpProduct
            // 
            this.repositoryItemLookUpProduct.AutoHeight = false;
            this.repositoryItemLookUpProduct.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpProduct.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.repositoryItemLookUpProduct.DataSource = this.productsBindingSource;
            this.repositoryItemLookUpProduct.DisplayMember = "Name";
            this.repositoryItemLookUpProduct.Name = "repositoryItemLookUpProduct";
            this.repositoryItemLookUpProduct.ValueMember = "Id";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.khh_posDataSet;
            // 
            // UnitId
            // 
            this.UnitId.Caption = "Đơn vị tính";
            this.UnitId.ColumnEdit = this.repositoryItemLookUpUnit;
            this.UnitId.FieldName = "UnitId";
            this.UnitId.Name = "UnitId";
            this.UnitId.OptionsColumn.AllowEdit = false;
            this.UnitId.Visible = true;
            this.UnitId.VisibleIndex = 1;
            // 
            // repositoryItemLookUpUnit
            // 
            this.repositoryItemLookUpUnit.AutoHeight = false;
            this.repositoryItemLookUpUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpUnit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 43, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 114, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpUnit.DataSource = this.unitsBindingSource;
            this.repositoryItemLookUpUnit.DisplayMember = "Name";
            this.repositoryItemLookUpUnit.Name = "repositoryItemLookUpUnit";
            this.repositoryItemLookUpUnit.ValueMember = "Id";
            // 
            // unitsBindingSource
            // 
            this.unitsBindingSource.DataMember = "Units";
            this.unitsBindingSource.DataSource = this.khh_posDataSet;
            // 
            // Quantity
            // 
            this.Quantity.Caption = "Số lượng";
            this.Quantity.DisplayFormat.FormatString = "{0:n2}";
            this.Quantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Quantity.FieldName = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 2;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Caption = "Đơn giá";
            this.UnitPrice.DisplayFormat.FormatString = "{0:n0}";
            this.UnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.UnitPrice.FieldName = "UnitPrice";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Visible = true;
            this.UnitPrice.VisibleIndex = 3;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TotalPrice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TotalPrice.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TotalPrice.AppearanceCell.Options.UseBackColor = true;
            this.TotalPrice.AppearanceCell.Options.UseFont = true;
            this.TotalPrice.AppearanceCell.Options.UseForeColor = true;
            this.TotalPrice.Caption = "Thành tiền";
            this.TotalPrice.DisplayFormat.FormatString = "{0:n0}";
            this.TotalPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TotalPrice.FieldName = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.OptionsColumn.AllowEdit = false;
            this.TotalPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", "Tổng cộng={0:n0}")});
            this.TotalPrice.Visible = true;
            this.TotalPrice.VisibleIndex = 4;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.repositoryItemLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "Id";
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.lookUpProduct);
            this.groupControl6.Controls.Add(this.lookUpVendor);
            this.groupControl6.Controls.Add(this.labelControl3);
            this.groupControl6.Controls.Add(this.btnAddProduct);
            this.groupControl6.Controls.Add(this.btnNewOrder);
            this.groupControl6.Controls.Add(this.labelControl2);
            this.groupControl6.Controls.Add(this.btnSubmitOrder);
            this.groupControl6.Controls.Add(this.lblOrderCode);
            this.groupControl6.Controls.Add(this.labelControl1);
            this.groupControl6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl6.Location = new System.Drawing.Point(3, 40);
            this.groupControl6.Margin = new System.Windows.Forms.Padding(6);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.ShowCaption = false;
            this.groupControl6.Size = new System.Drawing.Size(1449, 170);
            this.groupControl6.TabIndex = 20;
            this.groupControl6.Text = "groupControl6";
            // 
            // lookUpProduct
            // 
            this.lookUpProduct.Location = new System.Drawing.Point(174, 119);
            this.lookUpProduct.Name = "lookUpProduct";
            this.lookUpProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpProduct.Properties.NullText = "Chọn hàng hóa ...";
            this.lookUpProduct.Size = new System.Drawing.Size(554, 34);
            this.lookUpProduct.TabIndex = 20;
            // 
            // lookUpVendor
            // 
            this.lookUpVendor.Location = new System.Drawing.Point(174, 79);
            this.lookUpVendor.Name = "lookUpVendor";
            this.lookUpVendor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpVendor.Properties.NullText = "Chọn nhà cung cấp ...";
            this.lookUpVendor.Size = new System.Drawing.Size(554, 34);
            this.lookUpVendor.TabIndex = 20;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 123);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(109, 25);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Chọn hàng:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAddProduct.Location = new System.Drawing.Point(735, 119);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(71, 34);
            this.btnAddProduct.TabIndex = 14;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(8, 8);
            this.btnNewOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(176, 54);
            this.btnNewOrder.TabIndex = 14;
            this.btnNewOrder.Text = "Phiếu nhập mới";
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 83);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(137, 25);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Nhà cung cấp:";
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Location = new System.Drawing.Point(192, 10);
            this.btnSubmitOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(220, 54);
            this.btnSubmitOrder.TabIndex = 15;
            this.btnSubmitOrder.Text = "Lưu phiếu nhập kho";
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // lblOrderCode
            // 
            this.lblOrderCode.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderCode.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOrderCode.Location = new System.Drawing.Point(644, 14);
            this.lblOrderCode.Margin = new System.Windows.Forms.Padding(4);
            this.lblOrderCode.Name = "lblOrderCode";
            this.lblOrderCode.Size = new System.Drawing.Size(42, 39);
            this.lblOrderCode.TabIndex = 16;
            this.lblOrderCode.Text = "---";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl1.Location = new System.Drawing.Point(420, 14);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(217, 39);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Mã đơn hàng:";
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.khh_posDataSet;
            // 
            // vendorsBindingSource
            // 
            this.vendorsBindingSource.DataMember = "Vendors";
            this.vendorsBindingSource.DataSource = this.khh_posDataSet;
            // 
            // vendorsTableAdapter
            // 
            this.vendorsTableAdapter.ClearBeforeFill = true;
            // 
            // importDetailsTableAdapter
            // 
            this.importDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // unitsTableAdapter
            // 
            this.unitsTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // importsTableAdapter
            // 
            this.importsTableAdapter.ClearBeforeFill = true;
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 1188);
            this.Controls.Add(this.groupControl3);
            this.Name = "frmImport";
            this.Text = "Nhập kho";
            this.Load += new System.EventHandler(this.frmImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdSelectDateOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSelectDateOrder.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSelectDateOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.groupControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpVendor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl gcOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOrders;
        private DevExpress.XtraGrid.Columns.GridColumn OrderCode;
        private DevExpress.XtraGrid.Columns.GridColumn OrderDateTime;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPrice_Order;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private DevExpress.XtraEditors.RadioGroup rdSelectDateOrder;
        private DevExpress.XtraEditors.DateEdit dtSelectDateOrder;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraGrid.GridControl gcOrderDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOrderDetail;
        private DevExpress.XtraGrid.Columns.GridColumn ProductId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpProduct;
        private DevExpress.XtraGrid.Columns.GridColumn UnitId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpUnit;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn UnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.SimpleButton btnNewOrder;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSubmitOrder;
        private DevExpress.XtraEditors.LabelControl lblOrderCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private khh_posDataSet khh_posDataSet;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private khh_posDataSetTableAdapters.VendorsTableAdapter vendorsTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit lookUpVendor;
        private System.Windows.Forms.BindingSource importDetailsBindingSource;
        private khh_posDataSetTableAdapters.ImportDetailsTableAdapter importDetailsTableAdapter;
        private System.Windows.Forms.BindingSource unitsBindingSource;
        private khh_posDataSetTableAdapters.UnitsTableAdapter unitsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private khh_posDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource importsBindingSource;
        private khh_posDataSetTableAdapters.ImportsTableAdapter importsTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit lookUpProduct;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnAddProduct;
    }
}