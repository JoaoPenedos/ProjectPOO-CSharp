using ProjectPOO.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.textBoxUtilizador.Select();
        }

        private void ButtonLoginShowPass_Click(object sender, EventArgs e)
        {
            this.textBoxPassword.PasswordChar = this.textBoxPassword.PasswordChar == '\0' ? '*' : '\0';
        }

        private void ButtonLoginCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonLoginOk_Click(object sender, EventArgs e)
        {
            if (textBoxUtilizador.Text != null && textBoxUtilizador.Text.Trim() != string.Empty
                && textBoxPassword.Text != null && textBoxPassword.Text.Trim() != string.Empty)
            {
                if (Utilizadores.IsAutenticacaoValida(this.textBoxUtilizador.Text.Trim(), this.textBoxPassword.Text.Trim()))
                    this.Close();
                else
                    MessageBox.Show("Autenticação inválida.", "Atenção...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
                throw new ApplicationException("Invalid entry, please try again.");            
        }

    }
}
