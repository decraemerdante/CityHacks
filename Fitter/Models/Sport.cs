//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fitter.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sport
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Location_id { get; set; }
    
        public virtual locations locations { get; set; }
    }
}
