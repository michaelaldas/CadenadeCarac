using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadenadeCarac
{
    public partial class EjercicioN2 : Form
    {
        public EjercicioN2()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        
            {
                string Entrada = Txt1.Text;
                string Salida = "";
                for (int x = Entrada.Length - 1; x >= 0; x--)
                {
                    Salida += Entrada[x];
                }
                Console.WriteLine($"{0}", Salida);
                this.Txt2.Text = Salida.ToString();
            }
    }
}
