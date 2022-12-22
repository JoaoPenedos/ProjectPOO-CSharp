using ProjectPOO.Data;
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

namespace WinFormsApp1
{
    public partial class FormCarregarSaldo : Form
    {
        #region Constructor

        /// <summary>
        /// Inicializa o Formulario Carregar Saldo
        /// </summary>
        public FormCarregarSaldo()
        {
            InitializeComponent();
        }

        #endregion


        #region Eventos

        /// <summary>
        /// Evento iniciado ao fazer KeyPress enquanto a TextBoxSaldo está selecionada
        /// (permitir apenas numeros decimais)
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void TextBoxSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir carateres de controlo, digitos e pontos decimais
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            // permitir apenas 1 pontos decimal
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                e.Handled = true;
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
        /// Evento iniciado ao clicar no butão Carregar
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void ButtonCarregar_Click(object sender, EventArgs e)
        {
            //verificar o utilizador atual logado e dar update ao saldo
            Utilizadores utilizadores = new();
            Utilizador? u = utilizadores.FindUtilizadorTipoUtilizador(SystemLogin.GetUserLogged().Id);
            u.Saldo += Double.TryParse(this.textBoxSaldo.Text.Trim(), out double parsed) ? parsed : 0;

            MessageBox.Show("Saldo carregado com sucesso","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);

            this.Close();
        }

        #endregion
    }
}
