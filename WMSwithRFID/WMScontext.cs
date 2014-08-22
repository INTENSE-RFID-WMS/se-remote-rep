using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using WMSwithRFID.Domain_Classes;

namespace WMSwithRFID
{
    class WMScontext : DbContext
    {
        private static WMScontext _instance = new WMScontext();

        public static WMScontext Instance
        {
            get
            {
                return _instance;
            }
        }

        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<ProductionLine> ProductionLines { get; set; }
        public DbSet<FinishedProduct> FinishedProducts { get; set; }
    }
}

