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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
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
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(440, 476);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Nhóm hàng";
            // 
            // groupControl2
            // 
            this.groupControl2.Location = new System.Drawing.Point(12, 494);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(440, 683);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Hàng hóa";
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
            this.groupControl3.Location = new System.Drawing.Point(458, 12);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1352, 1175);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Thông tin bán hàng";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.gcOrderDetail);
            this.groupControl5.Location = new System.Drawing.Point(22, 742);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(1324, 423);
            this.groupControl5.TabIndex = 16;
            this.groupControl5.Text = "Chi tiết đơn hàng";
            // 
            // gcOrderDetail
            // 
            this.gcOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcOrderDetail.Location = new System.Drawing.Point(3, 40);
            this.gcOrderDetail.MainView = this.gvOrderDetail;
            this.gcOrderDetail.Name = "gcOrderDetail";
            this.gcOrderDetail.Size = new System.Drawing.Size(1318, 380);
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
            this.groupControl4.Location = new System.Drawing.Point(22, 242);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(1324, 494);
            this.groupControl4.TabIndex = 14;
            this.groupControl4.Text = "Danh sách đơn hàng";
            // 
            // dtSelectDateOrder
            // 
            this.dtSelectDateOrder.EditValue = null;
            this.dtSelectDateOrder.Location = new System.Drawing.Point(591, 43);
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
            this.rdSelectDateOrder.Location = new System.Drawing.Point(6, 43);
            this.rdSelectDateOrder.Name = "rdSelectDateOrder";
            this.rdSelectDateOrder.Properties.Columns = 4;
            this.rdSelectDateOrder.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Hôm nay", true, "today"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "1 ngày trước", true, "yesterday"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Chọn ngày", true, "selectdate")});
            this.rdSelectDateOrder.Size = new System.Drawing.Size(579, 42);
            this.rdSelectDateOrder.TabIndex = 14;
            this.rdSelectDateOrder.SelectedIndexChanged += new System.EventHandler(this.rdSelectDateOrder_SelectedIndexChanged);
            // 
            // gcOrders
            // 
            this.gcOrders.Location = new System.Drawing.Point(6, 91);
            this.gcOrders.MainView = this.gvOrders;
            this.gcOrders.Name = "gcOrders";
            this.gcOrders.Size = new System.Drawing.Size(1312, 397);
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
            this.btnSubmitSingleProduct.Location = new System.Drawing.Point(133, 169);
            this.btnSubmitSingleProduct.Name = "btnSubmitSingleProduct";
            this.btnSubmitSingleProduct.Size = new System.Drawing.Size(156, 50);
            this.btnSubmitSingleProduct.TabIndex = 12;
            this.btnSubmitSingleProduct.Text = "Nhập";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(22, 134);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(101, 25);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Thành tiền";
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(133, 131);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(474, 32);
            this.textEdit5.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(914, 96);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(74, 25);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Đơn giá";
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(1025, 93);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(202, 32);
            this.textEdit4.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(642, 96);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(84, 25);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Số lượng";
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(753, 93);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(141, 32);
            this.textEdit3.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 96);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(104, 25);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Đơn vị tính";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(133, 93);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(474, 32);
            this.textEdit2.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(642, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(109, 25);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Nhóm hàng";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(753, 55);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(474, 32);
            this.textEdit1.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 25);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Hàng hóa";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(133, 55);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(474, 32);
            this.txtProduct.TabIndex = 0;
            // 
            // frmSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1822, 1189);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSaleForm";
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.frmSaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
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
    }
}