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
        #region Variaveis de estado

        private readonly Veiculos veiculos = new();
        private readonly Reservas reservas = new();
        private readonly Utilizadores utilizadores = new();
        private IVeiculo veiculoEscolhido;
        private Reserva reservaEscolhida;
        private IPessoa utilizadorEscolhido;
        private IPessoa? utilizador;
        private bool existeUtilizador;

        #endregion


        #region Construtor

        /// <summary>
        /// Inicializa o Formulario principal e adiciona dummy data para propositos de teste
        /// </summary>
        public FormMain()
        {
            // Inicializa o Form principal
            InitializeComponent();

            //Dummy data para a lista de utilizadores
            utilizadores.AddUtilizador(new Utilizador("manuelAntonio@gmail.com", "Manuel", "maNuel", 935462613, DateTime.Now, "Alvelos", 10.32));
            utilizadores.AddUtilizador(new Utilizador("ToneMaria@gmail.com", "tone", "tone", 945646513, DateTime.Now, "Brasiu", 13.45));
            utilizadores.AddUtilizador(new Utilizador("Manuela@gmail.com", "manuela", "prima", 945678977, DateTime.Now, "Alvelinhos", 0.34));
            utilizadores.AddUtilizador(new Utilizador("Emanuel@outlook.com", "Emanuel", "José", 123456789, DateTime.Now, "Mexico", 5.1));
            utilizadores.AddUtilizador(new Funcionario("ferreirasantos@gmail.com", "Ferreira", "Santos", 937587613, DateTime.Now));
            utilizadores.AddUtilizador(new Funcionario("tester@gmail.com", "1", "1", 937342313, DateTime.Now));

            //Dummy data para a lista de veiculos
            veiculos.AddVeiculo(new Trotinete("BoltT4", 0.15, 1.15));
            veiculos.AddVeiculo(new Trotinete("BoltT4", 0.15, 1.15));
            veiculos.AddVeiculo(new Trotinete("BoltT2", 0.20, 1, 100));
            veiculos.AddVeiculo(new Bicicleta("BoltB4", 0.15, 1.15));
            veiculos.AddVeiculo(new Bicicleta("BoltB4", 0.15, 1.15, 35));
            veiculos.AddVeiculo(new Bicicleta("BoltB3", 0.10, 1, EstadoVeiculo.Avariado));
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

        #endregion


        #region Metodos

        /// <summary>
        /// Metodo para dar boot a "pagina" dashboard do utilizador
        /// </summary>
        private void BootFormDashboard()
        {
            //verificar se existe algum utilizador logado
            existeUtilizador = SystemLogin.IsUserLogged();

            //set estado dos diferentes Forms no BootFormDashboard
            this.dataGridViewReserva.ColumnHeadersVisible = true;
            this.dataGridViewReserva.DataSource = null;
            this.dataGridViewReserva.BackgroundColor = Color.White;
            this.dataGridViewReserva.RowHeadersVisible = false;
            this.dataGridViewReserva.Visible = false;
            this.dataGridViewReserva.Columns["ButtonReserva"].Visible = false;
            this.dataGridViewReserva.Columns["ButtonCancelar"].Visible = true;
            this.dataGridViewReserva.Columns["ButtonEditar"].Visible = false;

            this.labelCountReservas.Visible = false;
            this.labelFuncionario.Visible = false;
            this.comboBoxPosto.Visible = false;
            this.pictureBoxBicicleta.Visible = false;
            this.pictureBoxTrotinete.Visible = false;
            this.dateTimePickerReservaDate.Visible = false;
            this.dateTimePickerReservaTime.Visible = false;
            this.buttonProcurarReserva.Visible = false;
            this.checkBoxBicicleta.Visible = false;
            this.checkBoxTrotinete.Visible = false;
            this.toolStripStatusLabelSaldo.Visible = false;

            this.toolStripStatusLabelNome.Visible = existeUtilizador;
            this.toolStripMenuLogin.Visible = !existeUtilizador;
            this.toolStripMenuLogout.Visible = existeUtilizador;
            this.toolStripMenuDasboard.Visible = existeUtilizador;
            this.toolStripMenuReservar.Visible = existeUtilizador;
            this.toolStripMenuVeiculos.Visible = existeUtilizador;
            this.toolStripMenuCarregarSaldo.Visible = existeUtilizador;

            //se existir utilizador logado
            if (existeUtilizador)
            {
                utilizador = SystemLogin.GetUserLogged();

                //get nome do atual utilizador logado
                this.toolStripStatusLabelNome.Text = utilizador.Nome;
                
                //Diferentes ações consoante o tipo de utilizador
                if (utilizador is Funcionario)
                {
                    //procurar o atual funcionario na lista 
                    Funcionario? f = utilizadores.FindUtilizadorTipoFuncionario(utilizador.Id);

                    //set estado dos diferentes Forms para um funcionario
                    this.labelFuncionario.Visible = existeUtilizador;
                    this.labelFuncionario.Text = "Bem vindo Sr(a) " + f.Nome;
                    this.toolStripMenuDasboard.Visible = existeUtilizador;
                    this.toolStripMenuReservar.Visible = false;
                    this.toolStripMenuVeiculos.Visible = existeUtilizador;
                    this.toolStripMenuCarregarSaldo.Visible = false;
                }
                else
                {
                    //procurar o atual Utilizador na lista
                    Utilizador? u = utilizadores.FindUtilizadorTipoUtilizador(utilizador.Id);

                    //se houver reservas para listar, lista as mesmas
                    if (this.ListSpecificReservasUtilizador().Any()) 
                        UpdateDataGridViewState(ListSpecificReservasUtilizador());

                    //set estado dos diferentes Forms para um utilizador
                    this.labelCountReservas.Visible = existeUtilizador;
                    this.labelCountReservas.Text = "Tem " + ListSpecificReservasUtilizador().Count + " reservas em espera";
                    this.toolStripStatusLabelSaldo.Visible = existeUtilizador;
                    this.toolStripStatusLabelSaldo.Text = Math.Round(u.Saldo, 2).ToString() + "€";
                    this.toolStripMenuDasboard.Visible = existeUtilizador;
                    this.toolStripMenuReservar.Visible = existeUtilizador;
                    this.toolStripMenuVeiculos.Visible = false;
                    this.toolStripMenuCarregarSaldo.Visible = existeUtilizador;
                }
            }
        }

        /// <summary>
        /// Metodo para dar boot a "pagina" reservar do utilizador
        /// </summary>
        private void BootFormReservar()
        {
            //verificar se existe algum utilizador logado
            existeUtilizador = SystemLogin.IsUserLogged();
            utilizador = SystemLogin.GetUserLogged();
            Utilizador? u = utilizadores.FindUtilizadorTipoUtilizador(utilizador.Id);

            //set estado dos diferentes Forms no BootFormReserva
            this.dataGridViewReserva.ColumnHeadersVisible = true;
            this.dataGridViewReserva.DataSource = null;
            this.dataGridViewReserva.BackgroundColor = Color.White;
            this.dataGridViewReserva.RowHeadersVisible = false;
            this.dataGridViewReserva.Visible = false;
            this.labelCountReservas.Visible = false;
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
            this.toolStripStatusLabelSaldo.Text = Math.Round(u.Saldo, 2).ToString() + "€";
        }

        /// <summary>
        /// Metodo para dar boot a "pagina" lista veiculos do funcionario
        /// </summary>
        private void BootFormVeiculos()
        {
            //verificar se existe algum utilizador logado
            existeUtilizador = SystemLogin.IsUserLogged();

            //se existir utilizador logado
            if (existeUtilizador)
            {
                //verificar se a lista de veiculos contem algum
                if (veiculos.ListVeiculos().Any())
                {
                    //update na lista de veiculos
                    this.labelFuncionario.Text = "Existem " + veiculos.ListVeiculos().Count() + "\nna lista de veiculos";
                    UpdateDataGridViewState(veiculos.ListVeiculos());
                }
                else
                    this.labelFuncionario.Text = "Não existem veiculos neste momento";
            }
        }

        /// <summary>
        /// Metodo para atualizar o dataGridView baseado na list passada por referencia
        /// </summary>
        /// <typeparam name="T">Tipo da lista recebida</typeparam>
        /// <param name="list">Nome da lista recebida</param>
        private void UpdateDataGridViewState<T>(IList<T> list)
        {
            //verificar qual o utilizador logado
            utilizador = SystemLogin.GetUserLogged();

            //alterar o estado Visible para true caso tenha sido escondida antes
            this.dataGridViewReserva.Visible = true;
            //limpar o DataSource do dataGridView 
            this.dataGridViewReserva.DataSource = null;

            //Vincular a lista recebida ao dataGridView
            BindingList<T> bindingList = new(list);
            BindingSource? bs = new(bindingList, null);
            this.dataGridViewReserva.DataSource = bs;

            //Se a lista for do tipo IVeiculo e o utilizador do tipo utilizador esconder certas colunas desnecessárias
            if (typeof(T) == typeof(IVeiculo) && utilizador is Utilizador)
            {
                this.dataGridViewReserva.Columns["ButtonReserva"].Visible = true;
                this.dataGridViewReserva.Columns["ButtonCancelar"].Visible = false;
                this.dataGridViewReserva.Columns["ButtonEditar"].Visible = false;
                this.dataGridViewReserva.Columns["EstadoVeiculo"].Visible = false;
                this.dataGridViewReserva.Columns["Kilometros"].Visible = false;
                this.dataGridViewReserva.Columns["Id"].Visible = false;
            }
            else if (typeof(T) == typeof(IVeiculo) && utilizador is Funcionario)
            {
                this.dataGridViewReserva.Columns["ButtonReserva"].Visible = false;
                this.dataGridViewReserva.Columns["ButtonCancelar"].Visible = false;
                this.dataGridViewReserva.Columns["ButtonEditar"].Visible = true;
                this.dataGridViewReserva.Columns["EstadoVeiculo"].Visible = true;
                this.dataGridViewReserva.Columns["Kilometros"].Visible = true;
                this.dataGridViewReserva.Columns["Id"].Visible = false;
            }

            //Redimensionar o dataGridView para não haver espaços sem linhas e colunas
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
                        where u.Id == SystemLogin.GetUserLogged().Id && r.EstadoReserva.Equals(EstadoReserva.EmEspera)
                        select new ReservaComposta { Nome = u.Nome, DataReserva = r.DataReserva, VeiculoDesignacao = v.Designacao };
            return query.ToList();
        }

        #endregion


        #region Eventos

        /// <summary>
        /// Evento iniciado ao fazer Load do FormMain 
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            SystemLogin.SetDevMode(utilizadores.ListUtilizadores().ElementAt(5));
            this.BootFormDashboard();
        }

        /// <summary>
        /// Evento iniciado ao clicar no botão Login do menu
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void ToolStripMenuLogin_Click(object sender, EventArgs e)
        {
            //iniciar e mostrar o Formlogin ao utilizador
            FormLogin formLogin = new();
            formLogin.ShowDialog();
            this.BootFormDashboard();
        }

        /// <summary>
        /// Evento iniciado ao clicar no botão Logout do menu
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void ToolStripMenuLogout_Click(object sender, EventArgs e)
        {
            //Logout ao utilizador atual
            SystemLogin.Logout();
            this.BootFormDashboard();
        }

        /// <summary>
        /// Evento iniciado ao clicar no botão Dashboard do menu
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void ToolStripMenuDashboard_Click(object sender, EventArgs e)
        {
            this.BootFormDashboard();
        }

        /// <summary>
        /// Evento iniciado ao clicar no botão Reservar do menu
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void ToolStripMenuReservar_Click(object sender, EventArgs e)
        {
            this.BootFormReservar();
        }

        /// <summary>
        /// Evento iniciado ao clicar no botão lista de Veiculos do menu
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void ToolStripMenuListaDeVeiculos_Click(object sender, EventArgs e)
        {
            this.BootFormVeiculos();
        }

        /// <summary>
        /// Evento iniciado ao clicar no botão adicionar Veiculo do menu
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void ToolStripMenuAdicionarVeiculo_Click(object sender, EventArgs e)
        {
            //iniciar e mostrar o FormAddVeiculo ao utilizador
            FormAddVeiculo formAddVeiculo = new();
            formAddVeiculo.ShowDialog();
            this.BootFormVeiculos();
        }

        /// <summary>
        /// Evento iniciado ao clicar no botão carregar saldo do menu
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void ToolStripMenuCarregarSaldo_Click(object sender, EventArgs e)
        {
            FormCarregarSaldo formCarregarSaldo = new();
            formCarregarSaldo.ShowDialog();

            //Dependendo de qual pagina o utilizador estava quando clicou no botão
            // direcionar para a mesma pagina
            if (this.labelCountReservas.Visible)
                BootFormDashboard();
            else
                BootFormReservar();
        }

        /// <summary>
        /// Evento iniciado ao clicar no botão Procurar
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        private void ButtonProcurarReserva_Click(object sender, EventArgs e)
        {
            //dateTimePickerReservaDate e dateTimePickerReservaTime não podem ser de tempos passados
            //Também têm de estar pelo menos 15 minutos a frente
            if ((this.dateTimePickerReservaDate.Value.Date < DateTime.Now.Date) 
                || (this.dateTimePickerReservaDate.Value.Date == DateTime.Now.Date 
                && this.dateTimePickerReservaTime.Value.TimeOfDay <= DateTime.Now.AddMinutes(15).TimeOfDay))
            {
                MessageBox.Show("Escolha uma data correta!\nNOTA: A reserva pode ser feita pelo menos 15 minutos antes da hora pretendida", "Atenção...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.BootFormReservar();
            }
            else
            {
                //Dependendo de quais checkboxs estejam preenchidas dar update ao dataGridView com a lista referente
                //Caso não esteja nenhum selecionado mostrar uma messageBox de aviso
                if (checkBoxBicicleta.Checked && !checkBoxTrotinete.Checked)
                    UpdateDataGridViewState(veiculos.ListVeiculos(EstadoVeiculo.Ativo, TipoVeiculo.Bicicleta));
                else if (!checkBoxBicicleta.Checked && checkBoxTrotinete.Checked)
                    UpdateDataGridViewState(veiculos.ListVeiculos(EstadoVeiculo.Ativo, TipoVeiculo.Trotinete));
                else if (checkBoxBicicleta.Checked && checkBoxTrotinete.Checked)
                    UpdateDataGridViewState(veiculos.ListVeiculos(EstadoVeiculo.Ativo));
                else
                    MessageBox.Show("Escolha pelo menos um tipo de veiculo!", "Atenção...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento iniciado ao clicar no dataGridView
        /// </summary>
        /// <param name="sender">referência ao controlo/objeto que gerou o evento</param>
        /// <param name="e">contém os dados do evento</param>
        /// <exception cref="Exception">Não consegue aceder ao valor do index do dataGridView</exception>
        private void DataGridViewSoftware_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //variaveis
            DialogResult escolhaDoUtilizador;

            //Tratar o evento de click nos butoes(Reservar) da tabela 
            if ((e.RowIndex >= 0) && (e.ColumnIndex == this.dataGridViewReserva.Columns["ButtonReserva"].Index))
            {
                //verificar preço da reserva escolhida
                utilizador = SystemLogin.GetUserLogged();
                Utilizador? u = utilizadores.FindUtilizadorTipoUtilizador(utilizador.Id);
                double custoReserva = Double.Parse(this.dataGridViewReserva["CustoReserva", e.RowIndex].Value.ToString());

                //so pode reservar se tiver saldo suficiente
                if (u.Saldo >= custoReserva)
                {
                    //MessageBox para confirmar ou não a reserva do veiculo
                    escolhaDoUtilizador = MessageBox.Show("Está prestes a confirmar a reserva deste veiculo.", "Atenção...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    //Se a escolha for OK na message box, reservar o veiculo escolhido
                    if (escolhaDoUtilizador == DialogResult.OK)
                    {
                        try
                        {
                            //Get Id acerca da reserva escolhida
                            uint valorId = UInt32.Parse(this.dataGridViewReserva["Id", e.RowIndex].Value.ToString() ?? throw new Exception("Não consegue acessar o valor do index"));
                    
                            // Reservar Veiculo escolhido
                            reservas.AddReserva(new Reserva (
                                this.dateTimePickerReservaDate.Value.Date.Add(this.dateTimePickerReservaTime.Value.TimeOfDay),
                                SystemLogin.GetUserLogged().Id,
                                valorId));

                            //Update no estado do veiculo reservado
                            veiculoEscolhido = veiculos.FindVeiculo(valorId);
                            veiculoEscolhido.EstadoVeiculo = EstadoVeiculo.Reservado;
                            u.Saldo -= custoReserva;

                            this.BootFormReservar();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Atenção...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                    MessageBox.Show("Não possui saldo suficiente para efetuar a reserva.", "Atenção...", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            //Tratar o evento de click nos butoes(Cancelar) da tabela
            if ((e.RowIndex >= 0) && (e.ColumnIndex == this.dataGridViewReserva.Columns["ButtonCancelar"].Index))
            {
                //MessageBox para confirmar ou não o cancelamento da reserva
                escolhaDoUtilizador = MessageBox.Show("Está prestes a cancelar a reserva deste veiculo.", "Atenção...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                //Se a escolha for OK na message box, cancelar a reserva escolhida
                if (escolhaDoUtilizador == DialogResult.OK)
                {
                    try
                    {
                        //Get Id do utilizador e do veiculo acerca da reserva escolhida
                        string valorUtilizador = this.dataGridViewReserva["Nome", e.RowIndex].Value.ToString() ?? throw new Exception("Não consegue acessar o valor do nome");
                        string valorVeiculo = this.dataGridViewReserva["VeiculoDesignacao", e.RowIndex].Value.ToString() ?? throw new Exception("Não consegue acessar o valor do veiculoDesignacao");
                        
                        // Cancelar reserva do Veiculo escolhido
                        utilizadorEscolhido = utilizadores.FindUtilizador(valorUtilizador);
                        veiculoEscolhido = veiculos.FindVeiculo(valorVeiculo);
                        reservaEscolhida = reservas.FindReserva(utilizadorEscolhido.Id, veiculoEscolhido.Id);
                        reservaEscolhida.EstadoReserva = EstadoReserva.Cancelada;
                        reservaEscolhida.DataCancelamento = DateTime.Now;
                        veiculoEscolhido.EstadoVeiculo = EstadoVeiculo.Ativo;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Atenção...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                    this.BootFormDashboard();
                }
            }

            //Tratar o evento de click nos butoes(editar) da tabela
            if ((e.RowIndex >= 0) && (e.ColumnIndex == this.dataGridViewReserva.Columns["ButtonEditar"].Index))
            {
                try
                {
                    //Get Id veiculo escolhido
                    uint valorIdVeiculo = UInt32.TryParse(this.dataGridViewReserva["Id", e.RowIndex].Value.ToString(), out uint parsed) ? parsed
                        : throw new Exception("Não consegue acessar o valor do veiculoDesignacao");

                    // Mostrar propriedades do veiculo escolhido
                    veiculoEscolhido = veiculos.FindVeiculo(valorIdVeiculo);

                    FormEditVeiculo formEditVeiculo = new(veiculoEscolhido);
                    formEditVeiculo.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.BootFormVeiculos();
            }
        }

        #endregion
    }
}