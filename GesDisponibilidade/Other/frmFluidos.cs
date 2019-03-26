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
    public partial class frmFluidos : MetroFramework.Forms.MetroForm
    {
        GesviaturasEntities si = new GesviaturasEntities();

        public frmFluidos()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Fluidos_tb fl = new Fluidos_tb();
                fl.NomeFluido = nomeFluidoTextBox.Text;
                fl.UnidadeMedida = unidadeMedidaTextBox.Text;
                si.Fluidos_tb.Add(fl);
                si.SaveChanges();
                MetroFramework.MetroMessageBox.Show(this, "Dados adicionados com sucesso, Obrigado", "Opercao com sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fluidos_tbBindingSource.DataSource = si.Fluidos_tb.ToList();
                
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error, Por favor contacte ao administrador do sistema: " + ex.Message, "Error no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmFluidos_Load(object sender, EventArgs e)
        {
            fluidos_tbBindingSource.DataSource = si.Fluidos_tb.ToList();
        }
    }
}
