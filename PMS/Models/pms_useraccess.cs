//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class pms_useraccess
    {
        public int accessId { get; set; }
        public string userid { get; set; }
        public string employeeid { get; set; }
        public string employeename { get; set; }
        public Nullable<bool> canedit { get; set; }
        public System.DateTime createdate { get; set; }
        public string createdby { get; set; }
    }
}
