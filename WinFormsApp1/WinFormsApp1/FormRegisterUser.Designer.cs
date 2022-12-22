namespace WinFormsApp1
{
    partial class FormRegisterUser
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
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelMorada = new System.Windows.Forms.Label();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.labelNTelemovel = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNTelemovel = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxMorada = new System.Windows.Forms.TextBox();
            this.labelCamposObrigatorios = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonRegistar = new System.Windows.Forms.Button();
            this.dateTimePickerDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.labelIdade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(44, 37);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(63, 23);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "Email *";
            // 
            // labelMorada
            // 
            this.labelMorada.AutoSize = true;
            this.labelMorada.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMorada.Location = new System.Drawing.Point(44, 222);
            this.labelMorada.Name = "labelMorada";
            this.labelMorada.Size = new System.Drawing.Size(81, 23);
            this.labelMorada.TabIndex = 14;
            this.labelMorada.Text = "Morada *";
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataNascimento.Location = new System.Drawing.Point(44, 273);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(149, 23);
            this.labelDataNascimento.TabIndex = 15;
            this.labelDataNascimento.Text = "Data Nascimento*";
            // 
            // labelNTelemovel
            // 
            this.labelNTelemovel.AutoSize = true;
            this.labelNTelemovel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNTelemovel.Location = new System.Drawing.Point(44, 173);
            this.labelNTelemovel.Name = "labelNTelemovel";
            this.labelNTelemovel.Size = new System.Drawing.Size(121, 23);
            this.labelNTelemovel.TabIndex = 16;
            this.labelNTelemovel.Text = "Nº telemovel *";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(44, 125);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(92, 23);
            this.labelPassword.TabIndex = 17;
            this.labelPassword.Text = "Password *";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNome.Location = new System.Drawing.Point(44, 80);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(69, 23);
            this.labelNome.TabIndex = 18;
            this.labelNome.Text = "Nome *";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(199, 36);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(224, 27);
            this.textBoxEmail.TabIndex = 19;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.TextBoxEmail_TextChanged);
            // 
            // textBoxNTelemovel
            // 
            this.textBoxNTelemovel.Location = new System.Drawing.Point(199, 172);
            this.textBoxNTelemovel.MaxLength = 9;
            this.textBoxNTelemovel.Name = "textBoxNTelemovel";
            this.textBoxNTelemovel.Size = new System.Drawing.Size(224, 27);
            this.textBoxNTelemovel.TabIndex = 21;
            this.textBoxNTelemovel.TextChanged += new System.EventHandler(this.TextBoxNTelemovel_TextChanged);
            this.textBoxNTelemovel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNTelemovel_KeyPress);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(199, 79);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(224, 27);
            this.textBoxNome.TabIndex = 22;
            this.textBoxNome.TextChanged += new System.EventHandler(this.TextBoxNome_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(199, 124);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(224, 27);
            this.textBoxPassword.TabIndex = 23;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            // 
            // textBoxMorada
            // 
            this.textBoxMorada.Location = new System.Drawing.Point(199, 221);
            this.textBoxMorada.Name = "textBoxMorada";
            this.textBoxMorada.Size = new System.Drawing.Size(224, 27);
            this.textBoxMorada.TabIndex = 24;
            this.textBoxMorada.TextChanged += new System.EventHandler(this.TextBoxMorada_TextChanged);
            // 
            // labelCamposObrigatorios
            // 
            this.labelCamposObrigatorios.AutoSize = true;
            this.labelCamposObrigatorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCamposObrigatorios.Location = new System.Drawing.Point(44, 335);
            this.labelCamposObrigatorios.Name = "labelCamposObrigatorios";
            this.labelCamposObrigatorios.Size = new System.Drawing.Size(187, 20);
            this.labelCamposObrigatorios.TabIndex = 25;
            this.labelCamposObrigatorios.Text = "* --> Campos Obrigatórios";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(58, 389);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 26;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // buttonRegistar
            // 
            this.buttonRegistar.Location = new System.Drawing.Point(311, 389);
            this.buttonRegistar.Name = "buttonRegistar";
            this.buttonRegistar.Size = new System.Drawing.Size(94, 29);
            this.buttonRegistar.TabIndex = 27;
            this.buttonRegistar.Text = "Registar";
            this.buttonRegistar.UseVisualStyleBackColor = true;
            this.buttonRegistar.Click += new System.EventHandler(this.ButtonRegistar_Click);
            // 
            // dateTimePickerDataNascimento
            // 
            this.dateTimePickerDataNascimento.Location = new System.Drawing.Point(199, 270);
            this.dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            this.dateTimePickerDataNascimento.Size = new System.Drawing.Size(224, 27);
            this.dateTimePickerDataNascimento.TabIndex = 28;
            this.dateTimePickerDataNascimento.ValueChanged += new System.EventHandler(this.DateTimePickerDataNascimento_ValueChanged);
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIdade.ForeColor = System.Drawing.Color.Blue;
            this.labelIdade.Location = new System.Drawing.Point(44, 300);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(291, 15);
            this.labelIdade.TabIndex = 29;
            this.labelIdade.Text = "Precisa de possuir pelo menos 18 anos para se registar";
            // 
            // FormRegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 456);
            this.Controls.Add(this.labelIdade);
            this.Controls.Add(this.dateTimePickerDataNascimento);
            this.Controls.Add(this.buttonRegistar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelCamposObrigatorios);
            this.Controls.Add(this.textBoxMorada);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxNTelemovel);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelNTelemovel);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.labelMorada);
            this.Controls.Add(this.labelEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegisterUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormRegisterUser";
            this.Load += new System.EventHandler(this.FormRegisterUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelEmail;
        private Label labelMorada;
        private Label labelDataNascimento;
        private Label labelNTelemovel;
        private Label labelPassword;
        private Label labelNome;
        private TextBox textBoxEmail;
        private TextBox textBoxNTelemovel;
        private TextBox textBoxNome;
        private TextBox textBoxPassword;
        private TextBox textBoxMorada;
        private Label labelCamposObrigatorios;
        private Button buttonCancelar;
        private Button buttonRegistar;
        private DateTimePicker dateTimePickerDataNascimento;
        private Label labelIdade;
    }
}