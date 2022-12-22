using ProjectPOO.Data;
using ProjectPOO.Enums;
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
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public partial class FormAddVeiculo : Form
    {
        #region Constructor

        /// <summary>
        /// Inicializa o Formulario Adicionar Veiculo
        /// </summary>
        public FormAddVeiculo()
        {
            InitializeComponent();
            ProcessInformation();
        }

        #endregion


        #region Methods

        /// <summary>
        /// Metodo para verificar se existe texto nas textbox necessarias para funcionar
        /// </summary>
        private void ProcessInformation()
        {
            this.buttonAdicionar.Enabled = false;

            //verificar se existe texto nas textbox necessarias
            if (((this.comboBoxTiposVeiculos.SelectedIndex == 0) || (this.comboBoxTiposVeiculos.SelectedIndex == 1))
                && (this.textBoxModelo.Text.Trim() != "") && (this.textBoxCustoMinuto.Text.Trim() != "") && (this.textBoxCustoReserva.Text.Trim() != ""))
                this.buttonAdicionar.Enabled = true;
        }

        /// <summary>
        /// Metodo que apenas permite carateres de controlo, digitos e 1 pontos decimal
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void AllowOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            //permitir carateres de controlo, digitos e pontos decimais
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            // permitir apenas 1 pontos decimal
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                e.Handled = true;
        }

        #endregion


        #region Eventos

        /// <summary>
        /// Evento iniciado ao fazer Load do FormAddVeiculo 
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void FormAddVeiculo_Load(object sender, EventArgs e)
        {
            //inserir items no comboBox
            this.comboBoxTiposVeiculos.Items.Insert(0, TipoVeiculo.Trotinete);
            this.comboBoxTiposVeiculos.Items.Insert(1, TipoVeiculo.Bicicleta);

            ProcessInformation();
        }

        /// <summary>
        /// Evento iniciado ao trocar o item selecionado na comboBox
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void ComboBoxTiposVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProcessInformation();
        }

        /// <summary>
        /// Evento iniciado ao modificar o texto na textBoxModelo
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void TextBoxModelo_TextChanged(object sender, EventArgs e)
        {
            ProcessInformation();
        }

        /// <summary>
        /// Evento iniciado ao fazer KeyPress enquanto a TextBoxCustoMinuto está selecionada
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void TextBoxCustoMinuto_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbers(sender, e);
        }

        /// <summary>
        /// Evento iniciado ao modificar o texto na TextBoxCustoMinuto
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void TextBoxCustoMinuto_TextChanged(object sender, EventArgs e)
        {
            ProcessInformation();
        }

        /// <summary>
        /// Evento iniciado ao fazer KeyPress enquanto a TextBoxCustoReserva está selecionada
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void TextBoxCustoReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbers(sender, e);
        }

        /// <summary>
        /// Evento iniciado ao modificar o texto na TextBoxCustoReserva
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void TextBoxCustoReserva_TextChanged(object sender, EventArgs e)
        {
            ProcessInformation();
        }

        /// <summary>
        /// Evento iniciado ao fazer KeyPress enquanto a TextBoxKilometros está selecionada
        /// (permitir apenas numeros)
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void TextBoxKilometros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        /// <summary>
        /// Evento iniciado ao modificar o texto na TextBoxKilometros
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void TextBoxKilometros_TextChanged(object sender, EventArgs e)
        {
            ProcessInformation();
        }

        /// <summary>
        /// Evento iniciado ao fazer clique no botão de cancelar
        /// (fecha o form)
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento iniciado ao clicar no butão adicionar
        /// (verifica se consegue colocar os respetivos valores)
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void ButtonAdicionar_Click(object sender, EventArgs e)
        {
            Veiculos veiculos = new();

            try
            {
                //verifica o tipo escolhido de veiculo
                if (this.comboBoxTiposVeiculos.SelectedIndex == 0)
                {
                    //adiciona o veiculo na lista
                    veiculos.AddVeiculo(new Trotinete(this.textBoxModelo.Text.Trim(),
                        Double.Parse(this.textBoxCustoMinuto.Text.Trim()),
                        Double.Parse(this.textBoxCustoReserva.Text.Trim()),
                        Int32.TryParse(this.textBoxKilometros.Text.Trim(), out int parsed) ? parsed : 0));
                }
                else if (this.comboBoxTiposVeiculos.SelectedIndex == 1)
                {
                    //adiciona o veiculo na lista
                    veiculos.AddVeiculo(new Bicicleta(this.textBoxModelo.Text.Trim(),
                        Double.Parse(this.textBoxCustoMinuto.Text.Trim()),
                        Double.Parse(this.textBoxCustoReserva.Text.Trim()),
                        Int32.TryParse(this.textBoxKilometros.Text.Trim(), out int parsed) ? parsed : 0));
                }

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Não é possivel adicionar");
            }            
        }

        #endregion
    }
}
