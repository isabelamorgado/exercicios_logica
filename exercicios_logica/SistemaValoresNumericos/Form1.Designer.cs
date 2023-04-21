
namespace SistemaValoresNumericos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelenunciado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonverificar = new System.Windows.Forms.Button();
            this.textboxmaiorvalor = new System.Windows.Forms.TextBox();
            this.textboxmenorvalor = new System.Windows.Forms.TextBox();
            this.labelresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelenunciado
            // 
            this.labelenunciado.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelenunciado.Location = new System.Drawing.Point(13, 14);
            this.labelenunciado.Name = "labelenunciado";
            this.labelenunciado.Size = new System.Drawing.Size(376, 53);
            this.labelenunciado.TabIndex = 0;
            this.labelenunciado.Text = "Ler dois valores numéricos inteiros e apresentar o resultado da diferença do maio" +
    "r pelo menor valor.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maior Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Menor Valor:";
            // 
            // buttonverificar
            // 
            this.buttonverificar.Location = new System.Drawing.Point(272, 148);
            this.buttonverificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonverificar.Name = "buttonverificar";
            this.buttonverificar.Size = new System.Drawing.Size(75, 23);
            this.buttonverificar.TabIndex = 3;
            this.buttonverificar.Text = "Verificar";
            this.buttonverificar.UseVisualStyleBackColor = true;
            this.buttonverificar.Click += new System.EventHandler(this.buttonverificar_Click);
            // 
            // textboxmaiorvalor
            // 
            this.textboxmaiorvalor.Location = new System.Drawing.Point(115, 112);
            this.textboxmaiorvalor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxmaiorvalor.Name = "textboxmaiorvalor";
            this.textboxmaiorvalor.Size = new System.Drawing.Size(100, 22);
            this.textboxmaiorvalor.TabIndex = 4;
            // 
            // textboxmenorvalor
            // 
            this.textboxmenorvalor.Location = new System.Drawing.Point(115, 178);
            this.textboxmenorvalor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxmenorvalor.Name = "textboxmenorvalor";
            this.textboxmenorvalor.Size = new System.Drawing.Size(100, 22);
            this.textboxmenorvalor.TabIndex = 5;
            // 
            // labelresultado
            // 
            this.labelresultado.AutoSize = true;
            this.labelresultado.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelresultado.ForeColor = System.Drawing.Color.Blue;
            this.labelresultado.Location = new System.Drawing.Point(16, 252);
            this.labelresultado.Name = "labelresultado";
            this.labelresultado.Size = new System.Drawing.Size(70, 18);
            this.labelresultado.TabIndex = 6;
            this.labelresultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 292);
            this.Controls.Add(this.labelresultado);
            this.Controls.Add(this.textboxmenorvalor);
            this.Controls.Add(this.textboxmaiorvalor);
            this.Controls.Add(this.buttonverificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelenunciado);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Sistema Valores Numéricos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelenunciado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonverificar;
        private System.Windows.Forms.TextBox textboxmaiorvalor;
        private System.Windows.Forms.TextBox textboxmenorvalor;
        private System.Windows.Forms.Label labelresultado;
    }
}

