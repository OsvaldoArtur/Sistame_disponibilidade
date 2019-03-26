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
    public partial class frmRegistoUsuario : MetroFramework.Forms.MetroForm
    {
        public frmRegistoUsuario()
        {
            InitializeComponent();
        }
        GesviaturasEntities si = new GesviaturasEntities();
        void adicionar() {
            try
            {
                Usuario_tb t = new Usuario_tb();
                t.Contacto = contactoTextBox.Text;
                t.DataNascimento = DateTime.Parse(dataNascimentoDateTimePicker.Text);
                t.NomeCompleto = nomeCompletoTextBox.Text;
                t.Senha = senhaTextBox.Text;
                t.Usuario = usuarioTextBox.Text;
                si.Usuario_tb.Add(t);
                si.SaveChanges();
                MetroFramework.MetroMessageBox.Show(this, "Salvo Com Sucesso", "Usuario adicionado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_tbBindingSource.DataSource = si.Usuario_tb.ToList();
            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, "Erro:" + ex.Message, "Contacte o Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            adicionar();
        }

        private void frmRegistoUsuario_Load(object sender, EventArgs e)
        {
            usuario_tbBindingSource.DataSource = si.Usuario_tb.ToList();
        }
    }
}
