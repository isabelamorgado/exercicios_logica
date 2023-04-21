
namespace SistemaDeGraus
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
            this.labelcelsius = new System.Windows.Forms.Label();
            this.labelfahrenheit = new System.Windows.Forms.Label();
            this.buttonconversao = new System.Windows.Forms.Button();
            this.textboxcelsius = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelenunciado
            // 
            this.labelenunciado.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelenunciado.Location = new System.Drawing.Point(9, 9);
            this.labelenunciado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelenunciado.Name = "labelenunciado";
            this.labelenunciado.Size = new System.Drawing.Size(429, 84);
            this.labelenunciado.TabIndex = 0;
            this.labelenunciado.Text = "Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenhei" +
    "t. A fórmula de conversão é F = (9 * C + 160) / 5, sendo F a temperatura em Fahr" +
    "enheit e C a temperatura em Celsius.";
            // 
            // labelcelsius
            // 
            this.labelcelsius.AutoSize = true;
            this.labelcelsius.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcelsius.Location = new System.Drawing.Point(21, 128);
            this.labelcelsius.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcelsius.Name = "labelcelsius";
            this.labelcelsius.Size = new System.Drawing.Size(56, 18);
            this.labelcelsius.TabIndex = 1;
            this.labelcelsius.Text = "Celsius:";
            // 
            // labelfahrenheit
            // 
            this.labelfahrenheit.AutoSize = true;
            this.labelfahrenheit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfahrenheit.Location = new System.Drawing.Point(21, 193);
            this.labelfahrenheit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelfahrenheit.Name = "labelfahrenheit";
            this.labelfahrenheit.Size = new System.Drawing.Size(80, 18);
            this.labelfahrenheit.TabIndex = 2;
            this.labelfahrenheit.Text = "Fahrenheit:";
            // 
            // buttonconversao
            // 
            this.buttonconversao.Location = new System.Drawing.Point(293, 156);
            this.buttonconversao.Margin = new System.Windows.Forms.Padding(4);
            this.buttonconversao.Name = "buttonconversao";
            this.buttonconversao.Size = new System.Drawing.Size(100, 28);
            this.buttonconversao.TabIndex = 3;
            this.buttonconversao.Text = "Conversão";
            this.buttonconversao.UseVisualStyleBackColor = true;
            this.buttonconversao.Click += new System.EventHandler(this.buttonconversao_Click);
            // 
            // textboxcelsius
            // 
            this.textboxcelsius.Location = new System.Drawing.Point(129, 124);
            this.textboxcelsius.Margin = new System.Windows.Forms.Padding(4);
            this.textboxcelsius.Name = "textboxcelsius";
            this.textboxcelsius.Size = new System.Drawing.Size(91, 22);
            this.textboxcelsius.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 294);
            this.Controls.Add(this.textboxcelsius);
            this.Controls.Add(this.buttonconversao);
            this.Controls.Add(this.labelfahrenheit);
            this.Controls.Add(this.labelcelsius);
            this.Controls.Add(this.labelenunciado);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Exercício de Graus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelenunciado;
        private System.Windows.Forms.Label labelcelsius;
        private System.Windows.Forms.Label labelfahrenheit;
        private System.Windows.Forms.Button buttonconversao;
        private System.Windows.Forms.TextBox textboxcelsius;
    }
}

