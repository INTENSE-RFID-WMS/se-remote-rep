using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMSwithRFID.Domain_Classes;

namespace WMSwithRFID
{
    public partial class AddProductionLineForm : Form
    {
        public AddProductionLineForm()
        {
            InitializeComponent();
            LoadProductCB();
        }

        private void LoadProductCB()
        {
            Product product = new Product();
            productProductionLineCB.DataSource = product.GetAllProductQuery();
            productProductionLineCB.DisplayMember = "Name";
            productProductionLineCB.ValueMember = "ID";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            WMScontext wms = WMScontext.Instance;
            ProductionLine productionLine = new ProductionLine
            {
                ProductionLineNo = Convert.ToInt32(productionLineNoNumbericDP.Value),
                Product = (Product)productProductionLineCB.SelectedItem,
                DateCreated = DateTime.Now
            };

            wms.ProductionLines.Add(productionLine);
            wms.SaveChanges();
        }
    }
}
