//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCDemo2023.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pedidos
    {
        public int IdPedido { get; set; }
        public string IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public Nullable<System.DateTime> FechaPedido { get; set; }
        public Nullable<System.DateTime> FechaEntrega { get; set; }
        public Nullable<System.DateTime> FechaEnvio { get; set; }
        public Nullable<int> FormaEnvio { get; set; }
        public Nullable<decimal> Cargo { get; set; }
        public string Destinatario { get; set; }
        public string DireccionDestinatario { get; set; }
        public string CiudadDestinatario { get; set; }
        public string RegionDestinatario { get; set; }
        public string CodPostalDestinatario { get; set; }
        public string PaisDestinatario { get; set; }
    }
}