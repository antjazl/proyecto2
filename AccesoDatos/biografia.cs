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
    
    public partial class biografia
    {
        public biografia()
        {
            this.autorbiografias = new HashSet<autorbiografia>();
        }
    
        public long IdBiografia { get; set; }
        public Nullable<int> AnoNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        public string InicioInteresEstudio { get; set; }
        public string TitulosAcademicos { get; set; }
        public string InteresInvestigacion { get; set; }
        public string ExperienciaLaboral { get; set; }
        public string PosicionActual { get; set; }
        public string AsociacionesProfesionales { get; set; }
        public string PremiosReconocimientos { get; set; }
        public string CorreoElectronico { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
    
        public virtual ICollection<autorbiografia> autorbiografias { get; set; }
    }
}
