//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VtcIts.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExternalLocation
    {
        public ExternalLocation()
        {
            this.Meetings = new HashSet<Meeting>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string IpAddress { get; set; }
        public string PointOfContact { get; set; }
        public string TechnicalContactPhone { get; set; }
        public string TechnicalContactEmail { get; set; }
    
        public virtual ICollection<Meeting> Meetings { get; set; }
    }
}
