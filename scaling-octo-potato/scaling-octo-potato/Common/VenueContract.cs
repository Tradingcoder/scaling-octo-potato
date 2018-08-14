using System;

namespace scaling_octo_potato
{
    public class VenueContract
    {
        public long FirstLegId { get; private set; }
        
        public string FirstLegName { get; private set; }
        
        public long FirstLegPeriodTypeId { get; private set; }
        
        public DateTime FirstLegDeliveryEnd { get; private set; }
        
        public long ProductId { get; private set; }
        
        public string ProductName { get; private set; }
        
        public long? SecondLegId { get; private set; }
        
        public string SecondLegName { get; private set; }
        
        public long? SecondLegPeriodTypeId { get; private set; }

    }
}