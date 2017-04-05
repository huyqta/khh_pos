namespace MyPos.FunctionalForms
{
    partial class frmSaleForm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcCategory = new DevExpress.XtraGrid.GridControl();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khh_posDataSet = new MyPos.khh_posDataSet();
            this.winExplorerView_Category = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcProducts = new DevExpress.XtraGrid.GridControl();
            this.winExplorerView_Product = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ImageUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.lblOrderCode = new DevExpress.XtraEditors.LabelControl();
            this.btnSubmitOrder = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewOrder = new DevExpress.XtraEditors.SimpleButton();
            this.gcOrderDetail = new DevExpress.XtraGrid.GridControl();
            this.gvOrderDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.dtSelectDateOrder = new DevExpress.XtraEditors.DateEdit();
            this.rdSelectDateOrder = new DevExpress.XtraEditors.RadioGroup();
            this.gcOrders = new DevExpress.XtraGrid.GridControl();
            this.gvOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.categoriesTableAdapter = new MyPos.khh_posDataSetTableAdapters.CategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSelectDateOrder.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSelectDateOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdSelectDateOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gcCategory);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(553, 515);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Nhóm hàng";
            // 
            // gcCategory
            // 
            this.gcCategory.DataSource = this.categoriesBindingSource;
            this.gcCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCategory.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gcCategory.Location = new System.Drawing.Point(3, 40);
            this.gcCategory.MainView = this.winExplorerView_Category;
            this.gcCategory.Margin = new System.Windows.Forms.Padding(6);
            this.gcCategory.Name = "gcCategory";
            this.gcCategory.Size = new System.Drawing.Size(547, 472);
            this.gcCategory.TabIndex = 0;
            this.gcCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.winExplorerView_Category});
            this.gcCategory.Click += new System.EventHandler(this.gcCategory_Click);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.khh_posDataSet;
            // 
            // khh_posDataSet
            // 
            this.khh_posDataSet.DataSetName = "khh_posDataSet";
            this.khh_posDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // winExplorerView_Category
            // 
            this.winExplorerView_Category.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colImageUrl,
            this.colDescription});
            this.winExplorerView_Category.ColumnSet.SmallImageColumn = this.colImageUrl;
            this.winExplorerView_Category.ColumnSet.TextColumn = this.colName;
            this.winExplorerView_Category.GridControl = this.gcCategory;
            this.winExplorerView_Category.Name = "winExplorerView_Category";
            this.winExplorerView_Category.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Medium;
            this.winExplorerView_Category.OptionsViewStyles.Content.ItemWidth = 340;
            this.winExplorerView_Category.ItemClick += new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewItemClickEventHandler(this.winExplorerView_Category_ItemClick);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colImageUrl
            // 
            this.colImageUrl.FieldName = "ImageUrl";
            this.colImageUrl.Name = "colImageUrl";
            this.colImageUrl.Visible = true;
            this.colImageUrl.VisibleIndex = 2;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gcProducts);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 523);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(553, 746);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Hàng hóa";
            // 
            // gcProducts
            // 
            this.gcProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProducts.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gcProducts.Location = new System.Drawing.Point(3, 40);
            this.gcProducts.MainView = this.winExplorerView_Product;
            this.gcProducts.Margin = new System.Windows.Forms.Padding(6);
            this.gcProducts.Name = "gcProducts";
            this.gcProducts.Size = new System.Drawing.Size(547, 703);
            this.gcProducts.TabIndex = 1;
            this.gcProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.winExplorerView_Product});
            // 
            // winExplorerView_Product
            // 
            this.winExplorerView_Product.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Name,
            this.Description,
            this.ImageUrl});
            this.winExplorerView_Product.ColumnSet.DescriptionColumn = this.Description;
            this.winExplorerView_Product.ColumnSet.SmallImageColumn = this.ImageUrl;
            this.winExplorerView_Product.ColumnSet.SmallImageIndexColumn = this.ImageUrl;
            this.winExplorerView_Product.ColumnSet.TextColumn = this.Name;
            this.winExplorerView_Product.GridControl = this.gcProducts;
            this.winExplorerView_Product.Name = "winExplorerView_Product";
            this.winExplorerView_Product.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Medium;
            this.winExplorerView_Product.ItemDoubleClick += new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewItemDoubleClickEventHandler(this.winExplorerView_Product_ItemDoubleClick);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            // 
            // Name
            // 
            this.Name.Caption = "Name";
            this.Name.FieldName = "Name";
            this.Name.Name = "Name";
            this.Name.Visible = true;
            this.Name.VisibleIndex = 0;
            // 
            // Description
            // 
            this.Description.Caption = "Description";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 0;
            // 
            // ImageUrl
            // 
            this.ImageUrl.Caption = "ImageUrl";
            this.ImageUrl.FieldName = "ImageUrl";
            this.ImageUrl.Name = "ImageUrl";
            this.ImageUrl.Visible = true;
            this.ImageUrl.VisibleIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.splitContainerControl2);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1068, 1269);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Thông tin bán hàng";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(3, 40);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl5);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl4);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1062, 1226);
            this.splitContainerControl2.SplitterPosition = 436;
            this.splitContainerControl2.TabIndex = 18;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.lblOrderCode);
            this.groupControl5.Controls.Add(this.btnSubmitOrder);
            this.groupControl5.Controls.Add(this.btnNewOrder);
            this.groupControl5.Controls.Add(this.gcOrderDetail);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl5.Location = new System.Drawing.Point(0, 0);
            this.groupControl5.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(1062, 436);
            this.groupControl5.TabIndex = 16;
            this.groupControl5.Text = "Chi tiết đơn hàng";
            // 
            // lblOrderCode
            // 
            this.lblOrderCode.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderCode.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOrderCode.Location = new System.Drawing.Point(189, 47);
            this.lblOrderCode.Name = "lblOrderCode";
            this.lblOrderCode.Size = new System.Drawing.Size(42, 39);
            this.lblOrderCode.TabIndex = 16;
            this.lblOrderCode.Text = "---";
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Location = new System.Drawing.Point(464, 43);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(177, 53);
            this.btnSubmitOrder.TabIndex = 15;
            this.btnSubmitOrder.Text = "Đóng đơn hàng";
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(6, 43);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(177, 53);
            this.btnNewOrder.TabIndex = 14;
            this.btnNewOrder.Text = "Đơn hàng mới";
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // gcOrderDetail
            // 
            this.gcOrderDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcOrderDetail.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcOrderDetail.Location = new System.Drawing.Point(3, 103);
            this.gcOrderDetail.MainView = this.gvOrderDetail;
            this.gcOrderDetail.Margin = new System.Windows.Forms.Padding(4);
            this.gcOrderDetail.Name = "gcOrderDetail";
            this.gcOrderDetail.Size = new System.Drawing.Size(1056, 330);
            this.gcOrderDetail.TabIndex = 13;
            this.gcOrderDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrderDetail});
            // 
            // gvOrderDetail
            // 
            this.gvOrderDetail.GridControl = this.gcOrderDetail;
            this.gvOrderDetail.Name = "gvOrderDetail";
            this.gvOrderDetail.Click += new System.EventHandler(this.gvOrderDetail_Click);
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.dtSelectDateOrder);
            this.groupControl4.Controls.Add(this.rdSelectDateOrder);
            this.groupControl4.Controls.Add(this.gcOrders);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(0, 0);
            this.groupControl4.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(1062, 780);
            this.groupControl4.TabIndex = 14;
            this.groupControl4.Text = "Danh sách đơn hàng";
            // 
            // dtSelectDateOrder
            // 
            this.dtSelectDateOrder.EditValue = null;
            this.dtSelectDateOrder.Location = new System.Drawing.Point(592, 42);
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
            // rdSelectDateOrder
            // 
            this.rdSelectDateOrder.EditValue = true;
            this.rdSelectDateOrder.Location = new System.Drawing.Point(6, 42);
            this.rdSelectDateOrder.Margin = new System.Windows.Forms.Padding(4);
            this.rdSelectDateOrder.Name = "rdSelectDateOrder";
            this.rdSelectDateOrder.Properties.Columns = 4;
            this.rdSelectDateOrder.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Hôm nay", true, "today"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "1 ngày trước", true, "yesterday"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Chọn ngày", true, "selectdate")});
            this.rdSelectDateOrder.Size = new System.Drawing.Size(580, 42);
            this.rdSelectDateOrder.TabIndex = 14;
            this.rdSelectDateOrder.SelectedIndexChanged += new System.EventHandler(this.rdSelectDateOrder_SelectedIndexChanged);
            // 
            // gcOrders
            // 
            this.gcOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcOrders.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcOrders.Location = new System.Drawing.Point(3, 92);
            this.gcOrders.MainView = this.gvOrders;
            this.gcOrders.Margin = new System.Windows.Forms.Padding(4);
            this.gcOrders.Name = "gcOrders";
            this.gcOrders.Size = new System.Drawing.Size(1056, 685);
            this.gcOrders.TabIndex = 13;
            this.gcOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrders});
            // 
            // gvOrders
            // 
            this.gvOrders.GridControl = this.gcOrders;
            this.gvOrders.Name = "gvOrders";
            this.gvOrders.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvOrders_FocusedRowChanged);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl3);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1631, 1269);
            this.splitContainerControl1.SplitterPosition = 553;
            this.splitContainerControl1.TabIndex = 17;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // frmSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1631, 1269);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            //this.Name = "frmSaleForm";
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.frmSaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtSelectDateOrder.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSelectDateOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdSelectDateOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraGrid.GridControl gcOrderDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOrderDetail;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.DateEdit dtSelectDateOrder;
        private DevExpress.XtraEditors.RadioGroup rdSelectDateOrder;
        private DevExpress.XtraGrid.GridControl gcOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOrders;
        private DevExpress.XtraGrid.GridControl gcCategory;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gcProducts;
        private DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView winExplorerView_Category;
        private khh_posDataSet khh_posDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private khh_posDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colImageUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView winExplorerView_Product;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Name;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn ImageUrl;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.LabelControl lblOrderCode;
        private DevExpress.XtraEditors.SimpleButton btnSubmitOrder;
        private DevExpress.XtraEditors.SimpleButton btnNewOrder;
    }
}