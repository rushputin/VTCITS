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
    
    public partial class Series
    {
        public Series()
        {
            this.Meetings = new HashSet<Meeting>();
        }
    
        public int Id { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string RuleText { get; set; }
    
        public virtual ICollection<Meeting> Meetings { get; set; }
    }
}
