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
    
    public partial class sat_oxi
    {
        public Nullable<int> IdSV { get; set; }
        public int IdSO { get; set; }
        public int Nivel_oxi { get; set; }
        public string Estado { get; set; }
        public System.DateTime Fecha_regso { get; set; }
        public System.TimeSpan Hora_regso { get; set; }
    
        public virtual sig_vit sig_vit { get; set; }
    }
}
