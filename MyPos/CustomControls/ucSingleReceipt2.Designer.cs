namespace MyPos.CustomControls
{
    partial class ucSingleReceipt2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSingleReceipt2));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcOrderDetail = new DevExpress.XtraGrid.GridControl();
            this.gvOrderDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khh_posDataSet = new MyPos.khh_posDataSet();
            this.UnitId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.unitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonDeleteItem = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSaveAndPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtCustomerPay = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiscount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lblMoneyReturn = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblPayment = new DevExpress.XtraEditors.LabelControl();
            this.lookCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTotalPrice = new DevExpress.XtraEditors.LabelControl();
            this.lblOrderDateTime = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblOrderCode = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.customersTableAdapter = new MyPos.khh_posDataSetTableAdapters.CustomersTableAdapter();
            this.productsTableAdapter = new MyPos.khh_posDataSetTableAdapters.ProductsTableAdapter();
            this.unitsTableAdapter = new MyPos.khh_posDataSetTableAdapters.UnitsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonDeleteItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerPay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gcOrderDetail
            // 
            this.gcOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcOrderDetail.Location = new System.Drawing.Point(0, 0);
            this.gcOrderDetail.MainView = this.gvOrderDetail;
            this.gcOrderDetail.Name = "gcOrderDetail";
            this.gcOrderDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemButtonDeleteItem});
            this.gcOrderDetail.Size = new System.Drawing.Size(1475, 624);
            this.gcOrderDetail.TabIndex = 0;
            this.gcOrderDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrderDetail});
            // 
            // gvOrderDetail
            // 
            this.gvOrderDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProductId,
            this.UnitId,
            this.Quantity,
            this.UnitPrice,
            this.TotalPrice,
            this.gridColumn1});
            this.gvOrderDetail.GridControl = this.gcOrderDetail;
            this.gvOrderDetail.Name = "gvOrderDetail";
            this.gvOrderDetail.OptionsView.ShowFooter = true;
            this.gvOrderDetail.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvOrderDetail_CellValueChanged);
            // 
            // ProductId
            // 
            this.ProductId.Caption = "Hàng hóa";
            this.ProductId.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.ProductId.FieldName = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.OptionsColumn.AllowEdit = false;
            this.ProductId.Visible = true;
            this.ProductId.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.productsBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "Id";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.khh_posDataSet;
            // 
            // khh_posDataSet
            // 
            this.khh_posDataSet.DataSetName = "khh_posDataSet";
            this.khh_posDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UnitId
            // 
            this.UnitId.Caption = "Đơn vị tính";
            this.UnitId.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.UnitId.FieldName = "UnitId";
            this.UnitId.Name = "UnitId";
            this.UnitId.OptionsColumn.AllowEdit = false;
            this.UnitId.Visible = true;
            this.UnitId.VisibleIndex = 1;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DataSource = this.unitsBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "Name";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "Id";
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
            this.Quantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
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
            this.TotalPrice.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TotalPrice.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TotalPrice.AppearanceCell.Options.UseBackColor = true;
            this.TotalPrice.Caption = "Thành tiền";
            this.TotalPrice.DisplayFormat.FormatString = "{0:n0}";
            this.TotalPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TotalPrice.FieldName = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.OptionsColumn.AllowEdit = false;
            this.TotalPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", "SUM={0:n0}")});
            this.TotalPrice.Visible = true;
            this.TotalPrice.VisibleIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonDeleteItem;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            // 
            // repositoryItemButtonDeleteItem
            // 
            this.repositoryItemButtonDeleteItem.AutoHeight = false;
            this.repositoryItemButtonDeleteItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonDeleteItem.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.repositoryItemButtonDeleteItem.Name = "repositoryItemButtonDeleteItem";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSaveAndPrint);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.btnCancel);
            this.groupControl1.Controls.Add(this.txtCustomerPay);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.txtDiscount);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.lblMoneyReturn);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.lblPayment);
            this.groupControl1.Controls.Add(this.lookCustomer);
            this.groupControl1.Controls.Add(this.lblTotalPrice);
            this.groupControl1.Controls.Add(this.lblOrderDateTime);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.lblOrderCode);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 624);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1475, 455);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin thanh toán";
            // 
            // btnSaveAndPrint
            // 
            this.btnSaveAndPrint.Location = new System.Drawing.Point(1264, 201);
            this.btnSaveAndPrint.Name = "btnSaveAndPrint";
            this.btnSaveAndPrint.Size = new System.Drawing.Size(205, 72);
            this.btnSaveAndPrint.TabIndex = 7;
            this.btnSaveAndPrint.Text = "Lưu + In đơn hàng";
            this.btnSaveAndPrint.Click += new System.EventHandler(this.btnSaveAndPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1264, 123);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(205, 72);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu đơn hàng";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1264, 45);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(205, 72);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Hủy đơn hàng";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCustomerPay
            // 
            this.txtCustomerPay.Location = new System.Drawing.Point(147, 355);
            this.txtCustomerPay.Name = "txtCustomerPay";
            this.txtCustomerPay.Size = new System.Drawing.Size(385, 32);
            this.txtCustomerPay.TabIndex = 6;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(16, 358);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(107, 25);
            this.labelControl10.TabIndex = 5;
            this.labelControl10.Text = "Khách đưa:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(147, 257);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(385, 32);
            this.txtDiscount.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(16, 260);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(90, 25);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Giảm giá:";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(16, 409);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(97, 25);
            this.labelControl12.TabIndex = 3;
            this.labelControl12.Text = "Tiền thừa:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(16, 310);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(114, 25);
            this.labelControl9.TabIndex = 3;
            this.labelControl9.Text = "Thanh toán:";
            // 
            // lblMoneyReturn
            // 
            this.lblMoneyReturn.Location = new System.Drawing.Point(147, 409);
            this.lblMoneyReturn.Name = "lblMoneyReturn";
            this.lblMoneyReturn.Size = new System.Drawing.Size(24, 25);
            this.lblMoneyReturn.TabIndex = 1;
            this.lblMoneyReturn.Text = "---";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(16, 210);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(101, 25);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Tiền hàng:";
            // 
            // lblPayment
            // 
            this.lblPayment.Location = new System.Drawing.Point(147, 310);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(24, 25);
            this.lblPayment.TabIndex = 1;
            this.lblPayment.Text = "---";
            // 
            // lookCustomer
            // 
            this.lookCustomer.Location = new System.Drawing.Point(147, 161);
            this.lookCustomer.Name = "lookCustomer";
            this.lookCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookCustomer.Properties.DataSource = this.customersBindingSource;
            this.lookCustomer.Properties.DisplayMember = "Name";
            this.lookCustomer.Properties.ValueMember = "Id";
            this.lookCustomer.Size = new System.Drawing.Size(385, 34);
            this.lookCustomer.TabIndex = 2;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.khh_posDataSet;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Location = new System.Drawing.Point(147, 210);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(24, 25);
            this.lblTotalPrice.TabIndex = 1;
            this.lblTotalPrice.Text = "---";
            // 
            // lblOrderDateTime
            // 
            this.lblOrderDateTime.Location = new System.Drawing.Point(147, 118);
            this.lblOrderDateTime.Name = "lblOrderDateTime";
            this.lblOrderDateTime.Size = new System.Drawing.Size(24, 25);
            this.lblOrderDateTime.TabIndex = 1;
            this.lblOrderDateTime.Text = "---";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 165);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(118, 25);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Khách hàng:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 118);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 25);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Ngày bán:";
            // 
            // lblOrderCode
            // 
            this.lblOrderCode.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderCode.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblOrderCode.Location = new System.Drawing.Point(239, 58);
            this.lblOrderCode.Name = "lblOrderCode";
            this.lblOrderCode.Size = new System.Drawing.Size(42, 39);
            this.lblOrderCode.TabIndex = 0;
            this.lblOrderCode.Text = "---";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl1.Location = new System.Drawing.Point(16, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(217, 39);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã đơn hàng:";
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // unitsTableAdapter
            // 
            this.unitsTableAdapter.ClearBeforeFill = true;
            // 
            // ucSingleReceipt2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcOrderDetail);
            this.Controls.Add(this.groupControl1);
            this.Name = "ucSingleReceipt2";
            this.Size = new System.Drawing.Size(1475, 1079);
            this.Load += new System.EventHandler(this.ucSingleReceipt2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonDeleteItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerPay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcOrderDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOrderDetail;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblOrderCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit lookCustomer;
        private DevExpress.XtraEditors.LabelControl lblTotalPrice;
        private DevExpress.XtraEditors.LabelControl lblOrderDateTime;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDiscount;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtCustomerPay;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl lblMoneyReturn;
        private DevExpress.XtraEditors.LabelControl lblPayment;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private khh_posDataSet khh_posDataSet;
        private khh_posDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnSaveAndPrint;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraGrid.Columns.GridColumn ProductId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn UnitId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private System.Windows.Forms.BindingSource unitsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn UnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonDeleteItem;
        private khh_posDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private khh_posDataSetTableAdapters.UnitsTableAdapter unitsTableAdapter;
    }
}
