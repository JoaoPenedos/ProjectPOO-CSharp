using ProjectPOO.Enums;
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
        readonly List<Reserva> reservas = new();
        uint lastReservaID = 0;

        public void AddReserva(Reserva novaReserva)
        {
            lastReservaID = this.reservas.Any() ? this.reservas.Max(r => r.Id) : 0;
            novaReserva.Id = lastReservaID + 1;

            //Utilizador cannot be null
            //if (novoUtilizador is null)
            //    throw new TeacherIsNullException("School2.Data.Teachers.Add()");

            //teacher must be unique
            //if (this.teachers.Exists(t => t.Contribuinte.Equals(newTeacher.Contribuinte)))
            //    throw new TeacherAlreadyExistsException("School2.Data.Teachers.Add()");

            //add teacher
            this.reservas.Add(novaReserva);
        }

        public void UpdateReserva(Reserva reserva)
        {
            //variables
            int index;

            //teacher cannot be null
            //if (teacher is null)
            //    throw new TeacherIsNullException("School2.Data.Teachers.Update()");

            //find if teacher exists in the list
            //if (this.teachers.Exists(t => t.Contribuinte.Equals(teacher.Contribuinte)))
            //    throw new TeacherDoesNotExistsException("School2.Data.Teachers.Update()");

            //get index of the wanted teacher
            index = this.reservas.FindIndex(u => u.Id.Equals(reserva.Id));

            //update teachers with the new teacher
            this.reservas[index] = reserva;
        }

        public void DeleteReserva(Reserva reserva)
        {
            //variables
            int index;

            //teacher cannot be null
            //if (teacher is null)
            //    throw new TeacherIsNullException("School2.Data.Teachers.Delete()");

            //find if teacher exists in the list
            //if (this.teachers.Exists(t => t.Contribuinte.Equals(teacher.Contribuinte)))
            //throw new TeacherDoesNotExistsException("School2.Data.Teachers.Delete()");

            //get index of the wanted teacher
            index = this.reservas.FindIndex(u => u.Id.Equals(reserva.Id));

            //remove the wanted teacher
            this.reservas.RemoveAt(index);
        }

        /// <summary>
        /// Method to List all the utilizadores in the list
        /// </summary>
        /// <returns> return the teachers list </returns>
        public List<Reserva> ListReservas() => this.reservas;

        public Reserva FindReserva(uint id) => this.reservas.FirstOrDefault(r => r.Id.Equals(id)) 
            ?? throw new Exception("Id não existe na lista de reservas");
        
        public Reserva FindReserva(uint utilizadorId, uint veiculoId) => this.reservas.FirstOrDefault(r => r.UtilizadorId.Equals(utilizadorId) && r.VeiculoId.Equals(veiculoId)) 
            ?? throw new Exception("Id do utilizador ou do veiculo não existe na lista de reservas");

    }
}
