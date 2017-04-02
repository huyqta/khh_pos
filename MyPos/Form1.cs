using BusinessEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPos
{
    public partial class Form1 : Form
    {
        ProductModel model = new ProductModel();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = model.Products.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat = model.Categories.Where(c => c.Id == 2).FirstOrDefault();
            model.Products.Add(new Product() { Name = "TEST 5", CategoryId = 2 });
            model.SaveChanges();
            dataGridView1.DataSource = model.Products.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product = model.Products.ToList()[model.Products.Count() - 1];
            model.Products.Remove(product);
            model.SaveChanges();
            dataGridView1.DataSource = model.Products.ToList();
        }
    }
}
