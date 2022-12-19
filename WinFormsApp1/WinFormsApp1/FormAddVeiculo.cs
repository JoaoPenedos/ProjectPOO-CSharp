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
        public FormAddVeiculo()
        {
            InitializeComponent();
            ProcessInformation();
        }

        private void ProcessInformation()
        {
            this.buttonAdicionar.Enabled = false;

            if (((this.comboBoxTiposVeiculos.SelectedIndex == 0) || (this.comboBoxTiposVeiculos.SelectedIndex == 1))
                && (this.textBoxModelo.Text.Trim() != "") 
                && (this.textBoxCustoMinuto.Text.Trim() != "") 
                && (this.textBoxCustoReserva.Text.Trim() != ""))
            {
                this.buttonAdicionar.Enabled = true;
            }
        }

        private void FormAddVeiculo_Load(object sender, EventArgs e)
        {
            this.comboBoxTiposVeiculos.Items.Insert(0, TipoVeiculo.Trotinete);
            this.comboBoxTiposVeiculos.Items.Insert(1, TipoVeiculo.Bicicleta);

            ProcessInformation();
        }

        private void ComboBoxTiposVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProcessInformation();
        }

        private void TextBoxModelo_TextChanged(object sender, EventArgs e)
        {
            ProcessInformation();
        }

        private void TextBoxCustoMinuto_TextChanged(object sender, EventArgs e)
        {
            ProcessInformation();
        }

        private void TextBoxCustoReserva_TextChanged(object sender, EventArgs e)
        {
            ProcessInformation();
        }

        private void TextBoxKilometros_TextChanged(object sender, EventArgs e)
        {
            ProcessInformation();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAdicionar_Click(object sender, EventArgs e)
        {
            Veiculos veiculos = new();

            try
            {
                int parsed;

                if (this.comboBoxTiposVeiculos.SelectedIndex == 0)
                {
                    veiculos.AddVeiculo(new Trotinete(this.textBoxModelo.Text.Trim(),
                        Double.Parse(this.textBoxCustoMinuto.Text.Trim()),
                        Double.Parse(this.textBoxCustoReserva.Text.Trim()),
                        Int32.TryParse(this.textBoxKilometros.Text.Trim(), out parsed) ? parsed : 0));
                }
                else if (this.comboBoxTiposVeiculos.SelectedIndex == 1)
                {
                    veiculos.AddVeiculo(new Bicicleta(this.textBoxModelo.Text.Trim(),
                        Double.Parse(this.textBoxCustoMinuto.Text.Trim()),
                        Double.Parse(this.textBoxCustoReserva.Text.Trim()),
                        Int32.TryParse(this.textBoxKilometros.Text.Trim(), out parsed) ? parsed : 0));
                }

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Não é possivel adicionar");
            }            
        }
    }
}
