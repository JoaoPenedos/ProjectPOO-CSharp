using ProjectPOO.Data;
using ProjectPOO.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Veiculos veiculos = new(true);
        Reservas reservas = new(true);
        Utilizadores utilizadores = new(true);
        BindingSource bs;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Utilizadores.SetDevMode(utilizadores.ListUtilizadores().ElementAt(1));
            this.BootForm();
        }

        private void ToolStripMenuDashboard_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuReservar_Click(object sender, EventArgs e)
        {
            
        }

        private void ToolStripMenuLogin_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.ShowDialog();
            this.BootForm();
        }

        private void ToolStripMenuLogout_Click(object sender, EventArgs e)
        {
            Utilizadores.Logout();
            this.BootForm();
        }



        //public List<Utilizador> ListUtilizadorReservas() 
        //{
        //    List<Utilizador> u = this.utilizadores.ListUtilizadores();
        //    List<Reserva> r = this.reservas.ListReservas();

        //    var query = u.Join(r,
        //                    reserva => reserva.Id,
        //                    utilizador => utilizador,
        //                    (utilizador, reserva) =>
        //                    new 
        //                    { 
        //                        Utilizador = utilizador.Nome, 
        //                        UtilizadorEmail = utilizador.Email, 
        //                        Reserva = reserva
        //                    })
        //                .ToList();


        //    return query;
        //}

        private void BootForm()
        {
            bool existeUser = Utilizadores.IsUserLogged();

            this.dataGridViewReserva.DataSource = null;
            this.dataGridViewReserva.BackgroundColor = Color.White;
            this.dataGridViewReserva.RowHeadersVisible = false;
            this.dataGridViewReserva.Visible = false;

            //
            this.comboBoxPosto.Visible = false;
            //

            this.toolStripMenuDasboard.Visible = existeUser;
            this.toolStripMenuReservar.Visible = existeUser;
            this.toolStripStatusLabel1.Visible = existeUser;
            this.toolStripMenuLogout.Visible = existeUser;
            this.toolStripMenuLogin.Visible = !existeUser;

            this.pictureBoxBicicleta.Visible = existeUser;
            this.pictureBoxTrotinete.Visible = existeUser;
            this.dateTimePickerReservaDate.Visible = existeUser;
            this.dateTimePickerReservaTime.Visible = existeUser;
            this.buttonProcurarReserva.Visible = existeUser;
            this.checkBoxBicicleta.Visible = existeUser;
            this.checkBoxTrotinete.Visible = existeUser;

            if (existeUser)
                this.toolStripStatusLabel1.Text = Utilizadores.GetUserLogged().Nome;
        }

        private void ButtonProcurarReserva_Click(object sender, EventArgs e)
        {
            if (checkBoxBicicleta.Checked && !checkBoxTrotinete.Checked)
                UpdateDataGridViewState(veiculos.ListVeiculosBicicletas());
            else if (!checkBoxBicicleta.Checked && checkBoxTrotinete.Checked)
                UpdateDataGridViewState(veiculos.ListVeiculosTrotinetes());
            else if (checkBoxBicicleta.Checked && checkBoxTrotinete.Checked)
                UpdateDataGridViewState(veiculos.ListVeiculos());
            else
                MessageBox.Show("Escolha pelo menos um tipo de veiculo!", "Atenção...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void DataGridViewSoftware_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Tratar o evento de click nos butoes da tabela
            if ((e.RowIndex >= 0) && (e.ColumnIndex == dataGridViewReserva.Columns["ButtonReserva"].Index))
            {
                //Get informação acerca da reserva escolhida

                //MessageBox para confirmar ou não a reserva do veiculo
                DialogResult escolhaDoUtilizador = MessageBox.Show("Está prestes a confirmar a reserva deste veiculo.", "Atenção...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                               

                //Se a escolha for OK na message box, reservar o veiculo escolhido
                if (escolhaDoUtilizador == DialogResult.OK)
                {
                    // Reservar Veiculo escolhido
                }
            }
        }

        private void UpdateDataGridViewState<T>(IList<T> list)
        {
            IList<PropertyInfo> properties = typeof(T).GetProperties();
            this.dataGridViewReserva.Visible = true;
            this.dataGridViewReserva.DataSource = null;
            BindingList<T> bindingList = new BindingList<T>(list);
            bs = new BindingSource(bindingList, null);
            this.dataGridViewReserva.DataSource = bs;
            this.dataGridViewReserva.Columns["EstadoVeiculo"].Visible = false;
            this.dataGridViewReserva.Columns["Kilometros"].Visible = false;

            DataGridViewElementStates states = DataGridViewElementStates.None;
            this.dataGridViewReserva.ScrollBars = ScrollBars.None;
            var totalHeight = this.dataGridViewReserva.Rows.GetRowsHeight(states) + this.dataGridViewReserva.ColumnHeadersHeight;
            var totalWidth = this.dataGridViewReserva.Columns.Cast<DataGridViewColumn>().Where(x => x.Visible).Sum(x => x.Width);
            this.dataGridViewReserva.ClientSize = new Size(totalWidth, totalHeight);
        }


        //////////// IMPORTANTE
        ////veiculos.AddVeiculo(new Trotinete("BoltT2", 0.30, 0.95, 14));
        ////bs.ResetBindings(true);
        //////////// IMPORTANTE
        //////////// IMPORTANTE
        ////utilizadores.AddUtilizador(new Utilizador("teste@gmail.com", "teste", "teste", 123456789, DateTime.Now, "teste"));
        ////bs.ResetBindings(true);
        //////////// IMPORTANTE
        ////UpdateDataGridViewState(utilizadores.ListUtilizadores());
        //////////// IMPORTANTE
    }
}