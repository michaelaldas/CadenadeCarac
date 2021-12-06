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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int conteo = 0, i = 0;
            string frase = Txt1.Text;
            while (frase[i] == ' ')
                i++;
            if (frase[i] == '.')
                conteo--;
            while (frase[i] != ' ')
            {
                if (frase[i] == ' ')
                {
                    conteo++;
                    while (frase[i] == '.') i++;
                    if (frase[i] == '.') conteo++;
                }
                else
                {
                    i++;
                }
            }
            conteo++;
            Console.WriteLine($"{0}", conteo);
            this.Txt2.Text = conteo.ToString();

        }
    }
}
