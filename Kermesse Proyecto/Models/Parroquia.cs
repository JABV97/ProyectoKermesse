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
    using System.ComponentModel.DataAnnotations;

    public partial class Parroquia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parroquia()
        {
            this.Kermesse = new HashSet<Kermesse>();
        }
    
        [Display(Name = "Codigo")]
        public int idParroquia { get; set; }

        [Display(Name = "Nombre")]
        [Required, StringLength(100)]
        public string nombre { get; set; }

        [Display(Name = "Direccion")]
        [Required, StringLength(100)]
        public string direccion { get; set; }

        [Display(Name = "Telefono")]
        [Required, StringLength(15)]
        public string telefono { get; set; }

        [Display(Name = "Parroco")]
        [Required, StringLength(100)]
        public string parroco { get; set; }

        [Display(Name = "Logo")]
        [Required, StringLength(100)]
        public string logo { get; set; }

        [Display(Name = "Sitio Web")]
        [Required, StringLength(50)]
        public string sitioWeb { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kermesse> Kermesse { get; set; }
    }
}
