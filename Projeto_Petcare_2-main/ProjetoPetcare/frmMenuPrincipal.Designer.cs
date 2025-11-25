namespace ProjetoPetcare
{
    partial class frmMenuPrincipal
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
            this.btncliente = new System.Windows.Forms.Button();
            this.btncadacliente = new System.Windows.Forms.Button();
            this.btncadasanimal = new System.Windows.Forms.Button();
            this.btncadasvaterinario = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncliente
            // 
            this.btncliente.BackColor = System.Drawing.Color.DimGray;
            this.btncliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncliente.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncliente.ForeColor = System.Drawing.Color.LightCyan;
            this.btncliente.Location = new System.Drawing.Point(356, 78);
            this.btncliente.MaximumSize = new System.Drawing.Size(10, 50);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(0, 0);
            this.btncliente.TabIndex = 0;
            this.btncliente.Text = "Cadastro cliente";
            this.btncliente.UseVisualStyleBackColor = false;
            // 
            // btncadacliente
            // 
            this.btncadacliente.BackColor = System.Drawing.Color.Gray;
            this.btncadacliente.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadacliente.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btncadacliente.Location = new System.Drawing.Point(356, 78);
            this.btncadacliente.Name = "btncadacliente";
            this.btncadacliente.Size = new System.Drawing.Size(255, 76);
            this.btncadacliente.TabIndex = 1;
            this.btncadacliente.Text = "Cadastro Cliente";
            this.btncadacliente.UseVisualStyleBackColor = false;
            this.btncadacliente.Click += new System.EventHandler(this.btncadacliente_Click);
            // 
            // btncadasanimal
            // 
            this.btncadasanimal.BackColor = System.Drawing.Color.Gray;
            this.btncadasanimal.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadasanimal.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btncadasanimal.Location = new System.Drawing.Point(356, 189);
            this.btncadasanimal.Name = "btncadasanimal";
            this.btncadasanimal.Size = new System.Drawing.Size(255, 76);
            this.btncadasanimal.TabIndex = 2;
            this.btncadasanimal.Text = "Cadastro Animal";
            this.btncadasanimal.UseVisualStyleBackColor = false;
            this.btncadasanimal.Click += new System.EventHandler(this.btncadasanimal_Click);
            // 
            // btncadasvaterinario
            // 
            this.btncadasvaterinario.BackColor = System.Drawing.Color.Gray;
            this.btncadasvaterinario.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadasvaterinario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btncadasvaterinario.Location = new System.Drawing.Point(356, 292);
            this.btncadasvaterinario.Name = "btncadasvaterinario";
            this.btncadasvaterinario.Size = new System.Drawing.Size(255, 76);
            this.btncadasvaterinario.TabIndex = 3;
            this.btncadasvaterinario.Text = "Cadastro Veterinário";
            this.btncadasvaterinario.UseVisualStyleBackColor = false;
            this.btncadasvaterinario.Click += new System.EventHandler(this.btncadasvaterinario_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsair.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnsair.Location = new System.Drawing.Point(356, 400);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(255, 76);
            this.btnsair.TabIndex = 5;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1002, 658);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btncadasvaterinario);
            this.Controls.Add(this.btncadasanimal);
            this.Controls.Add(this.btncadacliente);
            this.Controls.Add(this.btncliente);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.Text = "Cadastro Clinete";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Button btncadacliente;
        private System.Windows.Forms.Button btncadasanimal;
        private System.Windows.Forms.Button btncadasvaterinario;
        private System.Windows.Forms.Button btnsair;
    }
}