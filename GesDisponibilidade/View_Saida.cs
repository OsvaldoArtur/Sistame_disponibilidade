//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GesDisponibilidade
{
    using System;
    using System.Collections.Generic;
    
    public partial class View_Saida
    {
        public int idSaida { get; set; }
        public int idViaturas { get; set; }
        public int idCliente { get; set; }
        public int idMarca { get; set; }
        public Nullable<System.DateTime> DataSaida { get; set; }
        public Nullable<System.DateTime> DataDevolucao { get; set; }
        public string NomeCliente { get; set; }
        public string NomeMarca { get; set; }
        public string ModeloViatura { get; set; }
        public string AnoFabrico { get; set; }
        public string Matricula { get; set; }
    }
}
