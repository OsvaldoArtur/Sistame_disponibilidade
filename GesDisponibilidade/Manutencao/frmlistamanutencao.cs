using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesDisponibilidade.Manutencao
{
    public partial class frmlistamanutencao : MetroFramework.Forms.MetroForm
    {
        public frmlistamanutencao()
        {
            InitializeComponent();
        }
        GesviaturasEntities si = new GesviaturasEntities();
        public int idViatura { get; set; }
        private void frmlistamanutencao_Load(object sender, EventArgs e)
        {
            view_ManutencaoBindingSource.DataSource = si.View_Manutencao.Where(d => d.idVeiculo == idViatura).ToList();
        }
        public int idManutencao { get; set; }
        private void view_ManutencaoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idManutencao = int.Parse(view_ManutencaoDataGridView.CurrentRow.Cells[2].Value.ToString());
                view_FluidosManutencaoBindingSource.DataSource = si.View_FluidosManutencao.Where(d => d.idManutencao == idManutencao).ToList();
                pecasManutencao_tbBindingSource.DataSource = si.PecasManutencao_tb.Where(s => s.idManutencao == idManutencao).ToList();
            }
            catch (Exception)
            {

                return ;
            }
        }

        private void view_ManutencaoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idManutencao = int.Parse(view_ManutencaoDataGridView.CurrentRow.Cells[2].Value.ToString());
                view_FluidosManutencaoBindingSource.DataSource = si.View_FluidosManutencao.Where(d => d.idManutencao == idManutencao).ToList();
                pecasManutencao_tbBindingSource.DataSource = si.PecasManutencao_tb.Where(s => s.idManutencao == idManutencao).ToList();
            }
            catch (Exception)
            {

                return;
            }
        }
    }
}
