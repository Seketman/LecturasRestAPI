//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LecturasRestAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lectura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lectura()
        {
            this.ValoresLeidos = new HashSet<ValorLeido>();
        }
    
        public int Id { get; set; }
        public System.DateTime Fecha { get; set; }
        public int MedidorId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValorLeido> ValoresLeidos { get; set; }
    }
}
