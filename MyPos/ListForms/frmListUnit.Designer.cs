namespace MyPos.ListForms
{
    partial class frmListUnit
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
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            this.SuspendLayout();
            // 
            // gcList
            // 
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcList.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gcList.Location = new System.Drawing.Point(0, 0);
            this.gcList.MainView = this.gvList;
            this.gcList.Name = "gcList";
            this.gcList.Size = new System.Drawing.Size(1434, 869);
            this.gcList.TabIndex = 5;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvList});
            this.gcList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcList_KeyDown);
            // 
            // gvList
            // 
            this.gvList.GridControl = this.gcList;
            this.gvList.Name = "gvList";
            this.gvList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvList_KeyDown);
            // 
            // frmListUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 869);
            this.Controls.Add(this.gcList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmListUnit";
            this.Text = "Nhóm hàng";
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvList;
    }
}