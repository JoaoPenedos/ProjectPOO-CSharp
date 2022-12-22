using ProjectPOO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Data
{
    public class SystemLogin
    {
        #region Variaveis de estado

        private static IPessoa? loggedUser = null;

        #endregion


        #region Metodos Estaticos

        /// <summary>
        /// Metodo que devolve verdadeiro se existe um utilizador logado
        /// </summary>
        /// <returns>True se existir e False se não existir</returns>
        public static bool IsUserLogged() => loggedUser != null && loggedUser.Id != 0;

        /// <summary>
        /// Metodo que devolve o utilizador logado
        /// </summary>
        /// <returns>Utilizador logado</returns>
        public static IPessoa? GetUserLogged() => loggedUser;

        /// <summary>
        /// Metodo que coloca o user recebido por parametro logado
        /// </summary>
        /// <param name="user">Utilizador a colocar logado</param>
        private static void SetUserLogged(IPessoa user) => loggedUser = user;

        /// <summary>
        /// Metodo que dá logout ao atual utilizador logado
        /// </summary>
        public static void Logout() => loggedUser = null;

        /// <summary>
        /// Metodo para colocar um utilizador especifico logado
        /// </summary>
        /// <param name="u">Utilizador especifico</param>
        public static void SetDevMode(IPessoa u) => SetUserLogged(u);

        /// <summary>
        /// Metodo que verifica se o Utilizador com o determinado nome e a pass existe na lista
        /// </summary>
        /// <param name="nome">Nome de utilizador</param>
        /// <param name="pass">Password de utilizador</param>
        /// <returns>Retorna true se existir utilizador e false se não existir</returns>
        public static bool IsAutenticacaoValida(string nome, string pass)
        {
            //procura o utilizador desejado
            Utilizadores u = new();
            IPessoa? user = u.FindUtilizador(nome, pass);

            //verifica se é diferente de null
            if (user != null)
            {
                SetUserLogged(user);
                return true;
            }

            return false;
        }

        #endregion
    }
}
