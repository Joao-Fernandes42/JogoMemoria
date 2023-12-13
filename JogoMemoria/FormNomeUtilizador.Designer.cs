namespace JogoMemoria
{
    partial class FormNomeUtilizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNomeUtilizador));
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonRegistar = new System.Windows.Forms.Button();
            this.linkLabelMostrar = new System.Windows.Forms.LinkLabel();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxRepPasse = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPass
            // 
            this.textBoxPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPass.Location = new System.Drawing.Point(18, 55);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(137, 23);
            this.textBoxPass.TabIndex = 45;
            this.textBoxPass.Text = "Password";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonCancelar.FlatAppearance.BorderSize = 3;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.ForeColor = System.Drawing.Color.Red;
            this.buttonCancelar.Location = new System.Drawing.Point(137, 134);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(113, 38);
            this.buttonCancelar.TabIndex = 44;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonRegistar
            // 
            this.buttonRegistar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonRegistar.FlatAppearance.BorderSize = 3;
            this.buttonRegistar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistar.ForeColor = System.Drawing.Color.Red;
            this.buttonRegistar.Location = new System.Drawing.Point(18, 134);
            this.buttonRegistar.Name = "buttonRegistar";
            this.buttonRegistar.Size = new System.Drawing.Size(113, 38);
            this.buttonRegistar.TabIndex = 43;
            this.buttonRegistar.Text = "Registar";
            this.buttonRegistar.UseVisualStyleBackColor = true;
            this.buttonRegistar.Click += new System.EventHandler(this.buttonRegistar_Click);
            // 
            // linkLabelMostrar
            // 
            this.linkLabelMostrar.AutoSize = true;
            this.linkLabelMostrar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelMostrar.Location = new System.Drawing.Point(161, 63);
            this.linkLabelMostrar.Name = "linkLabelMostrar";
            this.linkLabelMostrar.Size = new System.Drawing.Size(0, 15);
            this.linkLabelMostrar.TabIndex = 42;
            // 
            // textBoxUser
            // 
            this.textBoxUser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxUser.Location = new System.Drawing.Point(18, 26);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(137, 23);
            this.textBoxUser.TabIndex = 41;
            this.textBoxUser.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(273, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxRepPasse
            // 
            this.textBoxRepPasse.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxRepPasse.Location = new System.Drawing.Point(18, 84);
            this.textBoxRepPasse.Name = "textBoxRepPasse";
            this.textBoxRepPasse.Size = new System.Drawing.Size(137, 23);
            this.textBoxRepPasse.TabIndex = 47;
            this.textBoxRepPasse.Text = "Repetir Password";
            // 
            // FormNomeUtilizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 184);
            this.Controls.Add(this.textBoxRepPasse);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonRegistar);
            this.Controls.Add(this.linkLabelMostrar);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormNomeUtilizador";
            this.Text = "FormNomeUtilizador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxPass;
        private Button buttonCancelar;
        private Button buttonRegistar;
        private LinkLabel linkLabelMostrar;
        private TextBox textBoxUser;
        private PictureBox pictureBox1;
        private TextBox textBoxRepPasse;
    }
}