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
    
    public partial class tipo
    {
        public tipo()
        {
            this.multimedias = new HashSet<multimedia>();
        }
    
        public long IdTipo { get; set; }
        public long IdTaxa { get; set; }
        public string NumeroMuseo { get; set; }
        public string Medidas { get; set; }
        public string Comentario { get; set; }
        public bool Principal { get; set; }
        public long IdCatalogo { get; set; }
        public Nullable<long> IdLocalidad { get; set; }
        public Nullable<bool> Borrado { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string LocalidadDescripcion { get; set; }
    
        public virtual ICollection<multimedia> multimedias { get; set; }
        public virtual taxa taxa { get; set; }
    }
}
