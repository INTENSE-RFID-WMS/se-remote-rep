using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WMSwithRFID.Add_Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProductForm product = new AddProductForm();
            product.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddManufacturerForm manufacturer = new AddManufacturerForm();
            manufacturer.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddWarehouseForm warehouse = new AddWarehouseForm();
            warehouse.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddProductTypeForm productType = new AddProductTypeForm();
            productType.Show();
            Hide();
        }
    }
}
