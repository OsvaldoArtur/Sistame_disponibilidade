using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace GesDisponibilidade
{
    public partial class frmDetalhes : MetroFramework.Forms.MetroForm 
    {
        GesviaturasEntities si = new GesviaturasEntities();

        public frmDetalhes()
        {
            InitializeComponent();
        }
        public int idViatura { get; set; }
        int idCliente, idsaida;
        void lista()
        {
            var lista = si.View_Saida.Where(d => d.idViaturas == idViatura).ToList();
            foreach (var item in lista)
            {
                idCliente = item.idCliente;
                idsaida = item.idSaida;
            }
           
            var leva = si.View_Saida .Where(d => d.idViaturas == idViatura && d.idCliente == idCliente && d.idSaida == idsaida).FirstOrDefault();

            dataSaidaLabel1.Text = leva.DataSaida.ToString();
            dataDevolucaoLabel1.Text = leva.DataDevolucao.ToString();
            nomeClienteLabel1.Text = leva.NomeCliente.ToString();
            nomeMarcaLabel1.Text = leva.NomeMarca.ToString();
            matriculaLabel1.Text = leva.Matricula.ToString();
            modeloViaturaLabel1.Text = leva.ModeloViatura.ToString();
            anoFabricoLabel1.Text = leva.AnoFabrico.ToString();
            idCliente =int.Parse(leva.idCliente.ToString());
        }
        private void frmDetalhes_Load(object sender, EventArgs e)
        {
            lista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmEntrada ent = new frmEntrada();
                ent.idViatura = idViatura;
                ent.idCliente = idCliente;
                ent.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {

                return ;
            }
        }
    }
}
