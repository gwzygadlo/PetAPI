//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetAPI.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pet_Color
    {
        public System.Guid color_id { get; set; }
        public System.Guid pet_color_id { get; set; }
        public int color_priority { get; set; }
        public Nullable<System.Guid> pet_id { get; set; }
    
        public virtual Color Color { get; set; }
        public virtual Pet Pet { get; set; }
    }
}
