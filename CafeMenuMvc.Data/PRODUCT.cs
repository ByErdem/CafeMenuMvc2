//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CafeMenuMvc.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCT
    {
        public int PRODUCTID { get; set; }
        public string PRODUCTNAME { get; set; }
        public Nullable<int> CATEGORYID { get; set; }
        public Nullable<decimal> PRICE { get; set; }
        public string IMAGEPATH { get; set; }
        public Nullable<bool> ISDELETED { get; set; }
        public Nullable<System.DateTime> CREATEDDATE { get; set; }
        public Nullable<int> CREATORUSERID { get; set; }
    }
}
