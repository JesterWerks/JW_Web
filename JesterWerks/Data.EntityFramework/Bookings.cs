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
    
    public partial class Bookings
    {
        public int Id { get; set; }
        public System.DateTime Date_Time_Booked { get; set; }
        public int Session_Id { get; set; }
    
        public virtual Sessions Sessions { get; set; }
    }
}
