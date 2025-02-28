namespace AppGeradorLoterias
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.btQuina = new System.Windows.Forms.Button();
			this.btMega = new System.Windows.Forms.Button();
			this.btLotoFacil = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btQuina
			// 
			this.btQuina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btQuina.ForeColor = System.Drawing.Color.Blue;
			this.btQuina.Location = new System.Drawing.Point(79, 220);
			this.btQuina.Name = "btQuina";
			this.btQuina.Size = new System.Drawing.Size(179, 42);
			this.btQuina.TabIndex = 29;
			this.btQuina.Text = "QUINA";
			this.btQuina.UseVisualStyleBackColor = true;
			// 
			// btMega
			// 
			this.btMega.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btMega.ForeColor = System.Drawing.Color.Green;
			this.btMega.Location = new System.Drawing.Point(79, 131);
			this.btMega.Name = "btMega";
			this.btMega.Size = new System.Drawing.Size(179, 42);
			this.btMega.TabIndex = 28;
			this.btMega.Text = "MEGA SENA";
			this.btMega.UseVisualStyleBackColor = true;
			// 
			// btLotoFacil
			// 
			this.btLotoFacil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btLotoFacil.ForeColor = System.Drawing.Color.MediumVioletRed;
			this.btLotoFacil.Location = new System.Drawing.Point(428, 131);
			this.btLotoFacil.Name = "btLotoFacil";
			this.btLotoFacil.Size = new System.Drawing.Size(179, 42);
			this.btLotoFacil.TabIndex = 27;
			this.btLotoFacil.Text = "LOTOFÁCIL";
			this.btLotoFacil.UseVisualStyleBackColor = true;
			this.btLotoFacil.Click += new System.EventHandler(this.btLotoFacil_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.DarkOrange;
			this.button1.Location = new System.Drawing.Point(428, 220);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(179, 42);
			this.button1.TabIndex = 30;
			this.button1.Text = "LOTOMANIA";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.DarkOrange;
			this.button2.Location = new System.Drawing.Point(249, 299);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(179, 42);
			this.button2.TabIndex = 31;
			this.button2.Text = "DIADESORTE";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(705, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btQuina);
			this.Controls.Add(this.btMega);
			this.Controls.Add(this.btLotoFacil);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btQuina;
        private System.Windows.Forms.Button btMega;
        private System.Windows.Forms.Button btLotoFacil;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}

