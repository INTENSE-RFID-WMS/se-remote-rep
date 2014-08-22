using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMSwithRFID.Domain_Classes
{
    class FinishedProduct
    {
        public int ID { get; set; }
        public DateTime DateManufactured { get; set; }
        public Status Status { get; set; }
        public string EPC { get; set; }
        //public ProductionLine ProductionLineNo { get; set; }

    }

    enum Status
    {
        Stored,
        OntheMove,
        DamageInStorage,
        DamageIntransportation
    }
}
