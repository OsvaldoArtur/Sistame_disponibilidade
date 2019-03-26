using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesDisponibilidade
{
    public partial class frmAdicionarViaturas : MetroFramework.Forms.MetroForm 
    {
        GesviaturasEntities si = new GesviaturasEntities();
        public frmAdicionarViaturas()
        {
            InitializeComponent();
        }

        private void frmAdicionarViaturas_Load(object sender, EventArgs e)
        {
            try
            {
                marcatbBindingSource.DataSource = si.Marca_tb.ToList();
                viewCarroMarcaBindingSource.DataSource = si.View_CarroMarca.ToList();
                estadoComboBox.SelectedIndex = 0;
                fluidostbBindingSource.DataSource = si.Fluidos_tb.ToList();
            }
            catch (Exception)
            {

                return ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                frmMarca mc = new frmMarca();
                mc.ShowDialog();
                marcatbBindingSource.DataSource = si.Marca_tb.ToList();

            }
            catch (Exception ex)
            {
                
                MetroFramework.MetroMessageBox.Show(this, "Error, Por favor contacte ao administrador do sistema: " + ex.Message, "Error no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        int idmarca;
        private string imagess;

        private void idMarcaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idmarca = int.Parse(idMarcaComboBox.SelectedValue.ToString());
            }
            catch (Exception)
            {

                return ;
            }
        }
        void adicionar() {
            try
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] logo = ms.GetBuffer();
           

                    Viatura_tb vt = new Viatura_tb();
                    vt.ActualizadoPor = 1;
                    vt.AnoFabrico = anoFabricoTextBox.Text;
                    vt.DataRegistro = DateTime.Now;
                    vt.Estado = "Disponivel";
                    vt.idMarca = int.Parse(idMarcaComboBox.SelectedValue.ToString());
                    vt.Matricula = matriculaTextBox.Text;
                    vt.ModeloViatura = modeloViaturaTextBox.Text;
                    vt.RegistradoPor = 1;
                    vt.DestinoUso = destinoUsoTextBox.Text;
                    vt.EstadoViatura = estadoComboBox.Text;
                    vt.Foto = logo;
                    vt.idFluido = int.Parse(idFluidoComboBox.SelectedValue.ToString());
                    vt.KmCadastro = kmCadastroTextBox.Text;
                    si.Viatura_tb.Add(vt);
                    si.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Viatura adicionada com sucesso, Obrigado", "Salvo com sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    viewCarroMarcaBindingSource.DataSource = si.View_CarroMarca.ToList();
                
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error, Por favor contacte ao administrador do sistema: " + ex.Message, "Error no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var verifica = si.Viatura_tb.Where(d => d.Matricula.Equals(matriculaTextBox.Text)).Count();
            if (verifica != 0) {
                MetroFramework.MetroMessageBox.Show(this, "Ja existe um carro, com essa Matricula " , "Duplicacao de Matriculas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                adicionar();
            }
            
           
            viewCarroMarcaBindingSource.DataSource = si.View_CarroMarca.ToList();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "c:/Picture/";
            open.Filter = "Todos fichiros |*.*|jpeg|*.Jpg|Bitmaps|*.bmp ";
            open.FilterIndex = 2;
            if (open.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = Image.FromFile(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                imagess = open.FileName.ToString();

            }
        }
    }
}
