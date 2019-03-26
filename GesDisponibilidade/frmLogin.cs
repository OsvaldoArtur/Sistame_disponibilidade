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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        GesviaturasEntities si = new GesviaturasEntities();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            var contar = si.Usuario_tb.Count();

            if (contar != 0)
            {
            }
            else {
                MetroFramework.MetroMessageBox.Show(this, "Nenhum usuario encontrado", "Registe um usuario por favor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmRegistoUsuario frm = new GesDisponibilidade.frmRegistoUsuario();
                frm.ShowDialog();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var verifica = si.Usuario_tb.Where(d => d.Usuario.Equals(textBox1.Text) && d.Senha.Equals(textBox2.Text)).Count();

                if (verifica == 1)
                {
                    frmDisponivi fv = new GesDisponibilidade.frmDisponivi();
                    fv.ShowDialog();
                    textBox2.Clear();
                }
                else {
                    MetroFramework.MetroMessageBox.Show(this, "Usuario ou senha incorrectos", "Tente novamente por favor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                return ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
