namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDasboard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuReservar = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBoxBicicleta = new System.Windows.Forms.PictureBox();
            this.pictureBoxTrotinete = new System.Windows.Forms.PictureBox();
            this.checkBoxBicicleta = new System.Windows.Forms.CheckBox();
            this.checkBoxTrotinete = new System.Windows.Forms.CheckBox();
            this.comboBoxPosto = new System.Windows.Forms.ComboBox();
            this.dateTimePickerReservaTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReservaDate = new System.Windows.Forms.DateTimePicker();
            this.buttonProcurarReserva = new System.Windows.Forms.Button();
            this.dataGridViewReserva = new System.Windows.Forms.DataGridView();
            this.ButtonReserva = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBicicleta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrotinete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuLogin,
            this.toolStripMenuLogout,
            this.toolStripMenuDasboard,
            this.toolStripMenuReservar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1108, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuLogin
            // 
            this.toolStripMenuLogin.Name = "toolStripMenuLogin";
            this.toolStripMenuLogin.Size = new System.Drawing.Size(60, 24);
            this.toolStripMenuLogin.Text = "Login";
            this.toolStripMenuLogin.Click += new System.EventHandler(this.ToolStripMenuLogin_Click);
            // 
            // toolStripMenuLogout
            // 
            this.toolStripMenuLogout.Name = "toolStripMenuLogout";
            this.toolStripMenuLogout.Size = new System.Drawing.Size(70, 24);
            this.toolStripMenuLogout.Text = "Logout";
            this.toolStripMenuLogout.Click += new System.EventHandler(this.ToolStripMenuLogout_Click);
            // 
            // toolStripMenuDasboard
            // 
            this.toolStripMenuDasboard.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuDasboard.Name = "toolStripMenuDasboard";
            this.toolStripMenuDasboard.Size = new System.Drawing.Size(96, 24);
            this.toolStripMenuDasboard.Text = "Dashboard";
            this.toolStripMenuDasboard.Click += new System.EventHandler(this.ToolStripMenuDashboard_Click);
            // 
            // toolStripMenuReservar
            // 
            this.toolStripMenuReservar.Name = "toolStripMenuReservar";
            this.toolStripMenuReservar.Size = new System.Drawing.Size(79, 24);
            this.toolStripMenuReservar.Text = "Reservar";
            this.toolStripMenuReservar.Click += new System.EventHandler(this.ToolStripMenuReservar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 526);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1108, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // pictureBoxBicicleta
            // 
            this.pictureBoxBicicleta.Image = global::WinFormsApp1.Properties.Resources._2533224;
            this.pictureBoxBicicleta.Location = new System.Drawing.Point(20, 60);
            this.pictureBoxBicicleta.Name = "pictureBoxBicicleta";
            this.pictureBoxBicicleta.Size = new System.Drawing.Size(120, 118);
            this.pictureBoxBicicleta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBicicleta.TabIndex = 5;
            this.pictureBoxBicicleta.TabStop = false;
            // 
            // pictureBoxTrotinete
            // 
            this.pictureBoxTrotinete.Image = global::WinFormsApp1.Properties.Resources.istockphoto_1318443231_612x612_removebg_preview;
            this.pictureBoxTrotinete.Location = new System.Drawing.Point(169, 60);
            this.pictureBoxTrotinete.Name = "pictureBoxTrotinete";
            this.pictureBoxTrotinete.Size = new System.Drawing.Size(120, 118);
            this.pictureBoxTrotinete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTrotinete.TabIndex = 6;
            this.pictureBoxTrotinete.TabStop = false;
            // 
            // checkBoxBicicleta
            // 
            this.checkBoxBicicleta.AutoSize = true;
            this.checkBoxBicicleta.Location = new System.Drawing.Point(36, 184);
            this.checkBoxBicicleta.Name = "checkBoxBicicleta";
            this.checkBoxBicicleta.Size = new System.Drawing.Size(87, 24);
            this.checkBoxBicicleta.TabIndex = 7;
            this.checkBoxBicicleta.Text = "Bicicleta";
            this.checkBoxBicicleta.UseVisualStyleBackColor = true;
            // 
            // checkBoxTrotinete
            // 
            this.checkBoxTrotinete.AutoSize = true;
            this.checkBoxTrotinete.Location = new System.Drawing.Point(184, 184);
            this.checkBoxTrotinete.Name = "checkBoxTrotinete";
            this.checkBoxTrotinete.Size = new System.Drawing.Size(90, 24);
            this.checkBoxTrotinete.TabIndex = 8;
            this.checkBoxTrotinete.Text = "Trotinete";
            this.checkBoxTrotinete.UseVisualStyleBackColor = true;
            // 
            // comboBoxPosto
            // 
            this.comboBoxPosto.FormattingEnabled = true;
            this.comboBoxPosto.Location = new System.Drawing.Point(20, 243);
            this.comboBoxPosto.Name = "comboBoxPosto";
            this.comboBoxPosto.Size = new System.Drawing.Size(269, 28);
            this.comboBoxPosto.TabIndex = 9;
            this.comboBoxPosto.Text = "--Escolha o Posto --";
            // 
            // dateTimePickerReservaTime
            // 
            this.dateTimePickerReservaTime.CustomFormat = "";
            this.dateTimePickerReservaTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerReservaTime.Location = new System.Drawing.Point(20, 345);
            this.dateTimePickerReservaTime.Name = "dateTimePickerReservaTime";
            this.dateTimePickerReservaTime.ShowUpDown = true;
            this.dateTimePickerReservaTime.Size = new System.Drawing.Size(269, 27);
            this.dateTimePickerReservaTime.TabIndex = 10;
            // 
            // dateTimePickerReservaDate
            // 
            this.dateTimePickerReservaDate.Location = new System.Drawing.Point(20, 294);
            this.dateTimePickerReservaDate.Name = "dateTimePickerReservaDate";
            this.dateTimePickerReservaDate.Size = new System.Drawing.Size(269, 27);
            this.dateTimePickerReservaDate.TabIndex = 11;
            // 
            // buttonProcurarReserva
            // 
            this.buttonProcurarReserva.Location = new System.Drawing.Point(103, 404);
            this.buttonProcurarReserva.Name = "buttonProcurarReserva";
            this.buttonProcurarReserva.Size = new System.Drawing.Size(94, 29);
            this.buttonProcurarReserva.TabIndex = 12;
            this.buttonProcurarReserva.Text = "Procurar";
            this.buttonProcurarReserva.UseVisualStyleBackColor = true;
            this.buttonProcurarReserva.Click += new System.EventHandler(this.ButtonProcurarReserva_Click);
            // 
            // dataGridViewReserva
            // 
            this.dataGridViewReserva.AllowUserToAddRows = false;
            this.dataGridViewReserva.AllowUserToDeleteRows = false;
            this.dataGridViewReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ButtonReserva});
            this.dataGridViewReserva.Location = new System.Drawing.Point(310, 60);
            this.dataGridViewReserva.Name = "dataGridViewReserva";
            this.dataGridViewReserva.ReadOnly = true;
            this.dataGridViewReserva.RowHeadersWidth = 50;
            this.dataGridViewReserva.RowTemplate.Height = 28;
            this.dataGridViewReserva.Size = new System.Drawing.Size(348, 238);
            this.dataGridViewReserva.TabIndex = 12;
            this.dataGridViewReserva.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSoftware_CellClick);
            // 
            // ButtonReserva
            // 
            this.ButtonReserva.HeaderText = "Reservar";
            this.ButtonReserva.MinimumWidth = 6;
            this.ButtonReserva.Name = "ButtonReserva";
            this.ButtonReserva.ReadOnly = true;
            this.ButtonReserva.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ButtonReserva.Text = "Reservar";
            this.ButtonReserva.UseColumnTextForButtonValue = true;
            this.ButtonReserva.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1108, 552);
            this.Controls.Add(this.dataGridViewReserva);
            this.Controls.Add(this.buttonProcurarReserva);
            this.Controls.Add(this.dateTimePickerReservaDate);
            this.Controls.Add(this.dateTimePickerReservaTime);
            this.Controls.Add(this.comboBoxPosto);
            this.Controls.Add(this.checkBoxTrotinete);
            this.Controls.Add(this.checkBoxBicicleta);
            this.Controls.Add(this.pictureBoxTrotinete);
            this.Controls.Add(this.pictureBoxBicicleta);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBicicleta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrotinete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuDasboard;
        private ToolStripMenuItem toolStripMenuReservar;
        private ToolStripMenuItem toolStripMenuLogin;
        private ToolStripMenuItem toolStripMenuLogout;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private PictureBox pictureBoxBicicleta;
        private PictureBox pictureBoxTrotinete;
        private CheckBox checkBoxBicicleta;
        private CheckBox checkBoxTrotinete;
        private ComboBox comboBoxPosto;
        private DateTimePicker dateTimePickerReservaTime;
        private DateTimePicker dateTimePickerReservaDate;
        private Button buttonProcurarReserva;
        private DataGridView dataGridViewReserva;
        private DataGridViewButtonColumn ButtonReserva;
    }
}