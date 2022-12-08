namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ToolStripMenuDashboard_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuReservar_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuLogin_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuLogout_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BootForm();
        }

        private void BootForm()
        {
            this.toolStripMenuLogin.Visible = false;
            this.toolStripMenuLogout.Visible = false;

            this.toolStripStatusLabel1.Visible = false;
            //bool existeUser = AutSys.isUserLogged();

            //this.adicionarJogoToolStripMenuItem.Enabled = false;
            //this.jogosToolStripMenuItem.Visible = existeUser;
            //this.logoutToolStripMenuItem.Visible = existeUser;
            //this.loginToolStripMenuItem.Visible = !existeUser;
            //this.statusStrip.Visible = existeUser;
            //if (existeUser)
            //{
            //    this.toolStripStatusLabel.Text = AutSys.getUserLogged().Username;

            //    if (AutSys.getUserLogged().Username == "admin")
            //    {
            //        this.adicionarJogoToolStripMenuItem.Enabled = true;
            //    }
            //}
        }

        private void ButtonProcurarReserva_Click(object sender, EventArgs e)
        {

        }

        private void DataGridViewSoftware_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Tratar o evento de click nos butoes da tabela
            if ((e.RowIndex >= 0) && (e.ColumnIndex == dataGridViewReserva.Columns["ButtonReserva"].Index))
            {
                //Get informação acerca da reserva escolhida

                //MessageBox para confirmar ou não a reserva do veiculo
                DialogResult escolhaDoUtilizador = MessageBox.Show("Está prestes a confirmar a reserva deste veiculo.", "Atenção...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                
                //Se a escolha for OK na message box reservar o veiculo escolhido
                if (escolhaDoUtilizador == DialogResult.OK)
                {
                    // Reservar Veiculo escolhido
                }
            }
        }
    }
}