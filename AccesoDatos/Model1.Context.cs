﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BiologiaBdRelacionesEntities : DbContext
    {
        public BiologiaBdRelacionesEntities()
            : base("name=BiologiaBdRelacionesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<amphibia> amphibias { get; set; }
        public DbSet<autor> autors { get; set; }
        public DbSet<autorbiografia> autorbiografias { get; set; }
        public DbSet<ave> aves { get; set; }
        public DbSet<biografia> biografias { get; set; }
        public DbSet<catalogo> catalogoes { get; set; }
        public DbSet<ColaReporte> ColaReportes { get; set; }
        public DbSet<divisiongeopolitica> divisiongeopoliticas { get; set; }
        public DbSet<divisiongeopoliticacatalogoap> divisiongeopoliticacatalogoaps { get; set; }
        public DbSet<enlacerelacionado> enlacerelacionadoes { get; set; }
        public DbSet<especie> especies { get; set; }
        public DbSet<especiecatalogo> especiecatalogoes { get; set; }
        public DbSet<especielocalidad> especielocalidads { get; set; }
        public DbSet<especiman> especimen { get; set; }
        public DbSet<ImagenEspeciman> ImagenEspecimen { get; set; }
        public DbSet<localidad> localidads { get; set; }
        public DbSet<localidadcatalogo> localidadcatalogoes { get; set; }
        public DbSet<mammalia> mammalias { get; set; }
        public DbSet<MENU> MENUs { get; set; }
        public DbSet<multimedia> multimedias { get; set; }
        public DbSet<nombrecomun> nombrecomuns { get; set; }
        public DbSet<nombrecomuncatalogo> nombrecomuncatalogoes { get; set; }
        public DbSet<nombrecomunpublicacion> nombrecomunpublicacions { get; set; }
        public DbSet<ordenamientotaxa> ordenamientotaxas { get; set; }
        public DbSet<PERFIL> PERFILs { get; set; }
        public DbSet<PERMISOSPERFIL> PERMISOSPERFILs { get; set; }
        public DbSet<publicacion> publicacions { get; set; }
        public DbSet<publicacionano_bak> publicacionano_bak { get; set; }
        public DbSet<publicacionautor> publicacionautors { get; set; }
        public DbSet<publicacioncatalogo> publicacioncatalogoes { get; set; }
        public DbSet<publicacionenlace> publicacionenlaces { get; set; }
        public DbSet<reptilia> reptilias { get; set; }
        public DbSet<reptiliacatalogo> reptiliacatalogoes { get; set; }
        public DbSet<sinonimo> sinonimoes { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<taxa> taxas { get; set; }
        public DbSet<taxaaudio> taxaaudios { get; set; }
        public DbSet<taxapublicacion> taxapublicacions { get; set; }
        public DbSet<taxavideo> taxavideos { get; set; }
        public DbSet<tipo> tipoes { get; set; }
        public DbSet<tipocatalogo> tipocatalogoes { get; set; }
        public DbSet<USUARIO> USUARIOs { get; set; }
        public DbSet<verificacionlocalidad> verificacionlocalidads { get; set; }
    }
}