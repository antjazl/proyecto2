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
    
    public partial class taxa
    {
        public taxa()
        {
            this.especies = new HashSet<especie>();
            this.especimen = new HashSet<especiman>();
            this.multimedias = new HashSet<multimedia>();
            this.nombrecomuns = new HashSet<nombrecomun>();
            this.ordenamientotaxas = new HashSet<ordenamientotaxa>();
            this.sinonimoes = new HashSet<sinonimo>();
            this.taxa1 = new HashSet<taxa>();
            this.taxapublicacions = new HashSet<taxapublicacion>();
            this.tipoes = new HashSet<tipo>();
        }
    
        public long IdTaxa { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }
        public bool EnEcuador { get; set; }
        public bool Endemica { get; set; }
        public Nullable<long> IdTaxaPadre { get; set; }
        public long IdCatalogo { get; set; }
        public bool PublicarEnWeb { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public Nullable<long> IdPublicacionReporte { get; set; }
        public Nullable<int> Ano { get; set; }
    
        public virtual ICollection<especie> especies { get; set; }
        public virtual ICollection<especiman> especimen { get; set; }
        public virtual ICollection<multimedia> multimedias { get; set; }
        public virtual ICollection<nombrecomun> nombrecomuns { get; set; }
        public virtual ICollection<ordenamientotaxa> ordenamientotaxas { get; set; }
        public virtual ICollection<sinonimo> sinonimoes { get; set; }
        public virtual ICollection<taxa> taxa1 { get; set; }
        public virtual taxa taxa2 { get; set; }
        public virtual ICollection<taxapublicacion> taxapublicacions { get; set; }
        public virtual ICollection<tipo> tipoes { get; set; }
    }
}
