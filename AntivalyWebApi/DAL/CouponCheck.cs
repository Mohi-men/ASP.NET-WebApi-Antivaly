//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CouponCheck
    {
        public int Id { get; set; }
        public int CouponId { get; set; }
        public string BuyerId { get; set; }
        public System.DateTime UsedAt { get; set; }
    }
}