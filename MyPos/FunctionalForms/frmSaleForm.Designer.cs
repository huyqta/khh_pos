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
            this.winExplorerView1 = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.gcOrderDetail = new DevExpress.XtraGrid.GridControl();
            this.gvOrderDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.dtSelectDateOrder = new DevExpress.XtraEditors.DateEdit();
            this.rdSelectDateOrder = new DevExpress.XtraEditors.RadioGroup();
            this.gcOrders = new DevExpress.XtraGrid.GridControl();
            this.gvOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSubmitSingleProduct = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtProduct = new DevExpress.XtraEditors.TextEdit();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.categoriesTableAdapter = new MyPos.khh_posDataSetTableAdapters.CategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gcCategory);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(356, 268);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Nhóm hàng";
            // 
            // gcCategory
            // 
            this.gcCategory.DataSource = this.categoriesBindingSource;
            this.gcCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCategory.Location = new System.Drawing.Point(2, 20);
            this.gcCategory.MainView = this.winExplorerView1;
            this.gcCategory.Name = "gcCategory";
            this.gcCategory.Size = new System.Drawing.Size(352, 246);
            this.gcCategory.TabIndex = 0;
            this.gcCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.winExplorerView1});
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
            // winExplorerView1
            // 
            this.winExplorerView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colImageUrl,
            this.colDescription});
            this.winExplorerView1.ColumnSet.SmallImageColumn = this.colImageUrl;
            this.winExplorerView1.ColumnSet.TextColumn = this.colName;
            this.winExplorerView1.GridControl = this.gcCategory;
            this.winExplorerView1.Name = "winExplorerView1";
            this.winExplorerView1.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Medium;
            this.winExplorerView1.OptionsViewStyles.Content.ItemWidth = 340;
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
            this.groupControl2.Controls.Add(this.gridControl2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 272);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(356, 388);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Hàng hóa";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 20);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(352, 366);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.groupControl5);
            this.groupControl3.Controls.Add(this.groupControl4);
            this.groupControl3.Controls.Add(this.btnSubmitSingleProduct);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.textEdit5);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.textEdit4);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.textEdit3);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.textEdit2);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.textEdit1);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.txtProduct);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(756, 660);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Thông tin bán hàng";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.gcOrderDetail);
            this.groupControl5.Location = new System.Drawing.Point(11, 420);
            this.groupControl5.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(734, 236);
            this.groupControl5.TabIndex = 16;
            this.groupControl5.Text = "Chi tiết đơn hàng";
            // 
            // gcOrderDetail
            // 
            this.gcOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcOrderDetail.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcOrderDetail.Location = new System.Drawing.Point(2, 20);
            this.gcOrderDetail.MainView = this.gvOrderDetail;
            this.gcOrderDetail.Margin = new System.Windows.Forms.Padding(2);
            this.gcOrderDetail.Name = "gcOrderDetail";
            this.gcOrderDetail.Size = new System.Drawing.Size(730, 214);
            this.gcOrderDetail.TabIndex = 13;
            this.gcOrderDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrderDetail});
            // 
            // gvOrderDetail
            // 
            this.gvOrderDetail.GridControl = this.gcOrderDetail;
            this.gvOrderDetail.Name = "gvOrderDetail";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.dtSelectDateOrder);
            this.groupControl4.Controls.Add(this.rdSelectDateOrder);
            this.groupControl4.Controls.Add(this.gcOrders);
            this.groupControl4.Location = new System.Drawing.Point(11, 126);
            this.groupControl4.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(734, 290);
            this.groupControl4.TabIndex = 14;
            this.groupControl4.Text = "Danh sách đơn hàng";
            // 
            // dtSelectDateOrder
            // 
            this.dtSelectDateOrder.EditValue = null;
            this.dtSelectDateOrder.Location = new System.Drawing.Point(296, 22);
            this.dtSelectDateOrder.Margin = new System.Windows.Forms.Padding(2);
            this.dtSelectDateOrder.Name = "dtSelectDateOrder";
            this.dtSelectDateOrder.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSelectDateOrder.Properties.Appearance.Options.UseFont = true;
            this.dtSelectDateOrder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtSelectDateOrder.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtSelectDateOrder.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dtSelectDateOrder.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dtSelectDateOrder.Size = new System.Drawing.Size(123, 24);
            this.dtSelectDateOrder.TabIndex = 15;
            // 
            // rdSelectDateOrder
            // 
            this.rdSelectDateOrder.EditValue = true;
            this.rdSelectDateOrder.Location = new System.Drawing.Point(3, 22);
            this.rdSelectDateOrder.Margin = new System.Windows.Forms.Padding(2);
            this.rdSelectDateOrder.Name = "rdSelectDateOrder";
            this.rdSelectDateOrder.Properties.Columns = 4;
            this.rdSelectDateOrder.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Hôm nay", true, "today"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "1 ngày trước", true, "yesterday"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Chọn ngày", true, "selectdate")});
            this.rdSelectDateOrder.Size = new System.Drawing.Size(290, 22);
            this.rdSelectDateOrder.TabIndex = 14;
            this.rdSelectDateOrder.SelectedIndexChanged += new System.EventHandler(this.rdSelectDateOrder_SelectedIndexChanged);
            // 
            // gcOrders
            // 
            this.gcOrders.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcOrders.Location = new System.Drawing.Point(3, 47);
            this.gcOrders.MainView = this.gvOrders;
            this.gcOrders.Margin = new System.Windows.Forms.Padding(2);
            this.gcOrders.Name = "gcOrders";
            this.gcOrders.Size = new System.Drawing.Size(656, 206);
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
            // btnSubmitSingleProduct
            // 
            this.btnSubmitSingleProduct.Location = new System.Drawing.Point(66, 88);
            this.btnSubmitSingleProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitSingleProduct.Name = "btnSubmitSingleProduct";
            this.btnSubmitSingleProduct.Size = new System.Drawing.Size(78, 26);
            this.btnSubmitSingleProduct.TabIndex = 12;
            this.btnSubmitSingleProduct.Text = "Nhập";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(11, 70);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(51, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Thành tiền";
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(66, 68);
            this.textEdit5.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(237, 20);
            this.textEdit5.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(457, 50);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Đơn giá";
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(512, 48);
            this.textEdit4.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(101, 20);
            this.textEdit4.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(321, 50);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Số lượng";
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(376, 48);
            this.textEdit3.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(70, 20);
            this.textEdit3.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 50);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Đơn vị tính";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(66, 48);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(237, 20);
            this.textEdit2.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(321, 30);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Nhóm hàng";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(376, 29);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(237, 20);
            this.textEdit1.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 30);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Hàng hóa";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(66, 29);
            this.txtProduct.Margin = new System.Windows.Forms.Padding(2);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(237, 20);
            this.txtProduct.TabIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl3);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1117, 660);
            this.splitContainerControl1.SplitterPosition = 356;
            this.splitContainerControl1.TabIndex = 17;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // frmSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 660);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSaleForm";
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.frmSaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtSelectDateOrder.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSelectDateOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdSelectDateOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduct.Properties)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btnSubmitSingleProduct;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtProduct;
        private DevExpress.XtraGrid.GridControl gcCategory;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView winExplorerView1;
        private khh_posDataSet khh_posDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private khh_posDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colImageUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
    }
}