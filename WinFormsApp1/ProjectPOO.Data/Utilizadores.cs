using ProjectPOO.Exceptions;
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
        #region Variaveis de estado

        public static List<IPessoa> utilizadores = new();
        uint lastUtilizadorID = 0;

        #endregion


        #region Metodos

        /// <summary>
        /// Metodo para adicionar um novo utilizador na lista de utilizadores
        /// </summary>
        /// <param name="novoUtilizador">novo Utilizador a adicionar</param>
        /// <exception cref="ItemIsNullException">No caso de o utilizador ser null</exception>
        /// <exception cref="ItemAlreadyExistsException">No caso de o novo email ser igual a um antigo</exception>
        public void AddUtilizador(Utilizador novoUtilizador)
        {
            //defenir os id e as designações corretamente
            lastUtilizadorID = Utilizadores.utilizadores.Any() ? Utilizadores.utilizadores.Max(u => u.Id) : 0;
            novoUtilizador.Id = lastUtilizadorID + 1;

            //Utilizador não pode ser null
            if (novoUtilizador is null)
                throw new ItemIsNullException("ProjectPOO.Data.Utilizadores.AddUtilizador() - Novo utilizador é null");

            //utilizador tem que ser unico
            if (Utilizadores.utilizadores.Exists(u => u.Email.Equals(novoUtilizador.Email)))
                throw new ItemAlreadyExistsException("ProjectPOO.Data.Utilizadores.AddUtilizador() - Já existe um utilizador com esse email");

            //adicionar utilizador
            Utilizadores.utilizadores.Add(novoUtilizador);
        }

        /// <summary>
        /// Metodo para adicionar um novo funcionario na lista de utilizadores
        /// </summary>
        /// <param name="novoFuncionario">novo funcionario a adicionar</param>
        /// <exception cref="ItemIsNullException">No caso de o funcionario ser null</exception>
        /// <exception cref="ItemAlreadyExistsException">No caso de o novo email ser igual a um antigo</exception>
        public void AddUtilizador(Funcionario novoFuncionario)
        { 
            //defenir os id e as designações corretamente
            lastUtilizadorID = Utilizadores.utilizadores.Any() ? Utilizadores.utilizadores.Max(u => u.Id) : 0;
            novoFuncionario.Id = lastUtilizadorID + 1;

            //Funcionario não pode ser null
            if (novoFuncionario is null)
                throw new ItemIsNullException("ProjectPOO.Data.Utilizadores.AddUtilizador() - Novo funcionario é null");

            //funcioario tem que ser unico
            if (Utilizadores.utilizadores.Exists(f => f.Email.Equals(novoFuncionario.Email)))
                throw new ItemAlreadyExistsException("ProjectPOO.Data.Utilizadores.AddUtilizador() - Já existe um funcionario com esse email");

            //adicionar funcionario
            Utilizadores.utilizadores.Add(novoFuncionario);
        }

        /// <summary>
        /// Metodo para dar update a um utilizador na lista de utilizadores
        /// </summary>
        /// <param name="utilizador">utilizador a editar</param>
        /// <exception cref="ItemIsNullException">No caso de o utilizador ser null</exception>
        /// <exception cref="ItemDoesNotExistsException">No caso de o utilizador não existir na lista</exception>
        public void UpdateUtilizador(Utilizador utilizador)
        {
            //variaveis
            int index;

            //Utilizador não pode ser null
            if (utilizador is null)
                throw new ItemIsNullException("ProjectPOO.Data.Utilizadores.UpdateUtilizador() - utilizador é null");

            //Verificar se o utilizador existe na lista
            if (!Utilizadores.utilizadores.Exists(u => u.Id.Equals(utilizador.Id)))
                throw new ItemDoesNotExistsException("ProjectPOO.Data.Utilizadores.UpdateUtilizador() - utilizador não existe na lista");

            //get index do utilizador
            index = Utilizadores.utilizadores.FindIndex(u => u.Id.Equals(utilizador.Id));

            //update utilizador
            Utilizadores.utilizadores[index] = utilizador;
        }

        /// <summary>
        /// Metodo para dar update a um funcionario na lista de utilizadores
        /// </summary>
        /// <param name="funcionario">funcionario a editar</param>
        /// <exception cref="ItemIsNullException">No caso de o funcionario ser null</exception>
        /// <exception cref="ItemDoesNotExistsException">No caso de o funcionario não existir na lista</exception>
        public void UpdateUtilizador(Funcionario funcionario)
        {
            //variaveis
            int index;

            //Funcionario não pode ser null
            if (funcionario is null)
                throw new ItemIsNullException("ProjectPOO.Data.Utilizadores.UpdateUtilizador() - funcionario é null");

            //Verificar se o funcionario existe na lista
            if (!Utilizadores.utilizadores.Exists(f => f.Id.Equals(funcionario.Id)))
                throw new ItemDoesNotExistsException("ProjectPOO.Data.Utilizadores.UpdateUtilizador() - funcionario não existe na lista");

            //get index do funcionario
            index = Utilizadores.utilizadores.FindIndex(f => f.Id.Equals(funcionario.Id));

            //update funcionario
            Utilizadores.utilizadores[index] = funcionario;
        }

        /// <summary>
        /// Metodo para eliminar um utilizador na lista de utilizadores
        /// </summary>
        /// <param name="utilizador">utilizador a eliminar</param>
        /// <exception cref="ItemIsNullException">No caso de o utilizador ser null</exception>
        /// <exception cref="ItemDoesNotExistsException">No caso de o utilizador não existir na lista</exception>
        public void DeleteUtilizador(Utilizador utilizador)
        {
            //variaveis
            int index;

            //Utilizador nao pode ser null
            if (utilizador is null)
                throw new ItemIsNullException("ProjectPOO.Data.Utilizadores.DeleteUtilizador() - utilizador é null");

            //Verificar se o Utilizador existe na lista
            if (!Utilizadores.utilizadores.Exists(t => t.Id.Equals(utilizador.Id)))
                throw new ItemDoesNotExistsException("ProjectPOO.Data.Utilizadores.DeleteUtilizador() - utilizador não existe na lista");

            //get index do utilizador
            index = Utilizadores.utilizadores.FindIndex(u => u.Id.Equals(utilizador.Id));

            //remover o utilizador
            Utilizadores.utilizadores.RemoveAt(index);
        }

        /// <summary>
        /// Metodo para eliminar um funcionario na lista de utilizadores
        /// </summary>
        /// <param name="funcionario">funcionario a eliminar</param>
        /// <exception cref="ItemIsNullException">No caso de o funcionario ser null</exception>
        /// <exception cref="ItemDoesNotExistsException">No caso de o funcionario não existir na lista</exception>
        public void DeleteUtilizador(Funcionario funcionario)
        {
            //variaveis
            int index;

            //Funcionario nao pode ser null
            if (funcionario is null)
                throw new ItemIsNullException("ProjectPOO.Data.Utilizadores.DeleteUtilizador() - funcionario é null");

            //Verificar se o Funcionario existe na lista
            if (!Utilizadores.utilizadores.Exists(t => t.Id.Equals(funcionario.Id)))
                throw new ItemDoesNotExistsException("ProjectPOO.Data.Utilizadores.DeleteUtilizador() - funcionario não existe na lista");

            //get index do funcionario
            index = Utilizadores.utilizadores.FindIndex(f => f.Id.Equals(funcionario.Id));

            //remover o funcionario
            Utilizadores.utilizadores.RemoveAt(index);
        }

        /// <summary>
        /// Metodo para listar todos os utilizadores na lista
        /// </summary>
        /// <returns> retorna a lista de utilizadores</returns>
        public List<IPessoa> ListUtilizadores() => Utilizadores.utilizadores;

        /// <summary>
        /// Metodo para listar todos os utilizadores do tipo Utilizador na lista
        /// </summary>
        /// <returns> retorna a lista de utilizadores tipo Utilizador</returns>
        public List<Utilizador>? ListOnlyUtilizadores() => Utilizadores.utilizadores.OfType<Utilizador>().ToList();

        /// <summary>
        /// Metodo para listar todos os utilizadores do tipo Funcionario na lista
        /// </summary>
        /// <returns> retorna a lista de utilizadores tipo Funcionario</returns>
        public List<Funcionario>? ListOnlyFuncionarios() => Utilizadores.utilizadores.OfType<Funcionario>().ToList();

        /// <summary>
        /// Metodo que procura um determinado utilizador do tipo Utilizador pelo seu Id na lista de utilizadores
        /// </summary>
        /// <param name="id">Id do utilizador a procurar</param>
        /// <returns>retorna o utilizador pretendido se existir</returns>
        public Utilizador FindUtilizadorTipoUtilizador(uint id) => Utilizadores.utilizadores.OfType<Utilizador>().FirstOrDefault(u => u.Id.Equals(id))
            ?? throw new ItemDoesNotExistsException("ProjectPOO.Data.Utilizadores.FindUtilizadorTipoUtilizador() - Id do utilizador não existe na lista");

        /// <summary>
        /// Metodo que procura um determinado funcionario do tipo Funcionario pelo seu Id na lista de utilizadores
        /// </summary>
        /// <param name="id">Id do funcionario a procurar</param>
        /// <returns>retorna o funcionario pretendido se existir</returns>
        public Funcionario FindUtilizadorTipoFuncionario(uint id) => Utilizadores.utilizadores.OfType<Funcionario>().FirstOrDefault(u => u.Id.Equals(id))
            ?? throw new ItemDoesNotExistsException("ProjectPOO.Data.Utilizadores.FindUtilizadorTipoFuncionario() - Id do funcionario não existe na lista");

        /// <summary>
        /// Metodo que procura um determinado utilizador do tipo IPessoa pelo seu nome na lista de utilizadores
        /// </summary>
        /// <param name="nome">Nome do utilizador a procurar</param>
        /// <returns>retorna o utilizador pretendido se existir</returns>
        public IPessoa FindUtilizador(string nome) => Utilizadores.utilizadores.FirstOrDefault(u => u.Nome.Equals(nome))
            ?? throw new ItemDoesNotExistsException("ProjectPOO.Data.Utilizadores.FindUtilizador() - nome do utilizador não existe na lista");

        /// <summary>
        /// Metodo que procura um determinado utilizador do tipo IPessoa pelo seu nome e password na lista de utilizadores
        /// </summary>
        /// <param name="nome">Nome do utilizador a procurar</param>
        /// <param name="pass">Password do utilizador a procurar</param>
        /// <returns>retorna o utilizador pretendido se existir</returns>
        public IPessoa FindUtilizador(string nome, string pass) => Utilizadores.utilizadores.FirstOrDefault(u => u.Nome.Equals(nome) && u.Password.Equals(pass)) 
            ?? throw new ItemDoesNotExistsException("ProjectPOO.Data.Utilizadores.FindUtilizador() - nome ou pass do utilizador não existem na lista");

        #endregion
    }
}
