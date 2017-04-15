namespace MyPos.FunctionalForms
{
    partial class frmInventory
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
            this.btnInitialize = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcInventory = new DevExpress.XtraGrid.GridControl();
            this.gvInventory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Product = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khh_posDataSet = new MyPos.khh_posDataSet();
            this.Unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.unitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MinQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productsTableAdapter = new MyPos.khh_posDataSetTableAdapters.ProductsTableAdapter();
            this.unitsTableAdapter = new MyPos.khh_posDataSetTableAdapters.UnitsTableAdapter();
            this.chkShowRedItemOnly = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowRedItemOnly.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInitialize
            // 
            this.btnInitialize.Location = new System.Drawing.Point(10, 44);
            this.btnInitialize.Margin = new System.Windows.Forms.Padding(6);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(252, 48);
            this.btnInitialize.TabIndex = 0;
            this.btnInitialize.Text = "Khởi tạo số lượng";
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chkShowRedItemOnly);
            this.groupControl1.Controls.Add(this.btnInitialize);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1906, 102);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Quản lý kho hàng";
            // 
            // gcInventory
            // 
            this.gcInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcInventory.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gcInventory.Location = new System.Drawing.Point(0, 102);
            this.gcInventory.MainView = this.gvInventory;
            this.gcInventory.Margin = new System.Windows.Forms.Padding(6);
            this.gcInventory.Name = "gcInventory";
            this.gcInventory.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2});
            this.gcInventory.Size = new System.Drawing.Size(1906, 821);
            this.gcInventory.TabIndex = 2;
            this.gcInventory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInventory});
            this.gcInventory.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.gcInventory_PreviewKeyDown);
            // 
            // gvInventory
            // 
            this.gvInventory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Product,
            this.Unit,
            this.Quantity,
            this.MinQuantity});
            this.gvInventory.GridControl = this.gcInventory;
            this.gvInventory.Name = "gvInventory";
            this.gvInventory.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvInventory_RowStyle);
            // 
            // Product
            // 
            this.Product.Caption = "Hàng hóa";
            this.Product.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.Product.FieldName = "ProductId";
            this.Product.Name = "Product";
            this.Product.OptionsColumn.AllowEdit = false;
            this.Product.Visible = true;
            this.Product.VisibleIndex = 0;
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
            // Unit
            // 
            this.Unit.Caption = "Đơn vị tính";
            this.Unit.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.Unit.FieldName = "UnitId";
            this.Unit.Name = "Unit";
            this.Unit.OptionsColumn.AllowEdit = false;
            this.Unit.Visible = true;
            this.Unit.VisibleIndex = 1;
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
            this.Quantity.Caption = "Số lượng hiện tại";
            this.Quantity.FieldName = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.OptionsColumn.AllowEdit = false;
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 2;
            // 
            // MinQuantity
            // 
            this.MinQuantity.Caption = "Số lượng tối thiểu";
            this.MinQuantity.FieldName = "MinQuantity";
            this.MinQuantity.Name = "MinQuantity";
            this.MinQuantity.Visible = true;
            this.MinQuantity.VisibleIndex = 3;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // unitsTableAdapter
            // 
            this.unitsTableAdapter.ClearBeforeFill = true;
            // 
            // chkShowRedItemOnly
            // 
            this.chkShowRedItemOnly.Location = new System.Drawing.Point(271, 51);
            this.chkShowRedItemOnly.Name = "chkShowRedItemOnly";
            this.chkShowRedItemOnly.Properties.Caption = "Chỉ hiển thị hàng dưới số lượng tối thiểu";
            this.chkShowRedItemOnly.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.chkShowRedItemOnly.Size = new System.Drawing.Size(445, 34);
            this.chkShowRedItemOnly.TabIndex = 1;
            this.chkShowRedItemOnly.CheckedChanged += new System.EventHandler(this.chkShowRedItemOnly_CheckedChanged);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1906, 923);
            this.Controls.Add(this.gcInventory);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmInventory";
            this.Text = "Quản lý kho";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowRedItemOnly.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnInitialize;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcInventory;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInventory;
        private DevExpress.XtraGrid.Columns.GridColumn Product;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Unit;
        private khh_posDataSet khh_posDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private khh_posDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private System.Windows.Forms.BindingSource unitsBindingSource;
        private khh_posDataSetTableAdapters.UnitsTableAdapter unitsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn MinQuantity;
        private DevExpress.XtraEditors.CheckEdit chkShowRedItemOnly;
    }
}