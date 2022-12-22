using ProjectPOO.Data;
using ProjectPOO.Exceptions;
using ProjectPOO.Models;
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
    public partial class FormRegisterUser : Form
    {
        #region Constructor

        /// <summary>
        /// Inicializa o Formulario Registar Utilizador
        /// </summary>
        public FormRegisterUser()
        {
            InitializeComponent();
        }

        #endregion


        #region Metodos

        /// <summary>
        /// Evento iniciado ao fazer click no linkLabel Nao possui conta do Form
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void ProcessInformation()
        {
            this.buttonRegistar.Enabled = false;

            //verificar se existe texto nas textbox necessarias
            if ((this.dateTimePickerDataNascimento.Value.Date <= DateTime.Now.AddYears(-18))
                && (this.textBoxEmail.Text.Trim() != "") 
                && (this.textBoxNome.Text.Trim() != "") 
                && (this.textBoxPassword.Text.Trim() != "")
                && (this.textBoxNTelemovel.Text.Trim() != "")
                && (this.textBoxMorada.Text.Trim() != ""))
                this.buttonRegistar.Enabled = true;
        }

        #endregion


        #region Eventos

        /// <summary>
        /// Evento iniciado ao fazer Load do FormRegisterUser 
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void FormRegisterUser_Load(object sender, EventArgs e)
        {
            ProcessInformation();
        }

        /// <summary>
        /// Evento iniciado ao modificar o texto na TextBoxEmail
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            ProcessInformation();
        }

        /// <summary>
        /// Evento iniciado ao modificar o texto na TextBoxNome
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void TextBoxNome_TextChanged(object sender, EventArgs e)
        {
            ProcessInformation();
        }

        /// <summary>
        /// Evento iniciado ao modificar o texto na TextBoxPassword
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            ProcessInformation();
        }

        /// <summary>
        /// Evento iniciado ao modificar o texto na TextBoxNTelemovel
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void TextBoxNTelemovel_TextChanged(object sender, EventArgs e)
        {
            ProcessInformation();
        }

        /// <summary>
        /// Evento iniciado ao fazer KeyPress enquanto a TextBoxNTelemovel está selecionada
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void TextBoxNTelemovel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        /// <summary>
        /// Evento iniciado ao modificar o texto na TextBoxMorada
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void TextBoxMorada_TextChanged(object sender, EventArgs e)
        {
            ProcessInformation();
        }

        /// <summary>
        /// Evento iniciado ao modificar o valor na DateTimePickerDataNascimento
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void DateTimePickerDataNascimento_ValueChanged(object sender, EventArgs e)
        {
            ProcessInformation();
        }

        /// <summary>
        /// Evento iniciado ao clicar no butão cancelar
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento iniciado ao clicar no butão registar
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void ButtonRegistar_Click(object sender, EventArgs e)
        {
            Utilizadores utilizador = new();

            //verificar Exception que possam acontecer
            try
            {
                //adiciona o utilizador na lista
                utilizador.AddUtilizador(new Utilizador(this.textBoxEmail.Text.Trim(),
                    this.textBoxNome.Text.Trim(),
                    this.textBoxPassword.Text.Trim(),
                    Int32.Parse(this.textBoxNTelemovel.Text.Trim()),
                    this.dateTimePickerDataNascimento.Value,
                    this.textBoxMorada.Text.Trim()));
                
                MessageBox.Show("Utilizador registado com successo!","Atenção!",MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (ItemAlreadyExistsException i)
            {
                MessageBox.Show(i.Source,i.Message,MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Não é possivel adicionar");
            }
        }

        #endregion
    }
}
