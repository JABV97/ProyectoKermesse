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
    
    public partial class ArqueoCajaDet
    {
        public int idArqueoCajaDet { get; set; }
        public int arqueoCaja { get; set; }
        public int moneda { get; set; }
        public int denominacion { get; set; }
        public decimal cantidad { get; set; }
        public decimal subtotal { get; set; }
    
        public virtual ArqueoCaja ArqueoCaja1 { get; set; }
        public virtual Denominacion Denominacion1 { get; set; }
        public virtual Moneda Moneda1 { get; set; }
    }
}
