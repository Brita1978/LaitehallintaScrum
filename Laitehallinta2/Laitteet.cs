//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Laitehallinta2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Laitteet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Laitteet()
        {
            this.Logi = new HashSet<Logi>();
        }
    
        public int LaiteID { get; set; }
        public string Sarjanumero { get; set; }
        public string Merkki { get; set; }
        public string Malli { get; set; }
        public string Muuta { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Logi> Logi { get; set; }
    }
}
