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
    
    public partial class PERFIL
    {
        public PERFIL()
        {
            this.PERMISOSPERFILs = new HashSet<PERMISOSPERFIL>();
            this.USUARIOs = new HashSet<USUARIO>();
        }
    
        public long IDPERFIL { get; set; }
        public string PERFILNOMBRE { get; set; }
        public Nullable<System.DateTime> FECHAMODIFICACION { get; set; }
        public string USUARIOMODIFICACION { get; set; }
    
        public virtual ICollection<PERMISOSPERFIL> PERMISOSPERFILs { get; set; }
        public virtual ICollection<USUARIO> USUARIOs { get; set; }
    }
}
