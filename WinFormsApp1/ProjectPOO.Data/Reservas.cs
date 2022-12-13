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
        List<Reserva> reservas = new List<Reserva>();
        uint lastReservaID = 0;

        public Reservas()
        { 
            
        }

        public Reservas(bool inicializeDummyData)
        {
            this.AddReserva(new Reserva(DateTime.Now, 2, 3));
            this.AddReserva(new Reserva(DateTime.Now, 2, 2));
            this.AddReserva(new Reserva(DateTime.Now, 1, 1));
            this.AddReserva(new Reserva(DateTime.Now, 3, 6));
            this.AddReserva(new Reserva(DateTime.Now, 1, 5));
            this.AddReserva(new Reserva(DateTime.Now, 4, 9));
            this.AddReserva(new Reserva(DateTime.Now, 4, 7));
        }

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

        /// <summary>
        /// Method to List all the utilizadores in the list
        /// </summary>
        /// <returns> return the teachers list </returns>
        public List<Reserva> ListReservas() => this.reservas;
    }
}
