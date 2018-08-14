using System;

namespace scaling_octo_potato
{
    public class Audit
    {
        public Audit(string updatedBy, DateTime updatedTime)
        {
            UpdatedTime = updatedTime;
            UpdatedBy = updatedBy;
        }
        
        public string UpdatedBy { get; private set; }
        
        public DateTime UpdatedTime { get; set; }

        public override string ToString() => $@"Update By: {UpdatedBy}, Update Time: {UpdatedTime}";
    }
}