//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Locations
    {
        public Locations()
        {
            this.Rooms = new HashSet<Rooms>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
    
        public virtual ICollection<Rooms> Rooms { get; set; }
    }
}
