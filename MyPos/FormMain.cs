using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace MyPos
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
            xtraTabbedMdiManager1.MdiParent = this;
            FunctionalForms.frmSaleForm frm = new FunctionalForms.frmSaleForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            BarButtonItem bbi = (BarButtonItem)sender;
            
            switch (bbi.Tag.ToString())
            {
                case "category":
                    frmMain frm = new frmMain();
                    frm.MdiParent = this;
                    frm.Show();
                    break;
                case "product":
                    break;
            }
        }

        private void barButtonCategory_ItemClick(object sender, ItemClickEventArgs e)
        {
            ListForms.frmListCategory frm = new ListForms.frmListCategory();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            ListForms.frmListProduct frm = new ListForms.frmListProduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonOrderItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            FunctionalForms.frmSaleForm frm = new FunctionalForms.frmSaleForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonUnit_ItemClick(object sender, ItemClickEventArgs e)
        {
            ListForms.frmListUnit frm = new ListForms.frmListUnit();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}