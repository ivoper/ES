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
    
    public partial class Historico
    {
        public int id { get; set; }
        public int id_projeto { get; set; }
        public int estado { get; set; }
    
        public virtual Estado Estado1 { get; set; }
        public virtual Projeto Projeto { get; set; }
    }
}
