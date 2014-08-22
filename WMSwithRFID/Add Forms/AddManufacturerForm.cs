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
    public partial class AddManufacturerForm : Form
    {
        public AddManufacturerForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            WMScontext ctx = WMScontext.Instance;
            Manufacturer manufacturer = new Manufacturer
            {                
                Name = nameTB.Text,
                Address = addressTB.Text,
            };
            ctx.Manufacturers.Add(manufacturer);
            ctx.SaveChanges();
        }
    }
}
