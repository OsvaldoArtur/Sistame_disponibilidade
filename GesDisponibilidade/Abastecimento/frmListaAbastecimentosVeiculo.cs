using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesDisponibilidade.Abastecimento
{
    public partial class frmListaAbastecimentosVeiculo : MetroFramework.Forms.MetroForm
    {
        GesviaturasEntities si = new GesviaturasEntities();
        public int idviatura { get; set; }
        public frmListaAbastecimentosVeiculo()
        {
            InitializeComponent();
        }
        void listar() {
            try
            {
                var matrcicula = si.Viatura_tb.Where(r => r.idViaturas == idviatura).FirstOrDefault();
             //   idviatura = matrcicula.idViaturas;
                int idFludi = int.Parse(matrcicula.idFluido.ToString());
                var buscaFluido = si.Fluidos_tb.Where(d => d.idFluido == idFludi).FirstOrDefault();
                txtCombustivel.Text = buscaFluido.NomeFluido;
                txtEstadoConservacao.Text = matrcicula.EstadoViatura;
                txtKmCadastro.Text = matrcicula.KmCadastro;
                txtMatricula.Text = matrcicula.Matricula;
                txtModelo.Text = matrcicula.ModeloViatura;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void frmListaAbastecimentosVeiculo_Load(object sender, EventArgs e)
        {
            listar();
            abastecimento_tbBindingSource.DataSource = si.Abastecimento_tb.Where(d => d.idVeiculo == idviatura).ToList();
        }
    }
}
