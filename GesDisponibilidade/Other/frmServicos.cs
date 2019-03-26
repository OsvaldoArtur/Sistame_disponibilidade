using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesDisponibilidade.Other
{
    public partial class frmServicos : MetroFramework.Forms.MetroForm
    {
        GesviaturasEntities si = new GesviaturasEntities();
        public frmServicos()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Servicos_tb sv = new GesDisponibilidade.Servicos_tb();
                sv.DescricaoServico = descricaoServicoTextBox.Text;
                sv.NomeServico = nomeServicoTextBox.Text;
                si.Servicos_tb.Add(sv);
                si.SaveChanges();
                MetroFramework.MetroMessageBox.Show(this, "Dados adicionados com sucesso, Obrigado", "Opercao com sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                servicos_tbBindingSource.DataSource = si.Servicos_tb.ToList();

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error, Por favor contacte ao administrador do sistema: " + ex.Message, "Error no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void frmServicos_Load(object sender, EventArgs e)
        {
            servicos_tbBindingSource.DataSource = si.Servicos_tb.ToList();
        }
    }
}
