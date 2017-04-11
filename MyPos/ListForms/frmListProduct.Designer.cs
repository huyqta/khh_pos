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
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.productsBindingSource = new System.Windows.Forms.BindingSource();
            this.khh_posDataSet = new MyPos.khh_posDataSet();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUp_Category = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource();
            this.UnitId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUp_Unit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.unitsBindingSource = new System.Windows.Forms.BindingSource();
            this.ImageUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DefaultPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lkuCategoryGrid = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productsTableAdapter = new MyPos.khh_posDataSetTableAdapters.ProductsTableAdapter();
            this.categoriesTableAdapter = new MyPos.khh_posDataSetTableAdapters.CategoriesTableAdapter();
            this.unitsTableAdapter = new MyPos.khh_posDataSetTableAdapters.UnitsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUp_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUp_Unit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuCategoryGrid)).BeginInit();
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
            this.lkuCategoryGrid,
            this.repositoryItemLookUp_Unit,
            this.repositoryItemLookUp_Category});
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
            this.UnitId,
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
            this.CategoryId.ColumnEdit = this.repositoryItemLookUp_Category;
            this.CategoryId.FieldName = "CategoryId";
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.Visible = true;
            this.CategoryId.VisibleIndex = 2;
            // 
            // repositoryItemLookUp_Category
            // 
            this.repositoryItemLookUp_Category.AutoHeight = false;
            this.repositoryItemLookUp_Category.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUp_Category.DataSource = this.categoriesBindingSource;
            this.repositoryItemLookUp_Category.DisplayMember = "Name";
            this.repositoryItemLookUp_Category.Name = "repositoryItemLookUp_Category";
            this.repositoryItemLookUp_Category.ValueMember = "Id";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.khh_posDataSet;
            // 
            // UnitId
            // 
            this.UnitId.Caption = "Đơn vị tính";
            this.UnitId.ColumnEdit = this.repositoryItemLookUp_Unit;
            this.UnitId.FieldName = "UnitId";
            this.UnitId.Name = "UnitId";
            this.UnitId.Visible = true;
            this.UnitId.VisibleIndex = 1;
            // 
            // repositoryItemLookUp_Unit
            // 
            this.repositoryItemLookUp_Unit.AutoHeight = false;
            this.repositoryItemLookUp_Unit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUp_Unit.DataSource = this.unitsBindingSource;
            this.repositoryItemLookUp_Unit.DisplayMember = "Name";
            this.repositoryItemLookUp_Unit.Name = "repositoryItemLookUp_Unit";
            this.repositoryItemLookUp_Unit.ValueMember = "Id";
            // 
            // unitsBindingSource
            // 
            this.unitsBindingSource.DataMember = "Units";
            this.unitsBindingSource.DataSource = this.khh_posDataSet;
            // 
            // ImageUrl
            // 
            this.ImageUrl.Caption = "Liên kết ảnh";
            this.ImageUrl.FieldName = "ImageUrl";
            this.ImageUrl.Name = "ImageUrl";
            this.ImageUrl.Visible = true;
            this.ImageUrl.VisibleIndex = 3;
            // 
            // DefaultPrice
            // 
            this.DefaultPrice.Caption = "Giá bán";
            this.DefaultPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DefaultPrice.FieldName = "DefaultPrice";
            this.DefaultPrice.Name = "DefaultPrice";
            this.DefaultPrice.Visible = true;
            this.DefaultPrice.VisibleIndex = 4;
            // 
            // Description
            // 
            this.Description.Caption = "Mô tả";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 5;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
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
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // unitsTableAdapter
            // 
            this.unitsTableAdapter.ClearBeforeFill = true;
            // 
            // frmListProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 452);
            this.Controls.Add(this.gcList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Name = "frmListProduct";
            this.Tag = "Product";
            this.Text = "Hàng hóa";
            this.Load += new System.EventHandler(this.frmListProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUp_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUp_Unit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuCategoryGrid)).EndInit();
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
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkuCategoryGrid;
        private khh_posDataSet khh_posDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private khh_posDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn UnitId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUp_Unit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUp_Category;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private khh_posDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource unitsBindingSource;
        private khh_posDataSetTableAdapters.UnitsTableAdapter unitsTableAdapter;
    }
}