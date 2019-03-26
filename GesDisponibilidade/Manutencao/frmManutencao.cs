using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesDisponibilidade.Manutencao
{
    public partial class frmManutencao : MetroFramework.Forms.MetroForm
    {
        GesviaturasEntities si = new GesviaturasEntities();

        public frmManutencao()
        {
            InitializeComponent();
            autocomplet();
        }
        public int idve { get; set; }

        private void textBoxBuscaCarro_TextChanged(object sender, EventArgs e)
        {

            try
            {
                var cantarExistencia = si.Viatura_tb.Where(r => r.Matricula.Equals(textBoxBuscaCarro.Text)).Count();
                if (cantarExistencia == 1)
                {
                    var matrcicula = si.Viatura_tb.Where(r => r.Matricula.Equals(textBoxBuscaCarro.Text)).FirstOrDefault();
                    int idFludi = int.Parse(matrcicula.idFluido.ToString());
                    var buscaFluido = si.Fluidos_tb.Where(d => d.idFluido == idFludi).FirstOrDefault();
                    idve = matrcicula.idViaturas;
                    txtCombustivel.Text = buscaFluido.NomeFluido;
                    txtEstadoConservacao.Text = matrcicula.EstadoViatura;
                    txtKmCadastro.Text = matrcicula.KmCadastro;
                    txtMatricula.Text = matrcicula.Matricula;
                    txtModelo.Text = matrcicula.ModeloViatura;
                    lblEncontrar.Text = "Econtrado com Sucesso!";
                    btnManutencao.Enabled = true;
                }
                else
                {
                    //   MetroFramework.MetroMessageBox.Show(this, "Nenhuma viatura encontrada com esta matricula", "Tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblEncontrar.Text = "Nenhuma viatura econtrada";
                    btnManutencao.Enabled = false;
                    txtCombustivel.Text = "";
                    txtEstadoConservacao.Text = "";
                    txtKmCadastro.Text = "";
                    txtMatricula.Text = "";
                    txtModelo.Text = "";

                }
            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, "Error, Por favor contacte ao administrador do sistema: " + ex.Message, "Error no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



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
                        idCliente = clien.idCliente;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void frmManutencao_Load(object sender, EventArgs e)
        {
            servicostbBindingSource.DataSource = si.Servicos_tb.ToList();
            fluidostbBindingSource.DataSource = si.Fluidos_tb.ToList();
            nivelTanqueComboBox.SelectedIndex = 0;
            tipoManutencaoComboBox.SelectedIndex = 0;
            

        }
        string texto;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                texto = checkBox1.Text;
                observacoesTextBox.Enabled = false;

            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                texto = observacoesTextBox.Text;
                observacoesTextBox.Enabled = true;
            }

        }

        void adicionarmanutencao()
        {
            try
            {
                if (checkBox1.CheckState == CheckState.Unchecked)
                {
                    texto = observacoesTextBox.Text;

                }

                Manutencao_tb mn = new Manutencao_tb();
                mn.DataManutencao = DateTime.Parse(dataManutencaoDateTimePicker.Text);
                mn.DataRegisto = DateTime.Now;
                mn.HoraFim = horaFimTextBox.Text;
                mn.HoraInicio = horaInicioTextBox.Text;
                mn.idCliente = idCliente;
                mn.idVeiculo = idve;
                mn.idServico = int.Parse(comboBox1.SelectedValue.ToString());
                mn.ValorManutencao = decimal.Parse(valorManutencaoTextBox.Text);
                mn.TipoManutencao = tipoManutencaoComboBox.Text;
                mn.KilometragemManutencao = kilometragemManutencaoTextBox.Text;
                mn.NivelTanque = nivelTanqueComboBox.Text;
                mn.Observacoes = texto;

                si.Manutencao_tb.Add(mn);
                si.SaveChanges();
                idManutencao = mn.idManutencao;
                MetroFramework.MetroMessageBox.Show(this, "Manutencao efectuada com sucesso, Obrigado", "Opercao com sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnManutencao.Enabled = false;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error, Por favor contacte ao administrador do sistema: " + ex.Message, "Error no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }





        public int idManutencao { get; set; }
        private void kilometragemManutencaoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(kilometragemManutencaoTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                kilometragemManutencaoTextBox.Text = kilometragemManutencaoTextBox.Text.Remove(kilometragemManutencaoTextBox.Text.Length - 1);
            }
        }

        private void valorManutencaoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(valorManutencaoTextBox.Text, "[^0-9 ,]"))
            {
                MessageBox.Show("Please enter only numbers.");
                valorManutencaoTextBox.Text = valorManutencaoTextBox.Text.Remove(valorManutencaoTextBox.Text.Length - 1);
            }
        }

        void adicionarpecas()
        {
            try
            {
                for (int i = 0; i < dataGridView1.RowCount - 1 ; i++)
                {                   
                        String descricao = Convert.ToString(dataGridView1[0, i].Value);
                        int quantidade = Convert.ToInt16(dataGridView1[1, i].Value);
                        Decimal prexo = Convert.ToDecimal(dataGridView1[2, i].Value);
                        decimal valortotal = prexo * quantidade;
                        PecasManutencao_tb pc = new PecasManutencao_tb()
                        {
                            idManutencao  = idManutencao,
                            Descricao  = descricao,
                            Quantidade = quantidade,
                            ValorTotal  = valortotal,
                            ValorUnitario = prexo,
                        };
                        si.PecasManutencao_tb.Add(pc);
                        si.SaveChanges();                 
                    }
             
                }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error, Por favor contacte ao administrador do sistema: " + ex.Message, "Error no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        void adicionarfluidos()
        {
            try
            {
                for (int i = 0; i < dataGridView2.RowCount - 1; i++)
                {
                    int descricao = Convert.ToInt16(dataGridView2[0, i].Value);
                    int quantidade = Convert.ToInt16(dataGridView2[1, i].Value);
                    Decimal prexo = Convert.ToDecimal(dataGridView2[2, i].Value);
                    decimal valortotal = prexo * quantidade;
                    FluidosManutencao_tb  pc = new FluidosManutencao_tb()
                    {
                        idManutencao = idManutencao,
                        idFluido = descricao,
                        Quantidade = quantidade,
                        ValorTotal = valortotal,
                        ValorUnitario = prexo,
                    };
                    si.FluidosManutencao_tb.Add(pc);
                    si.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error, Por favor contacte ao administrador do sistema: " + ex.Message, "Error no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void btnManutencao_Click(object sender, EventArgs e)
        {
            adicionarmanutencao();
            adicionarpecas();
            adicionarfluidos();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (idve  != 0)
                {
                    frmlistamanutencao ls = new frmlistamanutencao();
                    ls.idViatura  = idve;
                    ls.ShowDialog();
                }

            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, "Error, Por favor contacte ao administrador do sistema: " + ex.Message, "Error no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
