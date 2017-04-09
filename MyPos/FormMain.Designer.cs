namespace MyPos
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonCategory = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonOrderItem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonUnit = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonCompany = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonVendor = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonImportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageList = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupList = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItemSaleStatistic = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonCategory,
            this.barButtonProduct,
            this.barButtonOrderItem,
            this.barButtonUnit,
            this.barStaticStatus,
            this.barButtonCompany,
            this.barButtonVendor,
            this.barButtonImportExcel,
            this.barButtonItemSaleStatistic});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 10;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageList});
            this.ribbon.Size = new System.Drawing.Size(1784, 258);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // barButtonCategory
            // 
            this.barButtonCategory.Caption = "Nhóm hàng";
            this.barButtonCategory.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonCategory.Glyph")));
            this.barButtonCategory.Id = 1;
            this.barButtonCategory.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonCategory.LargeGlyph")));
            this.barButtonCategory.Name = "barButtonCategory";
            this.barButtonCategory.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonCategory.Tag = 'c';
            this.barButtonCategory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonCategory_ItemClick);
            // 
            // barButtonProduct
            // 
            this.barButtonProduct.Caption = "Hàng hóa";
            this.barButtonProduct.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonProduct.Glyph")));
            this.barButtonProduct.Id = 2;
            this.barButtonProduct.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonProduct.LargeGlyph")));
            this.barButtonProduct.Name = "barButtonProduct";
            this.barButtonProduct.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonProduct.Tag = 'p';
            this.barButtonProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonProduct_ItemClick);
            // 
            // barButtonOrderItem
            // 
            this.barButtonOrderItem.Caption = "Bán hàng";
            this.barButtonOrderItem.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonOrderItem.Glyph")));
            this.barButtonOrderItem.Id = 3;
            this.barButtonOrderItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonOrderItem.LargeGlyph")));
            this.barButtonOrderItem.Name = "barButtonOrderItem";
            this.barButtonOrderItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonOrderItem_ItemClick);
            // 
            // barButtonUnit
            // 
            this.barButtonUnit.Caption = "Đơn vị tính";
            this.barButtonUnit.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonUnit.Glyph")));
            this.barButtonUnit.Id = 4;
            this.barButtonUnit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonUnit.LargeGlyph")));
            this.barButtonUnit.Name = "barButtonUnit";
            this.barButtonUnit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonUnit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonUnit_ItemClick);
            // 
            // barStaticStatus
            // 
            this.barStaticStatus.Id = 5;
            this.barStaticStatus.Name = "barStaticStatus";
            this.barStaticStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            this.barStaticStatus.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barStaticStatus_ItemClick);
            // 
            // barButtonCompany
            // 
            this.barButtonCompany.Caption = "Khách hàng";
            this.barButtonCompany.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonCompany.Glyph")));
            this.barButtonCompany.Id = 6;
            this.barButtonCompany.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonCompany.LargeGlyph")));
            this.barButtonCompany.Name = "barButtonCompany";
            this.barButtonCompany.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonCompany.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonCompany_ItemClick);
            // 
            // barButtonVendor
            // 
            this.barButtonVendor.Caption = "Nhà cung cấp";
            this.barButtonVendor.Enabled = false;
            this.barButtonVendor.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonVendor.Glyph")));
            this.barButtonVendor.Id = 7;
            this.barButtonVendor.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonVendor.LargeGlyph")));
            this.barButtonVendor.Name = "barButtonVendor";
            this.barButtonVendor.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonVendor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonVendor_ItemClick);
            // 
            // barButtonImportExcel
            // 
            this.barButtonImportExcel.Caption = "Nhập file";
            this.barButtonImportExcel.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonImportExcel.Glyph")));
            this.barButtonImportExcel.Id = 8;
            this.barButtonImportExcel.Name = "barButtonImportExcel";
            this.barButtonImportExcel.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonImportExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonImportExcel_ItemClick);
            // 
            // ribbonPageList
            // 
            this.ribbonPageList.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupList,
            this.ribbonPageGroup2,
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPageList.Name = "ribbonPageList";
            this.ribbonPageList.Text = "Chức năng";
            // 
            // ribbonPageGroupList
            // 
            this.ribbonPageGroupList.ItemLinks.Add(this.barButtonCategory);
            this.ribbonPageGroupList.ItemLinks.Add(this.barButtonProduct);
            this.ribbonPageGroupList.ItemLinks.Add(this.barButtonUnit);
            this.ribbonPageGroupList.Name = "ribbonPageGroupList";
            this.ribbonPageGroupList.Text = "Danh mục hàng hóa";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonCompany);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonVendor);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Đối tác";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonOrderItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Giao dịch";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonImportExcel);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Công cụ";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticStatus);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 1024);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1784, 55);
            this.ribbonStatusBar.Click += new System.EventHandler(this.ribbonStatusBar_Click);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItemSaleStatistic);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Thống kê";
            // 
            // barButtonItemSaleStatistic
            // 
            this.barButtonItemSaleStatistic.Caption = "Doanh số bán hàng";
            this.barButtonItemSaleStatistic.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemSaleStatistic.Glyph")));
            this.barButtonItemSaleStatistic.Id = 9;
            this.barButtonItemSaleStatistic.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemSaleStatistic.LargeGlyph")));
            this.barButtonItemSaleStatistic.Name = "barButtonItemSaleStatistic";
            this.barButtonItemSaleStatistic.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSaleStatistic_ItemClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 1079);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "KHH POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupList;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonCategory;
        private DevExpress.XtraBars.BarButtonItem barButtonProduct;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonOrderItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonUnit;
        public DevExpress.XtraBars.BarStaticItem barStaticStatus;
        private DevExpress.XtraBars.BarButtonItem barButtonCompany;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonVendor;
        private DevExpress.XtraBars.BarButtonItem barButtonImportExcel;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSaleStatistic;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}