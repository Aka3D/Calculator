//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Calculate.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Calculate
    {
        public int BerechnungId { get; set; }
        public double Zahl1 { get; set; }
        public double Zahl2 { get; set; }
        public string Operation { get; set; }
        public int fk_UserId { get; set; }
    }
}