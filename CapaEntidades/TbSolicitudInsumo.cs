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
    
    public partial class TbSolicitudInsumo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TbSolicitudInsumo()
        {
            this.TbProductoInsumoS = new HashSet<TbProductoInsumoS>();
        }
    
        public string IdSolicitudInsumo { get; set; }
        public string IdColaboradorEntrega { get; set; }
        public Nullable<int> tipoSolicitud { get; set; }
        public string IdColaboradorRecibe { get; set; }
        public string ReferenciaCurso { get; set; }
    
        public virtual TbColaborador TbColaborador { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TbProductoInsumoS> TbProductoInsumoS { get; set; }
    }
}
