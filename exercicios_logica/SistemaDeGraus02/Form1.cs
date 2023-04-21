using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGraus02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonverificar_Click(object sender, EventArgs e)
        {
            //VERIFICAR SE TODAS AS CAIXAS DE TEXTO ESTÃO PREENCHIDAS
            if (textboxfahrenheit.Text != "")
            {

                //DECLARAÇÃO E ATRIBUIÇÃO DAS VARIÁVEIS
                decimal celsius;
                decimal fahrenheit = Convert.ToDecimal(textboxfahrenheit.Text);

                //CÁLCULO
                celsius = (fahrenheit - 32) * 5 / 9;

                labelcelsius.Text = celsius.ToString();
            }
        }
    }
}
