//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoHabitacion
    {
        public TipoHabitacion()
        {
            this.Habitacion = new HashSet<Habitacion>();
        }
    
        public int idTipoHabitacion { get; set; }
        public string nombre { get; set; }
        public Nullable<int> capacidadMaxima { get; set; }
    
        public virtual ICollection<Habitacion> Habitacion { get; set; }
    }
}