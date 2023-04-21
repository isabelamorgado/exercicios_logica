using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaValoresNumericos
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
            if (textboxmaiorvalor.Text != "" && textboxmaiorvalor.Text != "")
            {
                //DECLARAÇÃO E ATRIBUIÇÃO DAS VARIÁVEIS
                int maiorvalor = Convert.ToInt32(textboxmaiorvalor.Text);
                int menorvalor = Convert.ToInt32(textboxmenorvalor.Text);

                //CÁLCULO
                if (menorvalor > maiorvalor)
                {
                    labelresultado.Text = "A diferença entre os números lidos é " + (menorvalor - maiorvalor);
                }
                else
                {
                    labelresultado.Text = "A diferença entre os números lidos é " + (maiorvalor - menorvalor);
                }
            }
        }
    }
}
