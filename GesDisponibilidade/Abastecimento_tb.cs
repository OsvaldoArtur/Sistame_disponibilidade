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
    
    public partial class Abastecimento_tb
    {
        public int idAbastecimento { get; set; }
        public Nullable<int> idVeiculo { get; set; }
        public Nullable<System.DateTime> DataAbastecimento { get; set; }
        public Nullable<System.DateTime> DataRegisto { get; set; }
        public Nullable<decimal> Litros { get; set; }
        public Nullable<long> KmInicio { get; set; }
        public Nullable<long> KmFinais { get; set; }
        public Nullable<long> KmPercorridos { get; set; }
        public Nullable<decimal> Consumo { get; set; }
        public Nullable<decimal> PrecoLitro { get; set; }
        public Nullable<decimal> Total { get; set; }
    
        public virtual Viatura_tb Viatura_tb { get; set; }
    }
}
