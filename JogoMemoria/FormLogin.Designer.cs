namespace JogoMemoria
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.linkLabelMostrar = new System.Windows.Forms.LinkLabel();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxPasse = new System.Windows.Forms.TextBox();
            this.linkLabelNovoUtil = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(406, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxUser
            // 
            this.textBoxUser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxUser.Location = new System.Drawing.Point(69, 47);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(137, 23);
            this.textBoxUser.TabIndex = 34;
            this.textBoxUser.Text = "Username";
            // 
            // linkLabelMostrar
            // 
            this.linkLabelMostrar.AutoSize = true;
            this.linkLabelMostrar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelMostrar.Location = new System.Drawing.Point(212, 84);
            this.linkLabelMostrar.Name = "linkLabelMostrar";
            this.linkLabelMostrar.Size = new System.Drawing.Size(48, 15);
            this.linkLabelMostrar.TabIndex = 38;
            this.linkLabelMostrar.TabStop = true;
            this.linkLabelMostrar.Text = "Mostrar";
            this.linkLabelMostrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMostrar_LinkClicked);
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonEntrar.FlatAppearance.BorderSize = 3;
            this.buttonEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntrar.ForeColor = System.Drawing.Color.Red;
            this.buttonEntrar.Location = new System.Drawing.Point(69, 148);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(143, 31);
            this.buttonEntrar.TabIndex = 36;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonCancelar.FlatAppearance.BorderSize = 3;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.ForeColor = System.Drawing.Color.Red;
            this.buttonCancelar.Location = new System.Drawing.Point(235, 148);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(143, 31);
            this.buttonCancelar.TabIndex = 37;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxPasse
            // 
            this.textBoxPasse.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPasse.Location = new System.Drawing.Point(69, 76);
            this.textBoxPasse.Name = "textBoxPasse";
            this.textBoxPasse.Size = new System.Drawing.Size(137, 23);
            this.textBoxPasse.TabIndex = 35;
            this.textBoxPasse.Text = "Username";
            this.textBoxPasse.UseSystemPasswordChar = true;
            // 
            // linkLabelNovoUtil
            // 
            this.linkLabelNovoUtil.AutoSize = true;
            this.linkLabelNovoUtil.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelNovoUtil.Location = new System.Drawing.Point(69, 102);
            this.linkLabelNovoUtil.Name = "linkLabelNovoUtil";
            this.linkLabelNovoUtil.Size = new System.Drawing.Size(114, 15);
            this.linkLabelNovoUtil.TabIndex = 39;
            this.linkLabelNovoUtil.TabStop = true;
            this.linkLabelNovoUtil.Text = "Criar novo utilizador";
            this.linkLabelNovoUtil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelNovoUtil_LinkClicked);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 212);
            this.Controls.Add(this.linkLabelNovoUtil);
            this.Controls.Add(this.textBoxPasse);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.linkLabelMostrar);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBoxUser;
        private LinkLabel linkLabelMostrar;
        private Button buttonEntrar;
        private Button buttonCancelar;
        private TextBox textBoxPasse;
        private LinkLabel linkLabelNovoUtil;
    }
}