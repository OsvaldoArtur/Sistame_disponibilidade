using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GesDisponibilidade.Abastecimento;
using GesDisponibilidade.Manutencao;
using GesDisponibilidade.Relatorio;

namespace GesDisponibilidade
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDisponivi ());
        }
    }
}
