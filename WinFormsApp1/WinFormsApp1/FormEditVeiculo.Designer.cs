namespace WinFormsApp1
{
    partial class FormEditVeiculo
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
            this.textBoxCustoMinuto = new System.Windows.Forms.TextBox();
            this.labelDesignacaoVeiculo = new System.Windows.Forms.Label();
            this.buttonSubmeter = new System.Windows.Forms.Button();
            this.textBoxKilometros = new System.Windows.Forms.TextBox();
            this.textBoxCustoReserva = new System.Windows.Forms.TextBox();
            this.comboBoxEstadoVeiculo = new System.Windows.Forms.ComboBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelCustoMinuto = new System.Windows.Forms.Label();
            this.labelCustoReserva = new System.Windows.Forms.Label();
            this.labelKilometros = new System.Windows.Forms.Label();
            this.labelEstadoVeiculo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(51, 98);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(175, 27);
            this.textBoxModelo.TabIndex = 0;
            this.textBoxModelo.TextChanged += new System.EventHandler(this.TextBoxModelo_TextChanged);
            // 
            // textBoxCustoMinuto
            // 
            this.textBoxCustoMinuto.Location = new System.Drawing.Point(51, 164);
            this.textBoxCustoMinuto.Name = "textBoxCustoMinuto";
            this.textBoxCustoMinuto.Size = new System.Drawing.Size(175, 27);
            this.textBoxCustoMinuto.TabIndex = 1;
            this.textBoxCustoMinuto.TextChanged += new System.EventHandler(this.TextBoxCustoMinuto_TextChanged);
            this.textBoxCustoMinuto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCustoMinuto_KeyPress);
            // 
            // labelDesignacaoVeiculo
            // 
            this.labelDesignacaoVeiculo.AutoSize = true;
            this.labelDesignacaoVeiculo.Location = new System.Drawing.Point(110, 34);
            this.labelDesignacaoVeiculo.Name = "labelDesignacaoVeiculo";
            this.labelDesignacaoVeiculo.Size = new System.Drawing.Size(50, 20);
            this.labelDesignacaoVeiculo.TabIndex = 2;
            this.labelDesignacaoVeiculo.Text = "label1";
            // 
            // buttonSubmeter
            // 
            this.buttonSubmeter.Location = new System.Drawing.Point(356, 306);
            this.buttonSubmeter.Name = "buttonSubmeter";
            this.buttonSubmeter.Size = new System.Drawing.Size(94, 29);
            this.buttonSubmeter.TabIndex = 3;
            this.buttonSubmeter.Text = "Submeter";
            this.buttonSubmeter.UseVisualStyleBackColor = true;
            this.buttonSubmeter.Click += new System.EventHandler(this.ButtonSubmeter_Click);
            // 
            // textBoxKilometros
            // 
            this.textBoxKilometros.Location = new System.Drawing.Point(275, 98);
            this.textBoxKilometros.Name = "textBoxKilometros";
            this.textBoxKilometros.Size = new System.Drawing.Size(175, 27);
            this.textBoxKilometros.TabIndex = 4;
            this.textBoxKilometros.TextChanged += new System.EventHandler(this.TextBoxKilometros_TextChanged);
            this.textBoxKilometros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKilometros_KeyPress);
            // 
            // textBoxCustoReserva
            // 
            this.textBoxCustoReserva.Location = new System.Drawing.Point(51, 231);
            this.textBoxCustoReserva.Name = "textBoxCustoReserva";
            this.textBoxCustoReserva.Size = new System.Drawing.Size(175, 27);
            this.textBoxCustoReserva.TabIndex = 5;
            this.textBoxCustoReserva.TextChanged += new System.EventHandler(this.TextBoxCustoReserva_TextChanged);
            this.textBoxCustoReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCustoReserva_KeyPress);
            // 
            // comboBoxEstadoVeiculo
            // 
            this.comboBoxEstadoVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstadoVeiculo.FormattingEnabled = true;
            this.comboBoxEstadoVeiculo.Location = new System.Drawing.Point(275, 164);
            this.comboBoxEstadoVeiculo.Name = "comboBoxEstadoVeiculo";
            this.comboBoxEstadoVeiculo.Size = new System.Drawing.Size(175, 28);
            this.comboBoxEstadoVeiculo.TabIndex = 6;
            this.comboBoxEstadoVeiculo.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEstadoVeiculo_SelectedIndexChanged);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(256, 306);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(94, 29);
            this.buttonEliminar.TabIndex = 8;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(51, 306);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(51, 75);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(61, 20);
            this.labelModelo.TabIndex = 10;
            this.labelModelo.Text = "Modelo";
            // 
            // labelCustoMinuto
            // 
            this.labelCustoMinuto.AutoSize = true;
            this.labelCustoMinuto.Location = new System.Drawing.Point(51, 141);
            this.labelCustoMinuto.Name = "labelCustoMinuto";
            this.labelCustoMinuto.Size = new System.Drawing.Size(99, 20);
            this.labelCustoMinuto.TabIndex = 11;
            this.labelCustoMinuto.Text = "Custo/Minuto";
            // 
            // labelCustoReserva
            // 
            this.labelCustoReserva.AutoSize = true;
            this.labelCustoReserva.Location = new System.Drawing.Point(51, 208);
            this.labelCustoReserva.Name = "labelCustoReserva";
            this.labelCustoReserva.Size = new System.Drawing.Size(103, 20);
            this.labelCustoReserva.TabIndex = 12;
            this.labelCustoReserva.Text = "Custo/Reserva";
            // 
            // labelKilometros
            // 
            this.labelKilometros.AutoSize = true;
            this.labelKilometros.Location = new System.Drawing.Point(275, 75);
            this.labelKilometros.Name = "labelKilometros";
            this.labelKilometros.Size = new System.Drawing.Size(81, 20);
            this.labelKilometros.TabIndex = 13;
            this.labelKilometros.Text = "Kilometros";
            // 
            // labelEstadoVeiculo
            // 
            this.labelEstadoVeiculo.AutoSize = true;
            this.labelEstadoVeiculo.Location = new System.Drawing.Point(275, 141);
            this.labelEstadoVeiculo.Name = "labelEstadoVeiculo";
            this.labelEstadoVeiculo.Size = new System.Drawing.Size(128, 20);
            this.labelEstadoVeiculo.TabIndex = 14;
            this.labelEstadoVeiculo.Text = "Estado do Veiculo";
            // 
            // FormEditVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 375);
            this.Controls.Add(this.labelEstadoVeiculo);
            this.Controls.Add(this.labelKilometros);
            this.Controls.Add(this.labelCustoReserva);
            this.Controls.Add(this.labelCustoMinuto);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.comboBoxEstadoVeiculo);
            this.Controls.Add(this.textBoxCustoReserva);
            this.Controls.Add(this.textBoxKilometros);
            this.Controls.Add(this.buttonSubmeter);
            this.Controls.Add(this.labelDesignacaoVeiculo);
            this.Controls.Add(this.textBoxCustoMinuto);
            this.Controls.Add(this.textBoxModelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEditVeiculo";
            this.Load += new System.EventHandler(this.FormEditVeiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxModelo;
        private TextBox textBoxCustoMinuto;
        private Label labelDesignacaoVeiculo;
        private Button buttonSubmeter;
        private TextBox textBoxKilometros;
        private TextBox textBoxCustoReserva;
        private ComboBox comboBoxEstadoVeiculo;
        private Button buttonEliminar;
        private Button buttonCancelar;
        private Label labelModelo;
        private Label labelCustoMinuto;
        private Label labelCustoReserva;
        private Label labelKilometros;
        private Label labelEstadoVeiculo;
    }
}