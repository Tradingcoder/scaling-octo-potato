using System;
using System.Collections.Generic;
using System.Text;

namespace scaling_octo_potato
{
    public class Order
    {
        public bool AllOrNone { get; set; }
        
        public Audit Audit { get; set; }
        
        public string CompanyId { get; set; }
        
        public VenueContract VenueContract { get; set; }
        
        public AggregatedContract AggregatedContract { get; set; }
        
        public AggregatedContract GroupedAggregatedContract { get; set; }
        
        public string IdOrder { get; set; }
        
        public bool IsPrice { get; set; }
        
        public bool IsTradable { get; set; }
        
        public bool IsWithheld { get; set; }
        public string TraderUsername { get; set; }
        
        public string VenueOrderId { get; set; }
        
        public int? RouteId { get; set; }

    }
}
