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
    
    public partial class Servicos_tb
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servicos_tb()
        {
            this.Manutencao_tb = new HashSet<Manutencao_tb>();
        }
    
        public int idServicos { get; set; }
        public string NomeServico { get; set; }
        public string DescricaoServico { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Manutencao_tb> Manutencao_tb { get; set; }
    }
}
