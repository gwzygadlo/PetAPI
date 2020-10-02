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
    
    public partial class Pet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pet()
        {
            this.Pet_Color = new HashSet<Pet_Color>();
        }
    
        public System.Guid pet_id { get; set; }
        public string pet_name { get; set; }
        public int pet_age { get; set; }
        public string pet_sex { get; set; }
        public System.Guid pet_type_id { get; set; }
        public System.Guid owner_id { get; set; }
        public System.Guid hunger_id { get; set; }
        public Nullable<System.Guid> health_id { get; set; }
    
        public virtual Health Health { get; set; }
        public virtual Hunger Hunger { get; set; }
        public virtual Owner Owner { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pet_Color> Pet_Color { get; set; }
        public virtual Pet_Type Pet_Type { get; set; }
    }
}