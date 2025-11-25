namespace ProjetoPetcare
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblnome = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnentrar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(311, 162);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(79, 34);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.Location = new System.Drawing.Point(311, 284);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(95, 34);
            this.lblsenha.TabIndex = 1;
            this.lblsenha.Text = "Senha";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(479, 175);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(173, 20);
            this.txtnome.TabIndex = 2;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(479, 297);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(173, 20);
            this.txtsenha.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnentrar
            // 
            this.btnentrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnentrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnentrar.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnentrar.Location = new System.Drawing.Point(598, 395);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(203, 81);
            this.btnentrar.TabIndex = 5;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsair.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsair.Location = new System.Drawing.Point(224, 395);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(203, 81);
            this.btnsair.TabIndex = 6;
            this.btnsair.Text = "Limpar";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1002, 658);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblnome);
            this.Name = "frmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Button btnsair;
    }
}

