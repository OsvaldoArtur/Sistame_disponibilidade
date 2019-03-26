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
using MetroFramework.Controls;
using System.IO;
using GesDisponibilidade.Other;
using GesDisponibilidade.Abastecimento;
using GesDisponibilidade.Manutencao;
using GesDisponibilidade.Relatorio;

namespace GesDisponibilidade
{
    public partial class frmDisponivi : MetroFramework.Forms.MetroForm
    {
        GesviaturasEntities pos = new GesviaturasEntities();

        public frmDisponivi()
        {
            InitializeComponent();
        }

        private void preechertab()
        {
            var cate = pos.Marca_tb.ToList();
            foreach (var cat in cate)
            {
                tabControl1.TabPages.Add(cat.NomeMarca.ToString());
            }

        }


        private void addicionapronatab()
        {
            
            try
            {
                int idmarc = 1;
                foreach (TabPage tabprencher in tabControl1.TabPages)
                {
             
                    var procura = pos.Marca_tb.Where(n => n.NomeMarca.Equals(tabprencher .Text)).FirstOrDefault();//prencher as tabes pelo id da categoria
                    idmarc  = procura .idMarca;
                    var viatura = pos.Viatura_tb.Where(r => r.idMarca == idmarc ).ToList();
                    FlowLayoutPanel layou = new FlowLayoutPanel();
                    layou.AutoScroll = true;            
                    layou.WrapContents = true;
                    layou .Dock = DockStyle.Fill;
                    layou .BackColor = Color.Transparent ;

                    foreach (Viatura_tb pd in viatura )
                    {

  
                        Button but = new Button();
                         

                        but.Text = pd.ModeloViatura + " (" + pd.Matricula + ")" ;
                        but.ForeColor = Color.White;
                      
                        but.Font = new Font(("Segoe UI"), 10, FontStyle.Bold );
                        but.Size = new Size(120, 90);
                        but.Tag = pd;
                        but.Click  += AtulizarListadeprodutos;
                        layou .Controls.Add(but);

                        if (pd.Estado.Equals("Indisponivel"))
                        {
                            but.BackColor = Color.Red;

                        }
                        if (pd.Estado.Equals("Disponivel"))
                        {
                            but.BackColor = Color.Green;
                        }
                    }
                    tabprencher .Controls.Add(layou );
                    tabprencher.AutoScroll = true;
                }
            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, "Error, Por favor contacte ao administrador do sistema: " + ex.Message, "Error no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        void AtulizarListadeprodutos(object sender, EventArgs e)//introduzir na grid
        {
            Button buts = (Button)sender;
            Viatura_tb pr = (Viatura_tb)buts.Tag;

            if (pr.Estado.Equals("Indisponivel"))
            {
                frmDetalhes dt = new frmDetalhes();
                dt.idViatura = pr.idViaturas;
                dt.ShowDialog();
                pos = new GesviaturasEntities();
                tabControl1.TabPages.Clear();
                preechertab();
                addicionapronatab();
            }
            else if (pr.Estado.Equals("Disponivel"))
            {
                frmSaidaViaturaDois  dt = new frmSaidaViaturaDois();
                dt.idViatura = pr.idViaturas;
                dt.ShowDialog();
                pos = new GesviaturasEntities();
                tabControl1.TabPages.Clear();
                preechertab();
                addicionapronatab();
            }
        }



    
       


        private void frmDisponivi_Load(object sender, EventArgs e)
        {
            pos = new GesviaturasEntities();
            preechertab();
            addicionapronatab();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void motoristaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCliente cl = new frmCliente();
                cl.ShowDialog();
            }
            catch (Exception)
            {

                return;
            }
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroEmpresa cl = new frmCadastroEmpresa();
                cl.ShowDialog();
            }
            catch (Exception)
            {

                return;
            }
        }

        private void fluidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmFluidos cl = new frmFluidos();
                cl.ShowDialog();
            }
            catch (Exception)
            {

                return;
            }
        }

        private void servicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmServicos cl = new Other.frmServicos();
                cl.ShowDialog();
            }
            catch (Exception)
            {

                return;
            }
        }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAdicionarViaturas vt = new frmAdicionarViaturas();
                vt.ShowDialog();

                //pos = new GesviaturasEntities();
                //tabControl1.TabPages.Clear();
                //preechertab();
                //addicionapronatab();

            }
            catch (Exception)
            {

                return;
            }
        }

        private void saidaVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSaidaViatura vt = new frmSaidaViatura();
                vt.ShowDialog();
                pos = new GesviaturasEntities();
                //tabControl1.TabPages.Clear();
                //preechertab();
                //addicionapronatab();


            }
            catch (Exception)
            {

                return;
            }
        }

        private void relatorioSaidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void abastecimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAbastecimento  vt = new frmAbastecimento();
                vt.ShowDialog();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void manutencaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
             frmManutencao    vt = new Manutencao.frmManutencao();
                vt.ShowDialog();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void geralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRelatorioAbastecimentoGeral  vt = new frmRelatorioAbastecimentoGeral();
                vt.ShowDialog();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void saidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRelatorioCliente vt = new frmRelatorioCliente();
                vt.ShowDialog();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            if (timer1.Interval == 10000)
            {
                pos = new GesviaturasEntities();
                tabControl1.TabPages.Clear();
                preechertab();
                addicionapronatab();
                timer1.Interval += 10;
            }
            else {
                timer1.Interval = 60000;
                timer1.Stop();
                timer1.Interval = 10;
                timer1.Start();
            }
        }
    }
}
