namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private DateTimePicker timePicker;

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
    }
}