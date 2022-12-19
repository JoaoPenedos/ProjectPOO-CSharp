using ProjectPOO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace ProjectPOO.Data
{
    public class Utilizadores
    {
        public static List<IPessoa> utilizadores = new();
        uint lastUtilizadorID = 0;

        //methods
        public void AddUtilizador(Utilizador novoUtilizador)
        {
            lastUtilizadorID = Utilizadores.utilizadores.Any() ? Utilizadores.utilizadores.Max(u => u.Id) : 0;
            novoUtilizador.Id = lastUtilizadorID + 1;

            //Utilizador cannot be null
            //if (novoUtilizador is null)
            //    throw new TeacherIsNullException("School2.Data.Teachers.Add()");

            //teacher must be unique
            //if (this.teachers.Exists(t => t.Contribuinte.Equals(newTeacher.Contribuinte)))
            //    throw new TeacherAlreadyExistsException("School2.Data.Teachers.Add()");

            //add teacher
            Utilizadores.utilizadores.Add(novoUtilizador);
        }

        public void AddUtilizador(Funcionario novoFuncionario)
        {
            lastUtilizadorID = Utilizadores.utilizadores.Any() ? Utilizadores.utilizadores.Max(u => u.Id) : 0;
            novoFuncionario.Id = lastUtilizadorID + 1;
            //lastUtilizadorID = Utilizadores.utilizadores.Any() ? Utilizadores.utilizadores.Max(r => r.Id) : 0;
            //novoFuncionario.Id = lastUtilizadorID + 1;

            //Utilizador cannot be null
            //if (novoUtilizador is null)
            //    throw new TeacherIsNullException("School2.Data.Teachers.Add()");

            //teacher must be unique
            //if (this.teachers.Exists(t => t.Contribuinte.Equals(newTeacher.Contribuinte)))
            //    throw new TeacherAlreadyExistsException("School2.Data.Teachers.Add()");

            //add teacher
            Utilizadores.utilizadores.Add(novoFuncionario);
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
            index = Utilizadores.utilizadores.FindIndex(u => u.Id.Equals(utilizador.Id));

            //update teachers with the new teacher
            Utilizadores.utilizadores[index] = utilizador;
        }

        public void UpdateUtilizador(Funcionario funcionario)
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
            index = Utilizadores.utilizadores.FindIndex(u => u.Id.Equals(funcionario.Id));

            //update teachers with the new teacher
            Utilizadores.utilizadores[index] = funcionario;
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
            index = Utilizadores.utilizadores.FindIndex(u => u.Id.Equals(utilizador.Id));

            //remove the wanted teacher
            Utilizadores.utilizadores.RemoveAt(index);
        }

        public void DeleteUtilizador(Funcionario funcionario)
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
            index = Utilizadores.utilizadores.FindIndex(f => f.Id.Equals(funcionario.Id));

            //remove the wanted teacher
            Utilizadores.utilizadores.RemoveAt(index);
        }

        /// <summary>
        /// Method to List all the utilizadores in the list
        /// </summary>
        /// <returns> return the teachers list </returns>
        public List<IPessoa> ListUtilizadores() => Utilizadores.utilizadores;

        public List<Utilizador>? ListOnlyUtilizadores() => Utilizadores.utilizadores.OfType<Utilizador>().ToList();

        public List<Funcionario>? ListOnlyFuncionarios() => Utilizadores.utilizadores.OfType<Funcionario>().ToList();

        public Utilizador? FindUtilizadorTipoUtilizador(uint id) => Utilizadores.utilizadores.OfType<Utilizador>().FirstOrDefault(u => u.Id.Equals(id));

        public Funcionario? FindUtilizadorTipoFuncionario(uint id) => Utilizadores.utilizadores.OfType<Funcionario>().FirstOrDefault(u => u.Id.Equals(id));

        public IPessoa? FindUtilizador(string nome) => Utilizadores.utilizadores.FirstOrDefault(u => u.Nome.Equals(nome));
        
        public IPessoa? FindUtilizador(string nome, string pass) => Utilizadores.utilizadores.FirstOrDefault(u => u.Nome.Equals(nome) && u.Password.Equals(pass));
    }
}
