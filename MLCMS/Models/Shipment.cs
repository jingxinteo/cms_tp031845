//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MLCMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shipment
    {
        public int ShipId { get; set; }
        public int Weight { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string ShippingType { get; set; }
        public string ShippingDate { get; set; }
        public string ArrivalDate { get; set; }
        public string Status { get; set; }
    }
}
