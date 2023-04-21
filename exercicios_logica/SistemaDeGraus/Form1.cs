using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGraus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonconversao_Click(object sender, EventArgs e)
        {
            //VERIFICAR SE TODAS AS CAIXAS DE TEXTO ESTÃO PREENCHIDAS
            if (textboxcelsius.Text != "")
            {

                //DECLARAÇÃO E ATRIBUIÇÃO DAS VARIÁVEIS
                decimal fahrenheit;
                decimal celsius = Convert.ToDecimal(textboxcelsius.Text);

                //CÁLCULO
                fahrenheit = (9 * celsius + 160) / 5;

                labelfahrenheit.Text = fahrenheit.ToString();
            }
        }
    }
}
