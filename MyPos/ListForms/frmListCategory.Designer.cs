﻿namespace MyPos.ListForms
{
    partial class frmListCategory
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
            this.gcCategory = new DevExpress.XtraGrid.GridControl();
            this.khhposDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khh_posDataSet = new MyPos.khh_posDataSet();
            this.gvCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ImageUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new MyPos.khh_posDataSetTableAdapters.CategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khhposDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCategory
            // 
            this.gcCategory.DataSource = this.categoriesBindingSource;
            this.gcCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCategory.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcCategory.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gcCategory.Location = new System.Drawing.Point(0, 0);
            this.gcCategory.MainView = this.gvCategory;
            this.gcCategory.Name = "gcCategory";
            this.gcCategory.Size = new System.Drawing.Size(1434, 869);
            this.gcCategory.TabIndex = 5;
            this.gcCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCategory});
            this.gcCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcCategory_KeyDown);
            // 
            // khhposDataSetBindingSource
            // 
            this.khhposDataSetBindingSource.DataSource = this.khh_posDataSet;
            this.khhposDataSetBindingSource.Position = 0;
            // 
            // khh_posDataSet
            // 
            this.khh_posDataSet.DataSetName = "khh_posDataSet";
            this.khh_posDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvCategory
            // 
            this.gvCategory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Name,
            this.ImageUrl,
            this.Description});
            this.gvCategory.GridControl = this.gcCategory;
            this.gvCategory.Name = "gvCategory";
            this.gvCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvCategory_KeyDown);
            // 
            // Name
            // 
            this.Name.Caption = "Tên nhóm hàng";
            this.Name.FieldName = "Name";
            this.Name.Name = "Name";
            this.Name.Visible = true;
            this.Name.VisibleIndex = 0;
            // 
            // ImageUrl
            // 
            this.ImageUrl.Caption = "Liên kết hình ảnh";
            this.ImageUrl.FieldName = "ImageUrl";
            this.ImageUrl.Name = "ImageUrl";
            this.ImageUrl.Visible = true;
            this.ImageUrl.VisibleIndex = 1;
            // 
            // Description
            // 
            this.Description.Caption = "Mô tả";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 2;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.khhposDataSetBindingSource;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // frmListCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 869);
            this.Controls.Add(this.gcCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            //this.Name = "frmListCategory";
            this.Text = "Nhóm hàng";
            this.Load += new System.EventHandler(this.frmListCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khhposDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gcCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCategory;
        private DevExpress.XtraGrid.Columns.GridColumn Name;
        private DevExpress.XtraGrid.Columns.GridColumn ImageUrl;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private System.Windows.Forms.BindingSource khhposDataSetBindingSource;
        private khh_posDataSet khh_posDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private khh_posDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
    }
}