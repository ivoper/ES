//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestorDeProjetosDeFinanciamento
{
    using System;
    using System.Collections.Generic;
    
    public partial class Promotor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Promotor()
        {
            this.Projeto = new HashSet<Projeto>();
        }
    
        public string designacao { get; set; }
        public string nacionalidade { get; set; }
        public int nib { get; set; }
        public int nif { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Projeto> Projeto { get; set; }
    }
}