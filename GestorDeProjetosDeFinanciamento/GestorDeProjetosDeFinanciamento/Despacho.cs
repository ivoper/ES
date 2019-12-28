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
    
    public partial class Despacho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Despacho()
        {
            this.Pagamento = new HashSet<Pagamento>();
        }
    
        public int id { get; set; }
        public string resultado { get; set; }
        public System.DateTime data_despacho { get; set; }
        public int id_projeto { get; set; }
    
        public virtual Projeto Projeto { get; set; }
        public virtual DespachoBonificacao DespachoBonificacao { get; set; }
        public virtual DespachoIncentivo DespachoIncentivo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pagamento> Pagamento { get; set; }
    }
}
