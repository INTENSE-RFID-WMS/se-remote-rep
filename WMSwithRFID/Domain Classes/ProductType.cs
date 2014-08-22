using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WMSwithRFID.Domain_Classes
{
    class ProductType
    {
        public int ID { get; set; }
        public string Name { get; set; }


        public List<ProductType> GetAllProductTypeQuery()
        {
            WMScontext ctx = WMScontext.Instance;
            var results = from prod in ctx.ProductTypes select prod;
            return results.ToList();
            
        }
    }
}
