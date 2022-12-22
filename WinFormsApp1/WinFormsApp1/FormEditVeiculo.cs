using ProjectPOO.Data;
using ProjectPOO.Enums;
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

namespace WinFormsApp1
{
    public partial class FormEditVeiculo : Form
    {
        #region Variaveis de estado

        private Trotinete trotinete = null;
        private Bicicleta bicicleta = null;

        #endregion


        #region Construtor

        /// <summary>
        /// Inicializa o Formulario Editar Veiculo
        /// </summary>
        /// <param name="veiculo">recebe o veiculo a editar por parametro</param>
        public FormEditVeiculo(IVeiculo veiculo)
        {
            InitializeComponent();

            //guardar o tipo escolhido
            if (veiculo.TipoVeiculo.Equals(TipoVeiculo.Bicicleta))
                bicicleta = (Bicicleta) veiculo;
            else
                trotinete = (Trotinete) veiculo;

            //inserir items no comboBox
            this.comboBoxEstadoVeiculo.Items.Insert(0, EstadoVeiculo.Avariado);
            this.comboBoxEstadoVeiculo.Items.Insert(1, EstadoVeiculo.Inativo);
            this.comboBoxEstadoVeiculo.Items.Insert(2, EstadoVeiculo.SemBateria);
            this.comboBoxEstadoVeiculo.Items.Insert(3, EstadoVeiculo.Ativo);

            //proibir o funcionario de trocar o estado do veiculo para estado reservado
            if (veiculo.EstadoVeiculo.Equals(EstadoVeiculo.Reservado))
                this.comboBoxEstadoVeiculo.Items.Insert(4, EstadoVeiculo.Reservado);

            //preencher textBoxs
            this.labelDesignacaoVeiculo.Text = veiculo.Id + " --> " + veiculo.Designacao;
            this.textBoxModelo.Text = veiculo.Modelo;
            this.textBoxCustoMinuto.Text = veiculo.CustoMinuto.ToString();
            this.textBoxCustoReserva.Text = veiculo.CustoReserva.ToString();
            this.textBoxKilometros.Text = veiculo.Kilometros.ToString();
            this.textBoxKilometros.Enabled = false;
            this.comboBoxEstadoVeiculo.SelectedIndex = (int)veiculo.EstadoVeiculo;
        }

        #endregion


        #region Metodos

        /// <summary>
        /// Metodo para verificar se existe texto nas textbox necessarias para funcionar
        /// </summary>
        private void ProcessInformation()
        {
            this.buttonSubmeter.Enabled = false;

            if (this.comboBoxEstadoVeiculo.SelectedIndex == 4)
            {
                this.buttonSubmeter.Enabled = false;
                this.buttonEliminar.Enabled = false;
                this.comboBoxEstadoVeiculo.Enabled = false;
                this.textBoxModelo.Enabled = false;
                this.textBoxCustoMinuto.Enabled = false;
                this.textBoxCustoReserva.Enabled = false;
            }

            //verificar se existe texto nas textbox
            if (((this.comboBoxEstadoVeiculo.SelectedIndex == 0) || (this.comboBoxEstadoVeiculo.SelectedIndex == 1) 
                || (this.comboBoxEstadoVeiculo.SelectedIndex == 2) || (this.comboBoxEstadoVeiculo.SelectedIndex == 3))
                && (this.textBoxModelo.Text.Trim() != "") && (this.textBoxCustoMinuto.Text.Trim() != "") 
                && (this.textBoxCustoReserva.Text.Trim() != "") && (this.textBoxKilometros.Text.Trim() != ""))
                this.buttonSubmeter.Enabled = true;
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
        /// Evento iniciado ao fazer Load do FormEditVeiculo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEditVeiculo_Load(object sender, EventArgs e)
        {
            ProcessInformation();
        }

        /// <summary>
        /// Evento iniciado ao modificar o texto na TextBoxModelo
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void TextBoxModelo_TextChanged(object sender, EventArgs e)
        {
            ProcessInformation();
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
        /// Evento iniciado ao fazer KeyPress enquanto a TextBoxCustoMinuto está selecionada
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void TextBoxCustoMinuto_KeyPress(object sender, KeyPressEventArgs e)
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
        /// Evento iniciado ao fazer KeyPress enquanto a TextBoxCustoReserva está selecionada
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void TextBoxCustoReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbers(sender, e);
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
        /// Evento iniciado ao fazer KeyPress enquanto a TextBoxKilometros está selecionada
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void TextBoxKilometros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //apenas premetir digitos e carateres de controlo
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        /// <summary>
        /// Evento iniciado ao trocar o item selecionado na comboBox
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void ComboBoxEstadoVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProcessInformation();
        }

        private void ButtonSubmeter_Click(object sender, EventArgs e)
        {
            //MessageBox para confirmar ou não a edição do veiculo
            DialogResult escolhaDoUtilizador = MessageBox.Show("Está prestes a editar este veiculo.", "Atenção...", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            //Tratar o evento de click nos butoes(Eliminar) da tabela
            if (escolhaDoUtilizador == DialogResult.OK)
            {
                try
                {
                    Veiculos veiculos = new();

                    //verifica o tipo escolhido de veiculo
                    if (bicicleta is not null)
                    {
                        bicicleta.Modelo = this.textBoxModelo.Text.Trim();
                        bicicleta.CustoMinuto = Double.Parse(this.textBoxCustoMinuto.Text.Trim());
                        bicicleta.CustoReserva = Double.Parse(this.textBoxCustoReserva.Text.Trim());
                        bicicleta.EstadoVeiculo = (EstadoVeiculo) this.comboBoxEstadoVeiculo.SelectedIndex;
                        veiculos.UpdateVeiculo(bicicleta);
                    }
                    else
                    {
                        trotinete.Modelo = this.textBoxModelo.Text.Trim();
                        trotinete.CustoMinuto = Double.Parse(this.textBoxCustoMinuto.Text.Trim());
                        trotinete.CustoReserva = Double.Parse(this.textBoxCustoReserva.Text.Trim());
                        trotinete.EstadoVeiculo = (EstadoVeiculo) this.comboBoxEstadoVeiculo.SelectedIndex;
                        veiculos.UpdateVeiculo(trotinete);
                    }

                    this.Close();
                }
                catch (ItemIsNullException ex)
                {
                    MessageBox.Show(ex.Source, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (ItemDoesNotExistsException ex)
                {
                    MessageBox.Show(ex.Source, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception)
                {
                    MessageBox.Show("Não é possivel editar");
                }
            }
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            //MessageBox para confirmar ou não a eliminação do veiculo
            DialogResult escolhaDoUtilizador = MessageBox.Show("Está prestes a eliminar este veiculo.", "Atenção...", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            //Tratar o evento de click nos butoes(Eliminar) da tabela
            if (escolhaDoUtilizador == DialogResult.OK)
            {
                try
                {
                    Veiculos veiculos = new();

                    //verifica o tipo escolhido de veiculo
                    if (bicicleta is not null)
                        veiculos.DeleteVeiculo(bicicleta);
                    else
                        veiculos.DeleteVeiculo(trotinete);

                    this.Close();
                }
                catch (ItemIsNullException ex)
                {
                    MessageBox.Show(ex.Source, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (ItemDoesNotExistsException ex)
                {
                    MessageBox.Show(ex.Source, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }   
                catch (Exception)
                {
                    MessageBox.Show("Não é possivel eliminar");
                }
            }
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
