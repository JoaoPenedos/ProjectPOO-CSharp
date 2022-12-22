namespace WinFormsApp1
{
    partial class FormCarregarSaldo
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
            this.labelMontantACarregar = new System.Windows.Forms.Label();
            this.textBoxSaldo = new System.Windows.Forms.TextBox();
            this.buttonCarregar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMontantACarregar
            // 
            this.labelMontantACarregar.AutoSize = true;
            this.labelMontantACarregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMontantACarregar.Location = new System.Drawing.Point(45, 37);
            this.labelMontantACarregar.Name = "labelMontantACarregar";
            this.labelMontantACarregar.Size = new System.Drawing.Size(257, 28);
            this.labelMontantACarregar.TabIndex = 0;
            this.labelMontantACarregar.Text = "Insira o montante a carregar";
            // 
            // textBoxSaldo
            // 
            this.textBoxSaldo.Location = new System.Drawing.Point(45, 80);
            this.textBoxSaldo.MaxLength = 5;
            this.textBoxSaldo.Name = "textBoxSaldo";
            this.textBoxSaldo.Size = new System.Drawing.Size(287, 27);
            this.textBoxSaldo.TabIndex = 1;
            this.textBoxSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSaldo_KeyPress);
            // 
            // buttonCarregar
            // 
            this.buttonCarregar.Location = new System.Drawing.Point(238, 146);
            this.buttonCarregar.Name = "buttonCarregar";
            this.buttonCarregar.Size = new System.Drawing.Size(94, 29);
            this.buttonCarregar.TabIndex = 2;
            this.buttonCarregar.Text = "Carregar";
            this.buttonCarregar.UseVisualStyleBackColor = true;
            this.buttonCarregar.Click += new System.EventHandler(this.ButtonCarregar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(45, 146);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // FormCarregarSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 212);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonCarregar);
            this.Controls.Add(this.textBoxSaldo);
            this.Controls.Add(this.labelMontantACarregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCarregarSaldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCarregarSaldo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelMontantACarregar;
        private TextBox textBoxSaldo;
        private Button buttonCarregar;
        private Button buttonCancelar;
    }
}