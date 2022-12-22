using ProjectPOO.Enums;
using ProjectPOO.Exceptions;
using ProjectPOO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Data
{
    public class Reservas
    {
        #region Variaveis de estado

        readonly List<Reserva> reservas = new();
        uint lastReservaID = 0;

        #endregion


        #region Metodos

        /// <summary>
        /// Metodo para adicionar uma nova reserva na lista de reservas
        /// </summary>
        /// <param name="novaReserva">Reserva a adicionar</param>
        /// <exception cref="ItemIsNullException">No caso de a nova Reserva ser nula</exception>
        public void AddReserva(Reserva novaReserva)
        {
            //defenir os id e as designações corretamente
            lastReservaID = this.reservas.Any() ? this.reservas.Max(r => r.Id) : 0;
            novaReserva.Id = lastReservaID + 1;

            //Reserva nao pode ser nula
            if (novaReserva is null)
                throw new ItemIsNullException("ProjectPOO.Data.Reservas.AddReserva() - Nova reserva é null");

            //adicionar reserva
            this.reservas.Add(novaReserva);
        }

        /// <summary>
        /// Metodo para dar update a uma reserva na lista de reservas
        /// </summary>
        /// <param name="reserva">reserva a editar</param>
        /// <exception cref="ItemIsNullException">No caso de a Reserva ser nula</exception>
        /// <exception cref="ItemDoesNotExistsException">No caso de a Reserva não existir na lista</exception>
        public void UpdateReserva(Reserva reserva)
        {
            //variaveis
            int index;

            //Reserva nao pode ser nula
            if (reserva is null)
                throw new ItemIsNullException("ProjectPOO.Data.Reservas.UpdateReserva() - reserva é null");

            //Verificar se a Reserva existe na lista
            if (!this.reservas.Exists(t => t.Id.Equals(reserva.Id)))
                throw new ItemDoesNotExistsException("ProjectPOO.Data.Reservas.UpdateReserva() - reserva não existe na lista");

            //get index da reserva 
            index = this.reservas.FindIndex(u => u.Id.Equals(reserva.Id));

            //update reserva
            this.reservas[index] = reserva;
        }

        /// <summary>
        /// Metodo para dar eliminar uma reserva da lista de reservas
        /// </summary>
        /// <param name="reserva">reserva a eliminar</param>
        /// <exception cref="ItemIsNullException">No caso de a Reserva ser nula</exception>
        /// <exception cref="ItemDoesNotExistsException">No caso de a Reserva não existir na lista</exception>
        public void DeleteReserva(Reserva reserva)
        {
            //variaveis
            int index;

            //Reserva nao pode ser nula
            if (reserva is null)
                throw new ItemIsNullException("ProjectPOO.Data.Reservas.DeleteReserva() - reserva é null");

            //Verificar se a Reserva existe na lista
            if (!this.reservas.Exists(t => t.Id.Equals(reserva.Id)))
                throw new ItemDoesNotExistsException("ProjectPOO.Data.Reservas.DeleteReserva() - reserva não existe na lista");

            //get index da reserva
            index = this.reservas.FindIndex(u => u.Id.Equals(reserva.Id));

            //remover a reserva
            this.reservas.RemoveAt(index);
        }

        /// <summary>
        /// Metodo para listar todas as reservas na lista
        /// </summary>
        /// <returns> retorna a lista de reservas</returns>
        public List<Reserva> ListReservas() => this.reservas;

        /// <summary>
        /// Metodo encontrar uma determinada reserva pelo seu Id
        /// </summary>
        /// <param name="id">id da reserva a procurar</param>
        /// <returns> retorna a reserva pretendida</returns>
        /// <exception cref="ItemDoesNotExistsException">No caso de a Reserva não existir na lista</exception>
        public Reserva FindReserva(uint id) => this.reservas.FirstOrDefault(r => r.Id.Equals(id)) 
            ?? throw new ItemDoesNotExistsException("ProjectPOO.Data.Reservas.FindReserva() - Id não existe na lista de reservas");

        /// <summary>
        /// Metodo encontrar uma determinada reserva apartir do Id do utilizador e do veiculo
        /// </summary>
        /// <param name="utilizadorId">id do utilizador na reserva a procurar</param>
        /// <param name="veiculoId">id do veiculo na reserva a procurar</param>
        /// <returns> retorna a reserva pretendida</returns>
        /// <exception cref="ItemDoesNotExistsException">No caso de a Reserva não existir na lista</exception>
        public Reserva FindReserva(uint utilizadorId, uint veiculoId) => this.reservas.FirstOrDefault(r => r.UtilizadorId.Equals(utilizadorId) && r.VeiculoId.Equals(veiculoId)) 
            ?? throw new ItemDoesNotExistsException("ProjectPOO.Data.Reservas.FindReserva() - Id do utilizador ou do veiculo não existe na lista de reservas");

        #endregion

    }
}
