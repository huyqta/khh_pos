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
        }

        private void barButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            BarButtonItem bbi = (BarButtonItem)sender;
            switch (bbi.Tag.ToString())
            {
                case "category":
                    break;
                case "product":
                    break;
            }
        }
    }
}