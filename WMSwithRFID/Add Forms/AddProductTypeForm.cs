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
    public partial class AddProductTypeForm : Form
    {
        public AddProductTypeForm()
        {
            InitializeComponent();
        }

        private void AddProductTypeForm_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            WMScontext ctx = WMScontext.Instance;
            ProductType productType = new ProductType
            {
                Name = productTypeNameTB.Text                
            };
            
            ctx.ProductTypes.Add(productType);
            ctx.SaveChanges();
        }

        
    }
}
