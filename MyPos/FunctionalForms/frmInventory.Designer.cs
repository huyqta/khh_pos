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
            this.btnInitialize = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcInventory = new DevExpress.XtraGrid.GridControl();
            this.gvInventory = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInitialize
            // 
            this.btnInitialize.Location = new System.Drawing.Point(5, 23);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(126, 25);
            this.btnInitialize.TabIndex = 0;
            this.btnInitialize.Text = "Khởi tạo số lượng";
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnInitialize);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(953, 53);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Quản lý kho hàng";
            // 
            // gcInventory
            // 
            this.gcInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcInventory.Location = new System.Drawing.Point(0, 53);
            this.gcInventory.MainView = this.gvInventory;
            this.gcInventory.Name = "gcInventory";
            this.gcInventory.Size = new System.Drawing.Size(953, 427);
            this.gcInventory.TabIndex = 2;
            this.gcInventory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInventory});
            // 
            // gvInventory
            // 
            this.gvInventory.GridControl = this.gcInventory;
            this.gvInventory.Name = "gvInventory";
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 480);
            this.Controls.Add(this.gcInventory);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmInventory";
            this.Text = "frmInventory";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnInitialize;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcInventory;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInventory;
    }
}