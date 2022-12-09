using ProjectPOO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Data
{
    public class Utilizadores
    {
        List<Utilizador> utilizadores = new List<Utilizador>();
        
        
        public Utilizadores()
        {
            this.AddUtilizador(new Utilizador("manuelAntonio@gmail.com", "Manuel Antonio", 935462613, DateTime.Now, "Alvelos" ));
            this.AddUtilizador(new Utilizador("ToneMaria@gmail.com", "Tone Maria", 945646513, DateTime.Now, "Brasiu" ));
            this.AddUtilizador(new Utilizador("Manuela@gmail.com", "Prima do Manuel", 945678977, DateTime.Now, "Alvelinhos" ));
        }


        //methods

        public void AddUtilizador(Utilizador novoUtilizador)
        {
            //Utilizador cannot be null
            //if (novoUtilizador is null)
            //    throw new TeacherIsNullException("School2.Data.Teachers.Add()");

            //teacher must be unique
            //if (this.teachers.Exists(t => t.Contribuinte.Equals(newTeacher.Contribuinte)))
            //    throw new TeacherAlreadyExistsException("School2.Data.Teachers.Add()");

            //add teacher
            this.utilizadores.Add(novoUtilizador);
        }

        public void UpdateUtilizador(Utilizador utilizador)
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
            index = this.utilizadores.FindIndex(u => u.Email.Equals(utilizador.Email));

            //update teachers with the new teacher
            this.utilizadores[index] = utilizador;
        }

        public void DeleteUtilizador(Utilizador utilizador)
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
            index = this.utilizadores.FindIndex(u => u.Email.Equals(utilizador.Email));

            //remove the wanted teacher
            this.utilizadores.RemoveAt(index);
        }

        /// <summary>
        /// Method to List all the utilizadores in the list
        /// </summary>
        /// <returns> return the teachers list </returns>
        public List<Utilizador> ListUtilizadores() => this.utilizadores;






        ///// <summary>
        ///// Method to list all the teachers in a list format in a specific Department
        ///// </summary>
        ///// <param name="department"> Department to search teachers </param>
        ///// <returns> return the teachers in the specific department in a list format </returns>
        //public List<Utilizador> Get(Departments department) =>
        //    this.teachers.Where(t => t.Department.Equals(department)).ToList();

        ///// <summary>
        ///// Method to list all the teachers in a list format older than the given age
        ///// </summary>
        ///// <param name="olderThan"> Age to search teachers olders than that</param>
        ///// <returns> return the teachers older than the given age in a list format </returns>
        //public List<Teacher> Get(int olderThan) =>
        //    this.teachers.Where(t => t.Age() > olderThan).ToList();

    }
}
