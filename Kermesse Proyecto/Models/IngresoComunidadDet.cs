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
    
    public partial class IngresoComunidadDet
    {
        public int idIngresoComunidadDet { get; set; }
        public int ingresoComunidad { get; set; }
        public int bono { get; set; }
        public string denominacion { get; set; }
        public int cantidad { get; set; }
        public double subTotalBono { get; set; }
    
        public virtual ControlBono ControlBono { get; set; }
        public virtual IngresoComunidad IngresoComunidad1 { get; set; }
    }
}
