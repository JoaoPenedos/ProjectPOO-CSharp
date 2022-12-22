using ProjectPOO.Data;
using ProjectPOO.Exceptions;
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
        #region Construtor

        /// <summary>
        /// Inicializa o Formulario Login
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
        }

        #endregion


        #region Eventos

        /// <summary>
        /// Evento iniciado ao fazer Load do FormMain 
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.textBoxUtilizador.Select();
        }

        /// <summary>
        /// Evento iniciado ao fazer click no butão de mostrar a palavra pass
        /// (mostra ou esconde o texto dependendo do estado atual da textbox)
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void ButtonLoginShowPass_Click(object sender, EventArgs e)
        {
            this.textBoxPassword.PasswordChar = this.textBoxPassword.PasswordChar == '\0' ? '*' : '\0';
        }

        /// <summary>
        /// Evento iniciado ao fazer click no butão cancelar do Form
        /// (Fecha o mesmo)
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void ButtonLoginCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento iniciado ao fazer click no butão ok do Form
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void ButtonLoginOk_Click(object sender, EventArgs e)
        {
            //se existir texto nas duas textbox, temtar efetuar login
            if (textBoxUtilizador.Text != null && this.textBoxUtilizador.Text.Trim() != string.Empty
                && textBoxPassword.Text != null && this.textBoxPassword.Text.Trim() != string.Empty)
            {
                try
                {
                    if (SystemLogin.IsAutenticacaoValida(this.textBoxUtilizador.Text.Trim(), this.textBoxPassword.Text.Trim()))
                        this.Close();
                    else
                        MessageBox.Show("Autenticação inválida.", "Atenção...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (ItemDoesNotExistsException i)
                {
                    MessageBox.Show(i.Source, i.Message, MessageBoxButtons.OK);
                }
                catch (Exception i)
                {
                    MessageBox.Show(i.Source, i.Message, MessageBoxButtons.OK);
                }
            }
            else
                MessageBox.Show("Preencha todos os campos", "Atenção...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Evento iniciado ao fazer click no linkLabel Nao possui conta do Form
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void LinkLabelRegistar_Click(object sender, EventArgs e)
        {
            //iniciar e mostrar o FormRegisterUser ao utilizador
            FormRegisterUser formRegisterUser = new();
            formRegisterUser.ShowDialog();
        }

        #endregion
    }
}
