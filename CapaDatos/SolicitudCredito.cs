//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class SolicitudCredito
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SolicitudCredito()
        {
            this.RecepcionSolicitudes = new HashSet<RecepcionSolicitudes>();
        }
    
        public int IDSolicitud { get; set; }
        public int IdTipoIdentificacion { get; set; }
        public int Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int IdTipoCreditos { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Correo { get; set; }
        public decimal Monto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecepcionSolicitudes> RecepcionSolicitudes { get; set; }
        public virtual TipoCreditos TipoCreditos { get; set; }
        public virtual TipoIdentificacion TipoIdentificacion { get; set; }
    }
}
