//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        public int reservationId { get; set; }
        public System.DateTime reservation_date { get; set; }
        public System.TimeSpan reservation_time { get; set; }
        public string event_type { get; set; }
        public int reservation_payment { get; set; }
    }
}
