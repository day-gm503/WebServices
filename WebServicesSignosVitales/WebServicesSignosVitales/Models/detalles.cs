//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServicesSignosVitales.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class detalles
    {
        public Nullable<int> IdFC { get; set; }
        public int Idregistro { get; set; }
        public string Distancia_recor { get; set; }
        public int Nopasos { get; set; }
        public int Calorias_quem { get; set; }
        public System.DateTime Fecha_regde { get; set; }
        public System.TimeSpan Hora_regde { get; set; }
    
        public virtual fre_card fre_card { get; set; }
    }
}