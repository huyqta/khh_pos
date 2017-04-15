namespace MyPos.ListForms
{
    partial class frmListVendor
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
            this.khh_posDataSet = new MyPos.khh_posDataSet();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Telephone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FaxNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TaxNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorsTableAdapter = new MyPos.khh_posDataSetTableAdapters.VendorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gcList
            // 
            this.gcList.DataSource = this.vendorsBindingSource;
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcList.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gcList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcList.Location = new System.Drawing.Point(0, 0);
            this.gcList.MainView = this.gvList;
            this.gcList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcList.Name = "gcList";
            this.gcList.Size = new System.Drawing.Size(1434, 869);
            this.gcList.TabIndex = 5;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvList});
            this.gcList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcList_KeyDown);
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
            this.Address,
            this.PhoneNumber,
            this.Telephone,
            this.FaxNumber,
            this.TaxNumber,
            this.isCompany,
            this.Description});
            this.gvList.GridControl = this.gcList;
            this.gvList.Name = "gvList";
            this.gvList.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gvList.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // Name
            // 
            this.Name.Caption = "Khách hàng";
            this.Name.FieldName = "Name";
            this.Name.Name = "Name";
            this.Name.Visible = true;
            this.Name.VisibleIndex = 0;
            // 
            // Address
            // 
            this.Address.Caption = "Địa chỉ";
            this.Address.FieldName = "Address";
            this.Address.Name = "Address";
            this.Address.Visible = true;
            this.Address.VisibleIndex = 1;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Caption = "Số điện thoại";
            this.PhoneNumber.FieldName = "PhoneNumber";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Visible = true;
            this.PhoneNumber.VisibleIndex = 2;
            // 
            // Telephone
            // 
            this.Telephone.Caption = "Di động";
            this.Telephone.FieldName = "Telephone";
            this.Telephone.Name = "Telephone";
            this.Telephone.Visible = true;
            this.Telephone.VisibleIndex = 3;
            // 
            // FaxNumber
            // 
            this.FaxNumber.Caption = "Số fax";
            this.FaxNumber.FieldName = "FaxNumber";
            this.FaxNumber.Name = "FaxNumber";
            this.FaxNumber.Visible = true;
            this.FaxNumber.VisibleIndex = 4;
            // 
            // TaxNumber
            // 
            this.TaxNumber.Caption = "Mã số thuế";
            this.TaxNumber.FieldName = "TaxNumber";
            this.TaxNumber.Name = "TaxNumber";
            this.TaxNumber.Visible = true;
            this.TaxNumber.VisibleIndex = 5;
            // 
            // isCompany
            // 
            this.isCompany.Caption = "Công ty / Cá nhân";
            this.isCompany.FieldName = "isCompany";
            this.isCompany.Name = "isCompany";
            this.isCompany.Visible = true;
            this.isCompany.VisibleIndex = 6;
            // 
            // Description
            // 
            this.Description.Caption = "Mô tả";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 7;
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
            // frmListVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 869);
            this.Controls.Add(this.gcList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            //this.Name = "frmListVendor";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.frmListUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khh_posDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvList;
        private khh_posDataSet khh_posDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn Name;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn PhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn Telephone;
        private DevExpress.XtraGrid.Columns.GridColumn FaxNumber;
        private DevExpress.XtraGrid.Columns.GridColumn TaxNumber;
        private DevExpress.XtraGrid.Columns.GridColumn isCompany;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private khh_posDataSetTableAdapters.VendorsTableAdapter vendorsTableAdapter;
    }
}