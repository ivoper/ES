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
    
    public partial class DespachoBonificacao
    {
        public int id_despacho { get; set; }
        public Nullable<double> taxa { get; set; }
        public Nullable<double> montante_maximo { get; set; }
        public Nullable<System.DateTime> periodo { get; set; }
    
        public virtual Despacho Despacho { get; set; }
    }
}
