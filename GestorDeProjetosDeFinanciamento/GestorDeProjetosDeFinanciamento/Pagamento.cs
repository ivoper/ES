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
    
    public partial class Pagamento
    {
        public int id { get; set; }
        public double valor { get; set; }
        public System.DateTime data { get; set; }
        public int id_projeto { get; set; }
        public int id_despacho { get; set; }
    
        public virtual Despacho Despacho { get; set; }
        public virtual Incentivo Incentivo { get; set; }
    }
}
