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
    public partial class frmEntrada : MetroFramework.Forms.MetroForm 
    {
        GesviaturasEntities si = new GesviaturasEntities();

        public frmEntrada()
        {
            InitializeComponent();
        }
        public int idViatura { get; set; }
        public int idCliente { get; set; }



        private void frmEntrada_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var  pro = si.SaidaViatura_tb.Where(d => d.idViatura == idViatura && d.idCliente == idCliente).LongCount();

                if (pro !=0) {

                SaidaViatura_tb  prdo = si.SaidaViatura_tb.Where(d => d.idViatura == idViatura && d.idCliente == idCliente).ToList().LastOrDefault();

                    EntradaViatura_tb sd = new EntradaViatura_tb();
                    sd.RegistradoPor = 1;
                    sd.DataRegistro = DateTime.Now;
                    sd.ActualizadoPor = 1;
                    sd.idSaida = prdo.idSaida;
                    si.EntradaViatura_tb.Add(sd);
                    si.SaveChanges();

                    MetroFramework.MetroMessageBox.Show(this, "Entrada com sucesso, Obrigado", "Entrada com sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Viatura_tb tt = si.Viatura_tb.Where(d => d.idViaturas == idViatura).FirstOrDefault();
                    tt.Estado = "Disponivel";
                    si.SaveChanges();

                this.Close();

                }



            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, "Error, Por favor contacte ao administrador do sistema: " + ex.Message, "Error no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ;
            }
        }
    }
}
