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
    
    public partial class Cliente_tb
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente_tb()
        {
            this.Manutencao_tb = new HashSet<Manutencao_tb>();
            this.SaidaViatura_tb = new HashSet<SaidaViatura_tb>();
        }
    
        public int idCliente { get; set; }
        public string NomeCliente { get; set; }
        public Nullable<System.DateTime> DataNascimento { get; set; }
        public Nullable<System.DateTime> DataRegistro { get; set; }
        public Nullable<int> RegistradoPor { get; set; }
        public Nullable<int> ActualizadoPor { get; set; }
        public string Telefone { get; set; }
        public string EnderecoResidencia { get; set; }
        public string Email { get; set; }
        public string Observacoes { get; set; }
        public byte[] Foto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Manutencao_tb> Manutencao_tb { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaidaViatura_tb> SaidaViatura_tb { get; set; }
    }
}
