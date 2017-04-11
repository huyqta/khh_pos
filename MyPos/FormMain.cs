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
using MyPos.Helper;
using DevExpress.XtraEditors;

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
            foreach (XtraForm form in this.MdiChildren)
            {


                if (form.GetType() == typeof(ListForms.frmListCategory))
                {
                    form.Activate();
                    return;
                }
            }
            ListForms.frmListCategory frm = new ListForms.frmListCategory();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (XtraForm form in this.MdiChildren)
            {
                if (form.GetType() == typeof(ListForms.frmListProduct))
                {
                    form.Activate();
                    return;
                }
            }
            ListForms.frmListProduct frm = new ListForms.frmListProduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonOrderItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (XtraForm form in this.MdiChildren)
            {


                if (form.GetType() == typeof(FunctionalForms.frmSaleForm))
                {
                    form.Activate();
                    return;
                }
            }
            FunctionalForms.frmSaleForm frm = new FunctionalForms.frmSaleForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonUnit_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (XtraForm form in this.MdiChildren)
            {


                if (form.GetType() == typeof(ListForms.frmListUnit))
                {
                    form.Activate();
                    return;
                }
            }
            ListForms.frmListUnit frm = new ListForms.frmListUnit();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonCompany_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (XtraForm form in this.MdiChildren)
            {


                if (form.GetType() == typeof(ListForms.frmListCompany))
                {
                    form.Activate();
                    return;
                }
            }
            ListForms.frmListCompany frm = new ListForms.frmListCompany();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonImportExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "EXCEL|*.xls|EXCEL 2012|*.xlsx";
            ofd.Multiselect = false;
            ofd.ShowDialog();

            string filePath = ofd.FileName;

            UtilityHelper.ReadFileExcel(filePath);
        }

        private void ribbon_Click(object sender, EventArgs e)
        {
            foreach (XtraForm form in this.MdiChildren)
            {


                if (form.GetType() == typeof(FunctionalForms.frmSaleStatistic))
                {
                    form.Activate();
                    return;
                }
            }
            FunctionalForms.frmSaleStatistic frm = new FunctionalForms.frmSaleStatistic();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barStaticStatus_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonVendor_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void ribbonStatusBar_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItemSaleStatistic_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (XtraForm form in this.MdiChildren)
            {


                if (form.GetType() == typeof(FunctionalForms.frmSaleStatistic))
                {
                    form.Activate();
                    return;
                }
            }
            FunctionalForms.frmSaleStatistic frm = new FunctionalForms.frmSaleStatistic();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}