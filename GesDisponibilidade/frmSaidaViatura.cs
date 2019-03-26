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
    public partial class frmSaidaViatura : MetroFramework.Forms.MetroForm
    {
        GesviaturasEntities si = new GesviaturasEntities();

        public frmSaidaViatura()
        {
            InitializeComponent();
            autocomplet();

        }
        private int idCliente;

        void autocomplet()
        {
            AutoCompleteStringCollection cl = new AutoCompleteStringCollection();
            si = new GesviaturasEntities();
            var pro = si.Cliente_tb.ToList();
            foreach (var item in pro)
            {
                cl.Add(item.NomeCliente.ToString());
            }
            idClienteTextBox.AutoCompleteCustomSource = cl;

        }


        private void frmSaidaViatura_Load(object sender, EventArgs e)
        {
            viaturatbBindingSource.DataSource = si.Viatura_tb.Where(d => d.Estado.Equals("Disponivel")).ToList();
            
            
        }

        private void idClienteTextBox_TextChanged(object sender, EventArgs e)
        {
            {
                if (!idClienteTextBox.Text.Equals(""))
                {
                    var nclien = si.Cliente_tb.Where(c => c.NomeCliente.Equals(idClienteTextBox.Text)).Count();
                    if (nclien != 0)
                    {
                        var clien = si.Cliente_tb.Where(c => c.NomeCliente.Equals(idClienteTextBox.Text)).FirstOrDefault();
                        label3.Text = clien.NomeCliente.ToString();
                        idCliente = clien.idCliente;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private int idViatura;

        private void idViaturaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idViatura = int.Parse(idViaturaComboBox.SelectedValue.ToString());
                var leva = si.View_CarroMarca.Where(d => d.idViaturas == idViatura).FirstOrDefault();
                labelAnoFabrico.Text = leva.AnoFabrico.ToString();
                labelEstado.Text = leva.Estado.ToString();
                labelMarca.Text = leva.NomeMarca.ToString();
                labelModelo.Text = leva.ModeloViatura.ToString ();
                label4.Text = leva.Matricula.ToString();
                labelMatricula.Text = leva.Matricula.ToString();
            }
            catch (Exception)
            {


                return ;
            }
        }
        void adicionar() {
            try
            {
                SaidaViatura_tb sv = new SaidaViatura_tb();
                sv.ActualizadoPor = 1;
                sv.DataDevolucao = DateTime.Parse(dataDevolucaoDateTimePicker.Text);
                sv.DataRegistro = DateTime.Now;
                sv.DataSaida = DateTime.Parse(dataSaidaDateTimePicker.Text);
                sv.Diasdealerta = 0;
                sv.idCliente = idCliente;
                sv.idViatura = idViatura;
                sv.RegistradoPor = 1;
                si.SaidaViatura_tb.Add(sv);
                si.SaveChanges();

                MetroFramework.MetroMessageBox.Show(this, "Delivery adicionado com sucesso, Obrigado", "Delivery com sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Viatura_tb sd = si.Viatura_tb.Where(d => d.idViaturas == idViatura).FirstOrDefault();
                sd.Estado = "Indisponivel";
                si.SaveChanges();

                viaturatbBindingSource.DataSource = si.Viatura_tb.Where(d => d.Estado.Equals("Disponivel")).ToList();

                this.Close();

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error, Por favor contacte ao administrador do sistema: " + ex.Message, "Error no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            adicionar();
            viaturatbBindingSource.DataSource = si.Viatura_tb.Where(d => d.Estado.Equals("Disponivel")).ToList();

        }
        private DateTime t1, t2;
        private TimeSpan    tempo;

        private void dataDevolucaoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            t1 = DateTime.Parse(dataSaidaDateTimePicker.Text);
            t2 = DateTime.Parse(dataDevolucaoDateTimePicker.Text);
            //    calculartempo(t1, t2);
            TimeSpan t = t2 - t1;
            double NrOfDays = t.TotalDays;
            labelTotalDias.Text = NrOfDays.ToString();
        }

        void calculartempo(DateTime t1, DateTime t2)

        {
            tempo = t2 - t1;
            labelTotalDias .Text = tempo.ToString();

        }
    }
}