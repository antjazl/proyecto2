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
    
    public partial class localidad
    {
        public long IdLocalidad { get; set; }
        public long IdDivisionGeopolitica { get; set; }
        public string Nombre { get; set; }
        public string NombreVerbatim { get; set; }
        public Nullable<decimal> Latitud { get; set; }
        public Nullable<decimal> Longitud { get; set; }
        public string UtmN { get; set; }
        public string UtmE { get; set; }
        public string Altura { get; set; }
        public Nullable<decimal> Extension { get; set; }
        public Nullable<decimal> ErrorMaximaDistancia { get; set; }
        public Nullable<System.DateTime> FechaUltimoCambio { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
    }
}
