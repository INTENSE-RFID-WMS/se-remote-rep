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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
            LoadProductTypeCB();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            WMScontext ctx = WMScontext.Instance;
            Product product = new Product
            {
                Name = productNameTB.Text,
                Weight = Convert.ToInt32(weightInput.Value),
                DaysToExpire = Convert.ToInt32(daysToExpireInput.Value),
                UnitPrice = Convert.ToDouble(unitPriceInput.Value),
                LastUpdate = DateTime.Now,
                Type = (ProductType)typeCB.SelectedItem,               
            };

            ctx.Products.Add(product);
            ctx.SaveChanges();  
        }                                                                           
                                                                                        
        private void LoadProductTypeCB()                                                       
        {
            ProductType productType = new ProductType();
            typeCB.DataSource = productType.GetAllProductTypeQuery();
            typeCB.DisplayMember = "Name";
            typeCB.ValueMember = "ID";                                             
        }
        
       
        
    }
}
