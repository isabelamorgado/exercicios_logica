
namespace SistemaDeGraus02
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
            this.buttonverificar = new System.Windows.Forms.Button();
            this.labelfahrenheit = new System.Windows.Forms.Label();
            this.labelcelsius = new System.Windows.Forms.Label();
            this.textboxfahrenheit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelenunciado
            // 
            this.labelenunciado.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelenunciado.Location = new System.Drawing.Point(17, 16);
            this.labelenunciado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelenunciado.Name = "labelenunciado";
            this.labelenunciado.Size = new System.Drawing.Size(421, 87);
            this.labelenunciado.TabIndex = 0;
            this.labelenunciado.Text = "Ler uma temperatura em graus Fahrenheit e apresentá-la convertida em graus Celsiu" +
    "s. A fórmula de conversão é C = (F - 32) * (5/9) , sendo F a temperatura em Fahr" +
    "enheit e C a temperatura em Celsius.";
            // 
            // buttonverificar
            // 
            this.buttonverificar.Location = new System.Drawing.Point(303, 166);
            this.buttonverificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonverificar.Name = "buttonverificar";
            this.buttonverificar.Size = new System.Drawing.Size(100, 28);
            this.buttonverificar.TabIndex = 1;
            this.buttonverificar.Text = "Verificar";
            this.buttonverificar.UseVisualStyleBackColor = true;
            this.buttonverificar.Click += new System.EventHandler(this.buttonverificar_Click);
            // 
            // labelfahrenheit
            // 
            this.labelfahrenheit.AutoSize = true;
            this.labelfahrenheit.Location = new System.Drawing.Point(21, 122);
            this.labelfahrenheit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelfahrenheit.Name = "labelfahrenheit";
            this.labelfahrenheit.Size = new System.Drawing.Size(73, 16);
            this.labelfahrenheit.TabIndex = 2;
            this.labelfahrenheit.Text = "Fahrenheit:";
            // 
            // labelcelsius
            // 
            this.labelcelsius.AutoSize = true;
            this.labelcelsius.Location = new System.Drawing.Point(21, 191);
            this.labelcelsius.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcelsius.Name = "labelcelsius";
            this.labelcelsius.Size = new System.Drawing.Size(54, 16);
            this.labelcelsius.TabIndex = 3;
            this.labelcelsius.Text = "Celsius:";
            // 
            // textboxfahrenheit
            // 
            this.textboxfahrenheit.Location = new System.Drawing.Point(109, 118);
            this.textboxfahrenheit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textboxfahrenheit.Name = "textboxfahrenheit";
            this.textboxfahrenheit.Size = new System.Drawing.Size(132, 22);
            this.textboxfahrenheit.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 258);
            this.Controls.Add(this.textboxfahrenheit);
            this.Controls.Add(this.labelcelsius);
            this.Controls.Add(this.labelfahrenheit);
            this.Controls.Add(this.buttonverificar);
            this.Controls.Add(this.labelenunciado);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Exercício de Graus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelenunciado;
        private System.Windows.Forms.Button buttonverificar;
        private System.Windows.Forms.Label labelfahrenheit;
        private System.Windows.Forms.Label labelcelsius;
        private System.Windows.Forms.TextBox textboxfahrenheit;
    }
}

