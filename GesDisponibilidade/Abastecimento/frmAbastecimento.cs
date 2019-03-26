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

namespace GesDisponibilidade.Abastecimento
{
    public partial class frmAbastecimento : MetroFramework.Forms.MetroForm
    {
        public frmAbastecimento()
        {
            InitializeComponent();
        }
        GesviaturasEntities si = new GesviaturasEntities();
        public int idViat { get; set; }
        private void textBoxBuscaCarro_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
                
            //}
        }
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private void kmInicioTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(kmInicioTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                kmInicioTextBox.Text = kmInicioTextBox.Text.Remove(kmInicioTextBox.Text.Length - 1);
            }
        }

        void adicionarprimeiro()
        {
            try
            {
                Abastecimento_tb ab = new GesDisponibilidade.Abastecimento_tb();
                ab.KmInicio = long.Parse(textBox1.Text);
                ab.KmFinais = long.Parse(kmInicioTextBox.Text);
                ab.idVeiculo = idViat;
                ab.Litros = decimal.Parse(litrosTextBox.Text);
                ab.DataRegisto = DateTime.Now;
                ab.DataAbastecimento = DateTime.Parse(dataAbastecimentoDateTimePicker.Text);

                long kmpercoridos = long.Parse(kmInicioTextBox.Text) - long.Parse(textBox1.Text);

                ab.KmPercorridos = kmpercoridos;

                decimal consumo = (kmpercoridos / decimal.Parse(litrosTextBox.Text));
                ab.Consumo = consumo;

                decimal totalpreco = decimal.Parse(litrosTextBox.Text) * decimal.Parse(precoLitroTextBox.Text);

                ab.PrecoLitro = decimal.Parse(precoLitroTextBox.Text);
                ab.Total = totalpreco;

                si.Abastecimento_tb.Add(ab);
                si.SaveChanges();
                MetroFramework.MetroMessageBox.Show(this, "Abastecimento efectuado com sucesso, Obrigado", "Opercao com sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn1.Visible = true;
                btn2.Visible = false;
                textBox1.Visible = false;
                label8.Visible = false;

            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, "Error, Por favor contacte ao administrador do sistema: " + ex.Message, "Error no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string kmfinas;
        void adicionarsegundo()
        {
            try
            {
                var contarexistentes = si.Abastecimento_tb.Where(d => d.idVeiculo == idViat).Count();
                if (contarexistentes >= 1)
                {
                    var leva = si.Abastecimento_tb.Where(d => d.idVeiculo == idViat).ToList();
                    foreach (var a in leva)
                    {

                        kmfinas = a.KmFinais.ToString();
                    }
                    //            long kmactual = long.Parse();
                    if ( long.Parse(kmInicioTextBox.Text) <= long.Parse(kmfinas) )
                    {
                        MetroFramework.MetroMessageBox.Show(this, "A Kilometragem inserida e inferior ou igual a anterior Registada!! " + "\n Anterior = " + kmfinas.ToString() + "\n Altere a Kilometragem por favor!", "Opercao Recusada.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else {

                        Abastecimento_tb ab = new GesDisponibilidade.Abastecimento_tb();
                        ab.KmFinais = long.Parse(kmInicioTextBox.Text);
                        ab.KmInicio = long.Parse(kmfinas);
                        ab.idVeiculo = idViat;
                        ab.Litros = decimal.Parse(litrosTextBox.Text);
                        ab.DataRegisto = DateTime.Now;
                        ab.DataAbastecimento = DateTime.Parse(dataAbastecimentoDateTimePicker.Text);
                        long kmpercoridos = long.Parse(kmInicioTextBox.Text) - long.Parse(kmfinas);
                        ab.KmPercorridos = kmpercoridos;
                        decimal consumo = (kmpercoridos / decimal.Parse(litrosTextBox.Text));
                        ab.Consumo = consumo;
                        decimal totalpreco = decimal.Parse(litrosTextBox.Text) * decimal.Parse(precoLitroTextBox.Text);
                        ab.PrecoLitro = decimal.Parse(precoLitroTextBox.Text);
                        ab.Total = totalpreco;
                        si.Abastecimento_tb.Add(ab);
                        si.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Abastecimento efectuado com sucesso, Obrigado", "Opercao com sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    
                }
            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, "Error, Por favor contacte ao administrador do sistema: " + ex.Message, "Error no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                adicionarprimeiro();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error, Por favor contacte ao administrador do sistema: " + ex.Message, "Error no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = kmInicioTextBox.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void litrosTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(litrosTextBox.Text, "[^0-9 ,]"))
            {
                MessageBox.Show("Please enter only numbers.");
                litrosTextBox.Text = litrosTextBox.Text.Remove(litrosTextBox.Text.Length - 1);
            }


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            adicionarsegundo();
        }

        private void precoLitroTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(precoLitroTextBox.Text, "[^0-9 ,]"))
            {
                MessageBox.Show("Please enter only numbers.");
                precoLitroTextBox.Text = precoLitroTextBox.Text.Remove(precoLitroTextBox.Text.Length - 1);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (idViat != 0) {
                    frmListaAbastecimentosVeiculo ls = new Abastecimento.frmListaAbastecimentosVeiculo();
                    ls.idviatura = idViat;
                    ls.ShowDialog();
                }
               
            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, "Error, Por favor contacte ao administrador do sistema: " + ex.Message, "Error no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxBuscaCarro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cantarExistencia = si.Viatura_tb.Where(r => r.Matricula.Equals(textBoxBuscaCarro.Text)).Count();
                if (cantarExistencia == 1)
                {
                    var matrcicula = si.Viatura_tb.Where(r => r.Matricula.Equals(textBoxBuscaCarro.Text)).FirstOrDefault();
                    idViat = matrcicula.idViaturas;
                    int idFludi = int.Parse(matrcicula.idFluido.ToString());
                    var buscaFluido = si.Fluidos_tb.Where(d => d.idFluido == idFludi).FirstOrDefault();
                    txtCombustivel.Text = buscaFluido.NomeFluido;
                    txtEstadoConservacao.Text = matrcicula.EstadoViatura;
                    txtKmCadastro.Text = matrcicula.KmCadastro;
                    txtMatricula.Text = matrcicula.Matricula;
                    txtModelo.Text = matrcicula.ModeloViatura;
                 

                    lblEncontrar.Text = "Econtrado com Sucesso!";
                    //procurar abastecimentos
                    var procura = si.Abastecimento_tb.Where(d => d.idVeiculo == matrcicula.idViaturas).Count();
                    if (procura == 0)
                    {
                        btn2.Visible = true;
                        textBox1.Visible = true;
                        label8.Visible = true;
                        btn1.Visible = false;
                    }
                    else
                    {
                        btn1.Visible = true;
                        btn2.Visible = false;
                        textBox1.Visible = false;
                        label8.Visible = false;
                    }

         //           pictureBox1.Image = ByteToImage(matrcicula.Foto);

                }
                else
                {
                    //MetroFramework.MetroMessageBox.Show(this, "Nenhuma viatura encontrada com esta matricula", "Tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblEncontrar.Text = "Nenhuma viatura econtrada";
                }



            }
            catch (System.Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error, Por favor contacte ao administrador do sistema: " + ex.Message, "Error no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
