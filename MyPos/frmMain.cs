using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MyPos
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolScripMenus_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmItem = (ToolStripMenuItem)sender;
            TabPage tp = new TabPage(tsmItem.Text);
            
            switch (tsmItem.Name)
            {
                case "tsmCategory":
                    ListForms.ucListCategory ucListCategory = new ListForms.ucListCategory();
                    ucListCategory.Dock = DockStyle.Fill;
                    tp.Controls.Add(ucListCategory);
                    tabMain.TabPages.Add(tp);
                    break;
                case "tsmProduct":
                    ListForms.ucListProduct ucListProduct = new ListForms.ucListProduct();
                    ucListProduct.Dock = DockStyle.Fill;
                    tp.Controls.Add(ucListProduct);
                    tabMain.TabPages.Add(tp);
                    break;
                case "Exit":
                    break;
                default:
                    break;
            }
        }
    }
}
