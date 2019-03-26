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
    public partial class frmCadastroEmpresa : MetroFramework.Forms.MetroForm
    {
        GesviaturasEntities si = new GesDisponibilidade.GesviaturasEntities();
        public frmCadastroEmpresa()
        {
            
            InitializeComponent();
        }

        public int idEmpresa { get; set; }
        public string imagess { get; set; }
        private void empresa_tbDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] logo = ms.GetBuffer();
                if (imagess == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Nenhuma imagem Selecionada!" , "Por favor seleciona uma image.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else {
                
                Empresa_tb ep = new GesDisponibilidade.Empresa_tb();
                ep.Email = emailTextBox.Text;
                ep.Endereco = enderecoTextBox.Text;
                ep.LogoTipo = logo;
                ep.NomeEmpresa = nomeEmpresaTextBox.Text;
                ep.Nuit = nuitTextBox.Text;
                ep.Telefone = telefoneTextBox.Text;
                si.Empresa_tb.Add(ep);
                si.SaveChanges();
                MetroFramework.MetroMessageBox.Show(this, "Dados adicionados com sucesso, Obrigado", "Opercao com sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
              empresa_tbBindingSource.DataSource =  si.Empresa_tb.ToList();
                }
            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, "Error, Por favor contacte ao administrador do sistema: " + ex.Message, "Error no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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

        private void frmCadastroEmpresa_Load(object sender, EventArgs e)
        {
            empresa_tbBindingSource.DataSource = si.Empresa_tb.ToList();
        }
    }
}
