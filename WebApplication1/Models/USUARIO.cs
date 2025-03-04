//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            this.GESTION_PLANES_COBRO = new HashSet<GESTION_PLANES_COBRO>();
            this.INCIDENCIA = new HashSet<INCIDENCIA>();
            this.REPORTES = new HashSet<REPORTES>();
            this.RESERVA_AREA_COMUN = new HashSet<RESERVA_AREA_COMUN>();
            this.RESERVACION = new HashSet<RESERVACION>();
            this.RESIDENCIA = new HashSet<RESIDENCIA>();
        }
    
        public int ID_USUARIO { get; set; }
        public int ID_TIPO_USUARIO { get; set; }
        public int ID_ESTADO { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string CORREO { get; set; }
        public string CONTRASENA { get; set; }
        public string FULLNAME
        {
            get

            {
                return NOMBRE + " " + APELLIDO;
            }
        }
            
           


        public virtual ESTADO_USUARIO ESTADO_USUARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GESTION_PLANES_COBRO> GESTION_PLANES_COBRO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INCIDENCIA> INCIDENCIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REPORTES> REPORTES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESERVA_AREA_COMUN> RESERVA_AREA_COMUN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESERVACION> RESERVACION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESIDENCIA> RESIDENCIA { get; set; }
        public virtual TIPO_USUARIO TIPO_USUARIO { get; set; }
    }
}
