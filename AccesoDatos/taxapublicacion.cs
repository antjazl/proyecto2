//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class taxapublicacion
    {
        public long IdTaxaPublicacion { get; set; }
        public long IdTaxa { get; set; }
        public long IdPublicacion { get; set; }
        public bool Principal { get; set; }
        public Nullable<bool> Borrado { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
    
        public virtual publicacion publicacion { get; set; }
        public virtual taxa taxa { get; set; }
    }
}
