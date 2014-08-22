using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMSwithRFID.Domain_Classes
{
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public int DaysToExpire { get; set; }
        public double UnitPrice { get; set; }
        public DateTime LastUpdate { get; set; }
        public ProductType Type { get; set; }

        public List<Product> GetAllProductQuery()
        {
            WMScontext wms = new WMScontext();
            var results = from prod in wms.Products select prod;
            return results.ToList();
        }

    }
}
