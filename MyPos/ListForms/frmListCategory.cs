﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessEntity;

namespace MyPos.ListForms
{
    public partial class frmListCategory : DevExpress.XtraEditors.XtraForm
    {
        ProductModel model = new ProductModel();

        public frmListCategory()
        {
            InitializeComponent();
            //gcCategory.DataSource = model.Categories.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.SaveChanges();
            gcCategory.DataSource = model.Categories.ToList();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            model.Categories.Add(new Category() { });
            model.SaveChanges();
            gcCategory.DataSource = model.Categories.ToList();
        }

        private void gcCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                btnAddNew_Click(null, null);
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnSave_Click(null, null);
            }
        }

        private void gvCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                btnAddNew_Click(null, null);
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnSave_Click(null, null);
            }
        }

        private void frmListCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khh_posDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.khh_posDataSet.Categories);

        }
    }
}