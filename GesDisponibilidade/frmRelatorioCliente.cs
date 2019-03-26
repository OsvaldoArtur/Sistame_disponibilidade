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
    public partial class frmRelatorioCliente : MetroFramework.Forms.MetroForm 
    {
        GesviaturasEntities si = new GesviaturasEntities();
        public frmRelatorioCliente()
        {
            InitializeComponent();
            autocomplet();
        }


        //DateTime startDate = Convert.ToDateTime(dateTimePicker1.Text);
        //DateTime endDate = DateTime.Now.AddDays(1); 
        private void frmRelatorioCliente_Load(object sender, EventArgs e)
        {

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

        private void idClienteTextBox_TextChanged(object sender, EventArgs e)
        {

            {
                if (!idClienteTextBox.Text.Equals(""))
                {
                    var nclien = si.Cliente_tb.Where(c => c.NomeCliente.Equals(idClienteTextBox.Text)).Count();
                    if (nclien != 0)
                    {
                        var clien = si.Cliente_tb.Where(c => c.NomeCliente.Equals(idClienteTextBox.Text)).FirstOrDefault();
                        frmRelatorioCliente df = new frmRelatorioCliente();
                        df.Text = clien.NomeCliente.ToString();
                        idCliente = clien.idCliente;
                        view_SaidaBindingSource.DataSource = si.View_Saida.Where(d => d.idCliente == idCliente).ToList();
                    }
                    else
                    {
                        return;
                    }
                }
            }
                
                }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                view_SaidaBindingSource.DataSource = si.View_Saida.Where(d => d.idCliente == idCliente && d.DataSaida >= DateTime.Parse ( dateTimePicker1.Text) && d.DataDevolucao <= DateTime.Parse(dateTimePicker2.Text) ).ToList();

            }
            catch (Exception)
            {

                return ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                view_SaidaBindingSource.DataSource = si.View_Saida.Where(d => d.idCliente == idCliente && d.DataSaida >= DateTime.Parse(dateTimePicker1.Text) && d.DataDevolucao <= DateTime.Parse(dateTimePicker2.Text)).ToList();

            }
            catch (Exception)
            {

                return ;
            }
        }
    }
}
