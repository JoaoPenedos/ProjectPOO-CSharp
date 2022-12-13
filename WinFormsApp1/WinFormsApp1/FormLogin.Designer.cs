namespace WinFormsApp1
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
            this.labelUtilizador = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUtilizador = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonLoginOk = new System.Windows.Forms.Button();
            this.buttonLoginCancelar = new System.Windows.Forms.Button();
            this.buttonLoginShowPass = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUtilizador
            // 
            this.labelUtilizador.AutoSize = true;
            this.labelUtilizador.Location = new System.Drawing.Point(35, 27);
            this.labelUtilizador.Name = "labelUtilizador";
            this.labelUtilizador.Size = new System.Drawing.Size(74, 20);
            this.labelUtilizador.TabIndex = 0;
            this.labelUtilizador.Text = "Utilizador";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(35, 76);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(70, 20);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // textBoxUtilizador
            // 
            this.textBoxUtilizador.Location = new System.Drawing.Point(131, 24);
            this.textBoxUtilizador.Name = "textBoxUtilizador";
            this.textBoxUtilizador.Size = new System.Drawing.Size(238, 27);
            this.textBoxUtilizador.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(131, 73);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(183, 27);
            this.textBoxPassword.TabIndex = 3;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelLogin.Controls.Add(this.buttonLoginOk);
            this.panelLogin.Controls.Add(this.buttonLoginCancelar);
            this.panelLogin.Location = new System.Drawing.Point(-7, 136);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(414, 75);
            this.panelLogin.TabIndex = 4;
            // 
            // buttonLoginOk
            // 
            this.buttonLoginOk.Location = new System.Drawing.Point(256, 14);
            this.buttonLoginOk.Name = "buttonLoginOk";
            this.buttonLoginOk.Size = new System.Drawing.Size(94, 29);
            this.buttonLoginOk.TabIndex = 6;
            this.buttonLoginOk.Text = "Ok";
            this.buttonLoginOk.UseVisualStyleBackColor = true;
            this.buttonLoginOk.Click += new System.EventHandler(this.ButtonLoginOk_Click);
            // 
            // buttonLoginCancelar
            // 
            this.buttonLoginCancelar.Location = new System.Drawing.Point(63, 14);
            this.buttonLoginCancelar.Name = "buttonLoginCancelar";
            this.buttonLoginCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonLoginCancelar.TabIndex = 5;
            this.buttonLoginCancelar.Text = "Cancelar";
            this.buttonLoginCancelar.UseVisualStyleBackColor = true;
            this.buttonLoginCancelar.Click += new System.EventHandler(this.ButtonLoginCancelar_Click);
            // 
            // buttonLoginShowPass
            // 
            this.buttonLoginShowPass.BackgroundImage = global::WinFormsApp1.Properties.Resources.EyeIcon;
            this.buttonLoginShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLoginShowPass.Location = new System.Drawing.Point(334, 69);
            this.buttonLoginShowPass.Name = "buttonLoginShowPass";
            this.buttonLoginShowPass.Size = new System.Drawing.Size(35, 35);
            this.buttonLoginShowPass.TabIndex = 7;
            this.buttonLoginShowPass.UseVisualStyleBackColor = true;
            this.buttonLoginShowPass.Click += new System.EventHandler(this.ButtonLoginShowPass_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.buttonLoginShowPass);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUtilizador);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUtilizador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelLogin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelUtilizador;
        private Label labelPassword;
        private TextBox textBoxUtilizador;
        private TextBox textBoxPassword;
        private Panel panelLogin;
        private Button buttonLoginOk;
        private Button buttonLoginCancelar;
        private Button buttonLoginShowPass;
    }
}