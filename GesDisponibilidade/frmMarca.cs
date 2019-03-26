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
    public partial class frmMarca : MetroFramework.Forms.MetroForm 
    {
        GesviaturasEntities si = new GesviaturasEntities();
        public frmMarca()
        {
            InitializeComponent();
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            marca_tbBindingSource.DataSource = si.Marca_tb.ToList();
        }

        void adicionar()
        {
            try
            {
                Marca_tb mc = new Marca_tb();
                mc.NomeMarca = nomeMarcaTextBox.Text;
                mc.DataRegistro = DateTime.Now;
                mc.ActualizadoPor = 1;
                mc.RegistradoPor = 1;
                si.Marca_tb.Add(mc);
                si.SaveChanges();
                MetroFramework.MetroMessageBox.Show(this, "Marca adicionada com sucesso, Obrigado", "Salvo com sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                marca_tbBindingSource.DataSource = si.Marca_tb.ToList();
            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this,"Error, Por favor contacte ao administrador do sistema: " +ex.Message, "Error no Sistema", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adicionar();
        }
    }
}
