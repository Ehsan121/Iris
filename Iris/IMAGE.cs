//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Iris
{
    using System;
    using System.Collections.Generic;
    
    public partial class IMAGE
    {
        public int ImageID { get; set; }
        public string ImageName { get; set; }
        public byte[] Image1 { get; set; }
    
        public virtual PERSON PERSON { get; set; }
    }
}
