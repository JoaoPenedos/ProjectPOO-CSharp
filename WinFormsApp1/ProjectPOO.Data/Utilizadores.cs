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
        public static List<Utilizador> utilizadores = new List<Utilizador>();
        private static Utilizador? loggedUser = null;
        uint lastUtilizadorID = 0;

        
        //public Utilizadores(bool inicializeDummyData)
        //{
        //    this.AddUtilizador(new Utilizador("manuelAntonio@gmail.com", "Manuel", "maNuel", 935462613, DateTime.Now, "Alvelos" ));
        //    this.AddUtilizador(new Utilizador("ToneMaria@gmail.com", "tone", "tone", 945646513, DateTime.Now, "Brasiu" ));
        //    this.AddUtilizador(new Utilizador("Manuela@gmail.com", "manuela", "prima", 945678977, DateTime.Now, "Alvelinhos" ));
        //    this.AddUtilizador(new Utilizador("Emanuel@outlook.com", "Emanuel", "José", 123456789, DateTime.Now, "Mexico" ));
        //}

        //methods
        public void AddUtilizador(Utilizador novoUtilizador)
        {
            lastUtilizadorID = Utilizadores.utilizadores.Any() ? Utilizadores.utilizadores.Max(r => r.Id) : 0;
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
            index = Utilizadores.utilizadores.FindIndex(u => u.Email.Equals(utilizador.Email));

            //update teachers with the new teacher
            Utilizadores.utilizadores[index] = utilizador;
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
            index = Utilizadores.utilizadores.FindIndex(u => u.Email.Equals(utilizador.Email));

            //remove the wanted teacher
            Utilizadores.utilizadores.RemoveAt(index);
        }

        /// <summary>
        /// Method to List all the utilizadores in the list
        /// </summary>
        /// <returns> return the teachers list </returns>
        public List<Utilizador> ListUtilizadores() => Utilizadores.utilizadores;

        public Utilizador FindUtilizador(string nome) => Utilizadores.utilizadores.FirstOrDefault(u => u.Nome.Equals(nome)) ?? throw new Exception("Nome não existe na lista de utilizadores");


        public static bool IsUserLogged() => loggedUser != null && loggedUser.Id != 0;

        public static Utilizador? GetUserLogged() => loggedUser;

        private static void SetUserLogged(Utilizador user) { loggedUser = user; }

        public static void Logout() => loggedUser = null;

        public static void SetDevMode(Utilizador u) => SetUserLogged(u);

        public static bool IsAutenticacaoValida(string nome, string pass)
        {
            Utilizador? user = utilizadores.FirstOrDefault(u => u.Nome.Equals(nome) && u.Password.Equals(pass));

            if (user == null)
            {
                throw new Exception("User does not exist");
                return false;
            }
            else
            {
                SetUserLogged(user);
                return true;
            }
        }
    }
}
