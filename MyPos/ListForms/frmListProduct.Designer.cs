namespace MyPos.ListForms
{
    partial class frmListProduct
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
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khh_posDataSet = new MyPos.khh_posDataSet();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkuCategoryGrid = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ImageUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DefaultPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lkuCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.productsTableAdapter = new MyPos.khh_posDataSetTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuCategoryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuCategory.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcList
            // 
            this.gcList.DataSource = this.productsBindingSource;
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcList.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gcList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcList.Location = new System.Drawing.Point(0, 0);
            this.gcList.MainView = this.gvList;
            this.gcList.Margin = new System.Windows.Forms.Padding(2);
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.lkuCategoryGrid});
            this.gcList.Size = new System.Drawing.Size(717, 452);
            this.gcList.TabIndex = 5;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvList});
            this.gcList.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gcList_ProcessGridKey);
            this.gcList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcList_KeyDown);
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
            // gvList
            // 
            this.gvList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Name,
            this.CategoryId,
            this.ImageUrl,
            this.DefaultPrice,
            this.Description});
            this.gvList.GridControl = this.gcList;
            this.gvList.Name = "gvList";
            this.gvList.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gvList.OptionsSelection.MultiSelect = true;
            this.gvList.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvList.OptionsView.ShowFooter = true;
            this.gvList.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Panel;
            this.gvList.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvList_InitNewRow);
            this.gvList.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvList_RowUpdated);
            // 
            // Name
            // 
            this.Name.Caption = "Tên hàng hóa";
            this.Name.FieldName = "Name";
            this.Name.Name = "Name";
            this.Name.Visible = true;
            this.Name.VisibleIndex = 0;
            // 
            // CategoryId
            // 
            this.CategoryId.Caption = "Nhóm hàng";
            this.CategoryId.ColumnEdit = this.lkuCategoryGrid;
            this.CategoryId.FieldName = "CategoryId";
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.Visible = true;
            this.CategoryId.VisibleIndex = 1;
            // 
            // lkuCategoryGrid
            // 
            this.lkuCategoryGrid.AutoHeight = false;
            this.lkuCategoryGrid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuCategoryGrid.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Mô tả")});
            this.lkuCategoryGrid.DisplayMember = "Name";
            this.lkuCategoryGrid.Name = "lkuCategoryGrid";
            this.lkuCategoryGrid.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lkuCategoryGrid.ValueMember = "Id";
            // 
            // ImageUrl
            // 
            this.ImageUrl.Caption = "Liên kết ảnh";
            this.ImageUrl.FieldName = "ImageUrl";
            this.ImageUrl.Name = "ImageUrl";
            this.ImageUrl.Visible = true;
            this.ImageUrl.VisibleIndex = 2;
            // 
            // DefaultPrice
            // 
            this.DefaultPrice.Caption = "Giá bán";
            this.DefaultPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DefaultPrice.FieldName = "DefaultPrice";
            this.DefaultPrice.Name = "DefaultPrice";
            this.DefaultPrice.Visible = true;
            this.DefaultPrice.VisibleIndex = 3;
            // 
            // Description
            // 
            this.Description.Caption = "Mô tả";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 4;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // lkuCategory
            // 
            this.lkuCategory.Location = new System.Drawing.Point(94, 327);
            this.lkuCategory.Margin = new System.Windows.Forms.Padding(2);
            this.lkuCategory.Name = "lkuCategory";
            this.lkuCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuCategory.Size = new System.Drawing.Size(178, 20);
            this.lkuCategory.TabIndex = 6;
            this.lkuCategory.Visible = false;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // frmListProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 452);
            this.Controls.Add(this.lkuCategory);
            this.Controls.Add(this.gcList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Name = "frmListProduct";
            this.Text = "Đơn vị tính";
            this.Load += new System.EventHandler(this.frmListProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuCategoryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuCategory.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvList;
        private DevExpress.XtraGrid.Columns.GridColumn Name;
        private DevExpress.XtraGrid.Columns.GridColumn CategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn ImageUrl;
        private DevExpress.XtraGrid.Columns.GridColumn DefaultPrice;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.LookUpEdit lkuCategory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkuCategoryGrid;
        private khh_posDataSet khh_posDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private khh_posDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
    }
}