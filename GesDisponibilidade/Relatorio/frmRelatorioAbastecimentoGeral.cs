using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesDisponibilidade.Relatorio
{
    public partial class frmRelatorioAbastecimentoGeral : MetroFramework.Forms.MetroForm
    {
        GesviaturasEntities si = new GesviaturasEntities();
        public frmRelatorioAbastecimentoGeral()
        {
            InitializeComponent();
        }
        private DateTime d1, d2;

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            d2 = DateTime.Parse(dateTimePicker2.Value.ToShortDateString());
            listar();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            d1 = DateTime.Parse(dateTimePicker1.Value.ToShortDateString());
            listar();
        }

        private void frmRelatorioAbastecimentoGeral_Load(object sender, EventArgs e)
        {
            View_AbastecimentoBindingSource.DataSource = si.View_Abastecimento.ToList();
            Empresa_tbBindingSource.DataSource = si.Empresa_tb.ToList();
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            reportViewer1.ZoomPercent = 100;
            
        }
        void listar() {
            View_AbastecimentoBindingSource.DataSource = si.View_Abastecimento.Where(d=> d.DataAbastecimento >=  d1 && d.DataAbastecimento <= d2).ToList();
           this.reportViewer1.RefreshReport();
           
        }
    }
}
