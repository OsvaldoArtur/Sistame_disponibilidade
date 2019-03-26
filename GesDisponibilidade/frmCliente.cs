using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesDisponibilidade
{
    public partial class frmCliente : MetroFramework.Forms.MetroForm 
    {
        GesviaturasEntities si = new GesviaturasEntities();

        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            cliente_tbBindingSource.DataSource = si.Cliente_tb.ToList();
        }
        void adicionar() {
            try
            {
                Cliente_tb cl = new Cliente_tb();
                cl.ActualizadoPor = 1;
                cl.DataNascimento = DateTime.Parse( dataNascimentoDateTimePicker.Text);
                cl.DataRegistro = DateTime.Now;
                cl.NomeCliente = nomeClienteTextBox.Text;
                cl.RegistradoPor = 1;
                si.Cliente_tb.Add(cl);
                si.SaveChanges();
                MetroFramework.MetroMessageBox.Show(this, "Cliente adicionado com sucesso, Obrigado", "Salvo com sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information );

                cliente_tbBindingSource.DataSource = si.Cliente_tb.ToList();
            }
            catch (Exception ex)
            {
                
                MetroFramework.MetroMessageBox.Show(this, "Error, Por favor contacte ao administrador do sistema: " + ex.Message, "Error no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adicionar();
            cliente_tbBindingSource.DataSource = si.Cliente_tb.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            cliente_tbBindingSource.DataSource = si.Cliente_tb.ToList();
        }
    }
}
