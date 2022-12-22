namespace WinFormsApp1
{
    partial class FormAddVeiculo
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
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelCamposObrigatorios = new System.Windows.Forms.Label();
            this.textBoxCustoMinuto = new System.Windows.Forms.TextBox();
            this.labelCustoMinuto = new System.Windows.Forms.Label();
            this.labelCustoReserva = new System.Windows.Forms.Label();
            this.labelKilometros = new System.Windows.Forms.Label();
            this.textBoxCustoReserva = new System.Windows.Forms.TextBox();
            this.textBoxKilometros = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.comboBoxTiposVeiculos = new System.Windows.Forms.ComboBox();
            this.labelTipoVeiculo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(175, 95);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(224, 27);
            this.textBoxModelo.TabIndex = 0;
            this.textBoxModelo.TextChanged += new System.EventHandler(this.TextBoxModelo_TextChanged);
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelModelo.Location = new System.Drawing.Point(38, 96);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(80, 23);
            this.labelModelo.TabIndex = 1;
            this.labelModelo.Text = "Modelo *";
            // 
            // labelCamposObrigatorios
            // 
            this.labelCamposObrigatorios.AutoSize = true;
            this.labelCamposObrigatorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCamposObrigatorios.Location = new System.Drawing.Point(38, 330);
            this.labelCamposObrigatorios.Name = "labelCamposObrigatorios";
            this.labelCamposObrigatorios.Size = new System.Drawing.Size(187, 20);
            this.labelCamposObrigatorios.TabIndex = 2;
            this.labelCamposObrigatorios.Text = "* --> Campos Obrigatórios";
            // 
            // textBoxCustoMinuto
            // 
            this.textBoxCustoMinuto.Location = new System.Drawing.Point(175, 155);
            this.textBoxCustoMinuto.Name = "textBoxCustoMinuto";
            this.textBoxCustoMinuto.Size = new System.Drawing.Size(224, 27);
            this.textBoxCustoMinuto.TabIndex = 3;
            this.textBoxCustoMinuto.TextChanged += new System.EventHandler(this.TextBoxCustoMinuto_TextChanged);
            this.textBoxCustoMinuto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCustoMinuto_KeyPress);
            // 
            // labelCustoMinuto
            // 
            this.labelCustoMinuto.AutoSize = true;
            this.labelCustoMinuto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCustoMinuto.Location = new System.Drawing.Point(38, 156);
            this.labelCustoMinuto.Name = "labelCustoMinuto";
            this.labelCustoMinuto.Size = new System.Drawing.Size(128, 23);
            this.labelCustoMinuto.TabIndex = 4;
            this.labelCustoMinuto.Text = "Custo/Minuto *";
            // 
            // labelCustoReserva
            // 
            this.labelCustoReserva.AutoSize = true;
            this.labelCustoReserva.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCustoReserva.Location = new System.Drawing.Point(38, 216);
            this.labelCustoReserva.Name = "labelCustoReserva";
            this.labelCustoReserva.Size = new System.Drawing.Size(131, 23);
            this.labelCustoReserva.TabIndex = 5;
            this.labelCustoReserva.Text = "Custo/Reserva *";
            // 
            // labelKilometros
            // 
            this.labelKilometros.AutoSize = true;
            this.labelKilometros.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKilometros.Location = new System.Drawing.Point(38, 276);
            this.labelKilometros.Name = "labelKilometros";
            this.labelKilometros.Size = new System.Drawing.Size(91, 23);
            this.labelKilometros.TabIndex = 6;
            this.labelKilometros.Text = "Kilometros";
            // 
            // textBoxCustoReserva
            // 
            this.textBoxCustoReserva.Location = new System.Drawing.Point(175, 215);
            this.textBoxCustoReserva.Name = "textBoxCustoReserva";
            this.textBoxCustoReserva.Size = new System.Drawing.Size(224, 27);
            this.textBoxCustoReserva.TabIndex = 7;
            this.textBoxCustoReserva.TextChanged += new System.EventHandler(this.TextBoxCustoReserva_TextChanged);
            this.textBoxCustoReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCustoReserva_KeyPress);
            // 
            // textBoxKilometros
            // 
            this.textBoxKilometros.Location = new System.Drawing.Point(175, 275);
            this.textBoxKilometros.Name = "textBoxKilometros";
            this.textBoxKilometros.Size = new System.Drawing.Size(224, 27);
            this.textBoxKilometros.TabIndex = 8;
            this.textBoxKilometros.TextChanged += new System.EventHandler(this.TextBoxKilometros_TextChanged);
            this.textBoxKilometros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKilometros_KeyPress);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(72, 380);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(269, 380);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(94, 29);
            this.buttonAdicionar.TabIndex = 10;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.ButtonAdicionar_Click);
            // 
            // comboBoxTiposVeiculos
            // 
            this.comboBoxTiposVeiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTiposVeiculos.FormattingEnabled = true;
            this.comboBoxTiposVeiculos.Location = new System.Drawing.Point(175, 35);
            this.comboBoxTiposVeiculos.Name = "comboBoxTiposVeiculos";
            this.comboBoxTiposVeiculos.Size = new System.Drawing.Size(224, 28);
            this.comboBoxTiposVeiculos.TabIndex = 11;
            this.comboBoxTiposVeiculos.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTiposVeiculos_SelectedIndexChanged);
            // 
            // labelTipoVeiculo
            // 
            this.labelTipoVeiculo.AutoSize = true;
            this.labelTipoVeiculo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTipoVeiculo.Location = new System.Drawing.Point(38, 36);
            this.labelTipoVeiculo.Name = "labelTipoVeiculo";
            this.labelTipoVeiculo.Size = new System.Drawing.Size(115, 23);
            this.labelTipoVeiculo.TabIndex = 12;
            this.labelTipoVeiculo.Text = "Tipo Veiculo *";
            // 
            // FormAddVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 444);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.labelTipoVeiculo);
            this.Controls.Add(this.comboBoxTiposVeiculos);
            this.Controls.Add(this.textBoxKilometros);
            this.Controls.Add(this.textBoxCustoReserva);
            this.Controls.Add(this.labelKilometros);
            this.Controls.Add(this.labelCustoReserva);
            this.Controls.Add(this.labelCustoMinuto);
            this.Controls.Add(this.textBoxCustoMinuto);
            this.Controls.Add(this.labelCamposObrigatorios);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.textBoxModelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddVeiculo";
            this.Load += new System.EventHandler(this.FormAddVeiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxModelo;
        private Label labelModelo;
        private Label labelCamposObrigatorios;
        private TextBox textBoxCustoMinuto;
        private Label labelCustoMinuto;
        private Label labelCustoReserva;
        private Label labelKilometros;
        private TextBox textBoxCustoReserva;
        private TextBox textBoxKilometros;
        private Button buttonCancelar;
        private Button buttonAdicionar;
        private ComboBox comboBoxTiposVeiculos;
        private Label labelTipoVeiculo;
    }
}