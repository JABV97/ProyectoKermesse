//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kermesse_Proyecto.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ControlBono
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ControlBono()
        {
            this.IngresoComunidadDet = new HashSet<IngresoComunidadDet>();
        }
    
        public int idBono { get; set; }
        public string nombre { get; set; }
        public double valor { get; set; }
        public int estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IngresoComunidadDet> IngresoComunidadDet { get; set; }
    }
}
