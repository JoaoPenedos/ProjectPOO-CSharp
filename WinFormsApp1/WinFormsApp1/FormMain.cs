using ProjectPOO.Data;
using ProjectPOO.Enums;
using ProjectPOO.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Collections;
using System.Linq;

namespace WinFormsApp1
{
    public partial class FormMain : Form
    {
        //State Variables
        Veiculos veiculos = new();
        Reservas reservas = new();
        Utilizadores utilizadores = new();
        IVeiculo veiculoEscolhido;
        Reserva reservaEscolhida;
        Utilizador utilizadorEscolhido;
        bool existeUtilizador;

        /// <summary>
        /// Inicializa o Formulario principal e adiciona dummy data para propositos de teste
        /// </summary>
        public FormMain()
        {
            // Inicializa o Formulario principal
            InitializeComponent();

            //Dummy data para a lista de utilizadores
            utilizadores.AddUtilizador(new Utilizador("manuelAntonio@gmail.com", "Manuel", "maNuel", 935462613, DateTime.Now, "Alvelos"));
            utilizadores.AddUtilizador(new Utilizador("ToneMaria@gmail.com", "tone", "tone", 945646513, DateTime.Now, "Brasiu"));
            utilizadores.AddUtilizador(new Utilizador("Manuela@gmail.com", "manuela", "prima", 945678977, DateTime.Now, "Alvelinhos"));
            utilizadores.AddUtilizador(new Utilizador("Emanuel@outlook.com", "Emanuel", "Jos�", 123456789, DateTime.Now, "Mexico"));

            //Dummy data para a lista de veiculos
            veiculos.AddVeiculo(new Trotinete("BoltT4", 0.15, 1.15));
            veiculos.AddVeiculo(new Trotinete("BoltT4", 0.15, 1.15));
            veiculos.AddVeiculo(new Trotinete("BoltT2", 0.20, 1, 100));
            veiculos.AddVeiculo(new Bicicleta("BoltB4", 0.15, 1.15));
            veiculos.AddVeiculo(new Bicicleta("BoltB4", 0.15, 1.15, 35));
            veiculos.AddVeiculo(new Bicicleta("BoltB3", 0.10, 1));
            veiculos.AddVeiculo(new Trotinete("BoltT4", 0.15, 1.15));
            veiculos.AddVeiculo(new Bicicleta("BoltB4", 0.15, 1.15));
            veiculos.AddVeiculo(new Bicicleta("BoltB3", 0.10, 1));

            //Dummy data para a lista de reservas
            //Coloca o veiculo reservado em estado Reservado
            reservas.AddReserva(new Reserva(DateTime.Now, 2, 3));
            veiculoEscolhido = veiculos.FindVeiculo(3);
            veiculoEscolhido.EstadoVeiculo = EstadoVeiculo.Reservado;
            reservas.AddReserva(new Reserva(DateTime.Now, 1, 1));
            veiculoEscolhido = veiculos.FindVeiculo(1);
            veiculoEscolhido.EstadoVeiculo = EstadoVeiculo.Reservado;
            reservas.AddReserva(new Reserva(DateTime.Now, 4, 9));
            veiculoEscolhido = veiculos.FindVeiculo(9);
            veiculoEscolhido.EstadoVeiculo = EstadoVeiculo.Reservado;
            reservas.AddReserva(new Reserva(DateTime.Now, 4, 7));
            veiculoEscolhido = veiculos.FindVeiculo(7);
            veiculoEscolhido.EstadoVeiculo = EstadoVeiculo.Reservado;
        }

        /// <summary>
        /// Metodo para dar boot a "pagina" dashboard do utilizador
        /// </summary>
        private void BootFormDashboard()
        {
            //verificar se existe algum utilizador logado
            existeUtilizador = Utilizadores.IsUserLogged();

            //set estado dos diferentes Forms no BootFormDashboard
            this.dataGridViewReserva.ColumnHeadersVisible = true;
            this.dataGridViewReserva.DataSource = null;
            this.dataGridViewReserva.BackgroundColor = Color.White;
            this.dataGridViewReserva.RowHeadersVisible = false;
            this.dataGridViewReserva.Visible = false;
            this.dataGridViewReserva.Columns["ButtonReserva"].Visible = false;
            this.dataGridViewReserva.Columns["ButtonCancelar"].Visible = true;
            this.comboBoxPosto.Visible = false;
            this.pictureBoxBicicleta.Visible = false;
            this.pictureBoxTrotinete.Visible = false;
            this.dateTimePickerReservaDate.Visible = false;
            this.dateTimePickerReservaTime.Visible = false;
            this.buttonProcurarReserva.Visible = false;
            this.checkBoxBicicleta.Visible = false;
            this.checkBoxTrotinete.Visible = false;
            this.checkBoxBicicleta.Checked = false;
            this.checkBoxTrotinete.Checked = false;

            //colocar o estado do toolStripMenu e toolStripStatus visivel dependente de se existe ou n�o utilizador
            this.toolStripMenuDasboard.Visible = existeUtilizador;
            this.toolStripMenuReservar.Visible = existeUtilizador;
            this.toolStripStatusLabel1.Visible = existeUtilizador;
            this.toolStripMenuLogout.Visible = existeUtilizador;
            this.toolStripMenuLogin.Visible = !existeUtilizador;

            //se existir utilizador logado
            if (existeUtilizador)
            {
                //get nome do atual utilizador logado
                this.toolStripStatusLabel1.Text = Utilizadores.GetUserLogged().Nome;

                //se ouver revervas para listar, lista as mesmas, sen�o esconde os headers do dataGridView
                if (this.ListSpecificReservasUtilizador().Any())
                    UpdateDataGridViewState(ListSpecificReservasUtilizador());
                else
                    this.dataGridViewReserva.ColumnHeadersVisible = false;
                
                //this.ListSpecificReservasUtilizador().Any() ? UpdateDataGridViewState(ListSpecificReservasUtilizador()) : this.dataGridViewReserva.ColumnHeadersVisible = false;
            }
        }

        /// <summary>
        /// Metodo para dar boot a "pagina" reservar do utilizador
        /// </summary>
        private void BootFormReservar()
        {
            //verificar se existe algum utilizador logado
            existeUtilizador = Utilizadores.IsUserLogged();

            //set estado dos diferentes Forms no BootFormReserva
            this.dataGridViewReserva.ColumnHeadersVisible = true;
            this.dataGridViewReserva.DataSource = null;
            this.dataGridViewReserva.BackgroundColor = Color.White;
            this.dataGridViewReserva.RowHeadersVisible = false;
            this.dataGridViewReserva.Visible = false;
            this.comboBoxPosto.Visible = false;
            this.pictureBoxBicicleta.Visible = existeUtilizador;
            this.pictureBoxTrotinete.Visible = existeUtilizador;
            this.dateTimePickerReservaDate.Visible = existeUtilizador;
            this.dateTimePickerReservaTime.Visible = existeUtilizador;
            this.buttonProcurarReserva.Visible = existeUtilizador;
            this.checkBoxBicicleta.Visible = existeUtilizador;
            this.checkBoxTrotinete.Visible = existeUtilizador;
            this.checkBoxBicicleta.Checked = false;
            this.checkBoxTrotinete.Checked = false;
        }

        /// <summary>
        /// Metodo para atualizar o dataGridView baseado na list passada por referencia
        /// </summary>
        /// <typeparam name="T">Tipo da lista recebida</typeparam>
        /// <param name="list">Nome da lista recebida</param>
        private void UpdateDataGridViewState<T>(IList<T> list)
        {
            //alterar o estado Visible para true caso tenha sido escondida antes
            this.dataGridViewReserva.Visible = true;
            //limpar o DataSource do dataGridView 
            this.dataGridViewReserva.DataSource = null;

            //Vincular a lista recebida ao dataGridView
            BindingList<T> bindingList = new BindingList<T>(list);
            BindingSource? bs = new(bindingList, null);
            this.dataGridViewReserva.DataSource = bs;

            //Se a lista for do tipo IVeiculo esconder certas colunas desnecess�rias
            if (typeof(T) == typeof(IVeiculo))
            {
                this.dataGridViewReserva.Columns["ButtonReserva"].Visible = true;
                this.dataGridViewReserva.Columns["ButtonCancelar"].Visible = false;
                this.dataGridViewReserva.Columns["EstadoVeiculo"].Visible = false;
                this.dataGridViewReserva.Columns["Kilometros"].Visible = false;
                this.dataGridViewReserva.Columns["Id"].Visible = false;
            }

            //Redimensionar o dataGridView para n�o haver espa�os sem linhas e colunas
            DataGridViewElementStates states = DataGridViewElementStates.None;
            this.dataGridViewReserva.AutoResizeColumns();
            this.dataGridViewReserva.ScrollBars = ScrollBars.None;
            var totalHeight = this.dataGridViewReserva.Rows.GetRowsHeight(states) + this.dataGridViewReserva.ColumnHeadersHeight;
            var totalWidth = this.dataGridViewReserva.Columns.Cast<DataGridViewColumn>().Where(x => x.Visible).Sum(x => x.Width);
            this.dataGridViewReserva.ClientSize = new Size(totalWidth, totalHeight);
        }

        /// <summary>
        /// Metodo que executa uma query para devolver todas as reservas 
        /// (Compostas nos Ids, com os determinados dados referentes)
        /// </summary>
        /// <returns>lista do tipo ReservaComposta</returns>
        public List<ReservaComposta> ListAllReservaUtilizador()
        {
            //query para devolver todas as reservas
            var query = from v in veiculos.ListVeiculos()
                        join r in reservas.ListReservas() on v.Id equals r.VeiculoId
                        join u in utilizadores.ListUtilizadores() on r.UtilizadorId equals u.Id
                        select new ReservaComposta { Nome = u.Nome, DataReserva = r.DataReserva, VeiculoDesignacao = v.Designacao };
            return query.ToList();
        }

        /// <summary>
        /// Metodo que executa uma query para devolver todas as reservas do utilizador logado e o estado da reserva esteja EmEspera 
        /// (Compostas nos Ids, com os determinados dados referentes)
        /// </summary>
        /// <returns>lista do tipo ReservaComposta</returns>
        public List<ReservaComposta> ListSpecificReservasUtilizador()
        {
            //query para devolver todas as reservas do utilizador logado e o estado da reserva esteja EmEspera
            var query = from v in veiculos.ListVeiculos()
                        join r in reservas.ListReservas() on v.Id equals r.VeiculoId
                        join u in utilizadores.ListUtilizadores() on r.UtilizadorId equals u.Id
                        where u.Id == Utilizadores.GetUserLogged().Id && r.EstadoReserva.Equals(EstadoReserva.EmEspera)
                        select new ReservaComposta { Nome = u.Nome, DataReserva = r.DataReserva, VeiculoDesignacao = v.Designacao };
            return query.ToList();
        }

        /// <summary>
        /// Evento iniciado ao fazer Load do FormMain 
        /// </summary>
        /// <param name="sender">refer�ncia ao controlo/objeto que gerou o evento</param>
        /// <param name="e">cont�m os dados do evento</param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            Utilizadores.SetDevMode(utilizadores.ListUtilizadores().ElementAt(1));
            this.BootFormDashboard();
        }

        /// <summary>
        /// Evento iniciado ao clicar no bot�o Dashboard do menu
        /// </summary>
        /// <param name="sender">refer�ncia ao controlo/objeto que gerou o evento</param>
        /// <param name="e">cont�m os dados do evento</param>
        private void ToolStripMenuDashboard_Click(object sender, EventArgs e)
        {
            this.BootFormDashboard();
        }

        /// <summary>
        /// Evento iniciado ao clicar no bot�o Reservar do menu
        /// </summary>
        /// <param name="sender">refer�ncia ao controlo/objeto que gerou o evento</param>
        /// <param name="e">cont�m os dados do evento</param>
        private void ToolStripMenuReservar_Click(object sender, EventArgs e)
        {
            this.BootFormReservar();
        }

        /// <summary>
        /// Evento iniciado ao clicar no bot�o Login do menu
        /// </summary>
        /// <param name="sender">refer�ncia ao controlo/objeto que gerou o evento</param>
        /// <param name="e">cont�m os dados do evento</param>
        private void ToolStripMenuLogin_Click(object sender, EventArgs e)
        {
            //iniciar e mostrar o Formlogin ao utilizador
            FormLogin f = new();
            f.ShowDialog();
            this.BootFormDashboard();
        }

        /// <summary>
        /// Evento iniciado ao clicar no bot�o Logout do menu
        /// </summary>
        /// <param name="sender">refer�ncia ao controlo/objeto que gerou o evento</param>
        /// <param name="e">cont�m os dados do evento</param>
        private void ToolStripMenuLogout_Click(object sender, EventArgs e)
        {
            //Logout ao utilizador atual
            Utilizadores.Logout();
            this.BootFormDashboard();
        }

        /// <summary>
        /// Evento iniciado ao clicar no bot�o Procurar
        /// </summary>
        /// <param name="sender">refer�ncia ao controlo/objeto que gerou o evento</param>
        /// <param name="e">cont�m os dados do evento</param>
        private void ButtonProcurarReserva_Click(object sender, EventArgs e)
        {
            //Dependendo de quais checkboxs estejam preenchidas dar update ao dataGridView com a lista referente
            //Caso n�o esteja nenhum selecionado mostrar uma messageBox de aviso
            if (checkBoxBicicleta.Checked && !checkBoxTrotinete.Checked)
                UpdateDataGridViewState(veiculos.ListVeiculos(EstadoVeiculo.Ativo, TipoVeiculo.Bicicleta));
            else if (!checkBoxBicicleta.Checked && checkBoxTrotinete.Checked)
                UpdateDataGridViewState(veiculos.ListVeiculos(EstadoVeiculo.Ativo, TipoVeiculo.Trotinete));
            else if (checkBoxBicicleta.Checked && checkBoxTrotinete.Checked)
                UpdateDataGridViewState(veiculos.ListVeiculos(EstadoVeiculo.Ativo));
            else
                MessageBox.Show("Escolha pelo menos um tipo de veiculo!", "Aten��o...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Evento iniciado ao clicar no dataGridView
        /// </summary>
        /// <param name="sender">refer�ncia ao controlo/objeto que gerou o evento</param>
        /// <param name="e">cont�m os dados do evento</param>
        /// <exception cref="Exception">N�o consegue aceder ao valor do index do dataGridView</exception>
        private void DataGridViewSoftware_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //variaveis
            DialogResult escolhaDoUtilizador;

            //Tratar o evento de click nos butoes(Reservar) da tabela 
            if ((e.RowIndex >= 0) && (e.ColumnIndex == this.dataGridViewReserva.Columns["ButtonReserva"].Index))
            {
                //MessageBox para confirmar ou n�o a reserva do veiculo
                escolhaDoUtilizador = MessageBox.Show("Est� prestes a confirmar a reserva deste veiculo.", "Aten��o...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                //Se a escolha for OK na message box, reservar o veiculo escolhido
                if (escolhaDoUtilizador == DialogResult.OK)
                {
                    //Get Id acerca da reserva escolhida
                    uint valorId = UInt32.Parse(this.dataGridViewReserva["Id", e.RowIndex].Value.ToString() ?? throw new Exception("N�o consegue acessar o valor do index"));
                    
                    // Reservar Veiculo escolhido
                    Reserva novaReserva = 
                        new(
                            this.dateTimePickerReservaDate.Value.Date.Add(this.dateTimePickerReservaTime.Value.TimeOfDay), 
                            Utilizadores.GetUserLogged().Id,
                            valorId
                            );
                    reservas.AddReserva(novaReserva);

                    //Update no estado do veiculo reservado
                    veiculoEscolhido = veiculos.FindVeiculo(valorId);
                    veiculoEscolhido.EstadoVeiculo = EstadoVeiculo.Reservado;

                    this.BootFormReservar();
                }
            }

            //Tratar o evento de click nos butoes(Cancelar) da tabela
            if ((e.RowIndex >= 0) && (e.ColumnIndex == this.dataGridViewReserva.Columns["ButtonCancelar"].Index))
            {
                //MessageBox para confirmar ou n�o o cancelamento da reserva
                escolhaDoUtilizador = MessageBox.Show("Est� prestes a cancelar a reserva deste veiculo.", "Aten��o...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                //Se a escolha for OK na message box, cancelar a reserva escolhida
                if (escolhaDoUtilizador == DialogResult.OK)
                {
                    //Get Id do utilizador e do veiculo acerca da reserva escolhida
                    string valorUtilizador = this.dataGridViewReserva["Nome", e.RowIndex].Value.ToString() ?? throw new Exception("N�o consegue acessar o valor do nome");
                    string valorVeiculo = this.dataGridViewReserva["VeiculoDesignacao", e.RowIndex].Value.ToString() ?? throw new Exception("N�o consegue acessar o valor do veiculoDesignacao");

                    // Cancelar reserva do Veiculo escolhido
                    utilizadorEscolhido = utilizadores.FindUtilizador(valorUtilizador);
                    veiculoEscolhido = veiculos.FindVeiculo(valorVeiculo);
                    reservaEscolhida = reservas.FindReserva(utilizadorEscolhido.Id, veiculoEscolhido.Id);
                    reservaEscolhida.EstadoReserva = EstadoReserva.Cancelada;
                    veiculoEscolhido.EstadoVeiculo = EstadoVeiculo.Ativo;
                    this.BootFormDashboard();
                }
            }
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