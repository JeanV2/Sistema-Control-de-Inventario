//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaEntidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class TbSolicitudCompra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TbSolicitudCompra()
        {
            this.TbCompraSolicitudP = new HashSet<TbCompraSolicitudP>();
        }
    
        public string IdSolicitudCompra { get; set; }
        public Nullable<System.DateTime> FechaSolicitudCompra { get; set; }
        public string IdColaboradorCompra { get; set; }
        public Nullable<bool> EstadoSolicitudCompra { get; set; }
    
        public virtual TbColaborador TbColaborador { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TbCompraSolicitudP> TbCompraSolicitudP { get; set; }
    }
}
