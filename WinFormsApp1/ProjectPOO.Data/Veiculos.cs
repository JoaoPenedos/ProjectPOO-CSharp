using ProjectPOO.Enums;
using ProjectPOO.Exceptions;
using ProjectPOO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjectPOO.Data
{
    public class Veiculos
    {
        #region Vzariaveis de estado

        public static List<IVeiculo> veiculos = new();
        uint lastVeiculoID = 0;
        uint lastTrotineteID = 0;
        uint lastBicicletaID = 0;

        #endregion


        #region Metodos

        /// <summary>
        /// Metodo para adicionar uma nova trotinete na lista de veiculos
        /// </summary>
        /// <param name="novaTrotinete">nova Trotinete a adicionar</param>
        /// <exception cref="ItemIsNullException">No caso de a Trotinete ser null</exception>
        /// <exception cref="ItemAlreadyExistsException">No caso de a novo designação ser igual a um antigo</exception>
        public void AddVeiculo(Trotinete novaTrotinete)
        {
            //defenir os id e as designações corretamente
            lastVeiculoID = Veiculos.veiculos.Any() ? Veiculos.veiculos.Max(v => v.Id) : 0;
            lastTrotineteID = Veiculos.veiculos.Any() ? Veiculos.veiculos
                .Where(v => v.TipoVeiculo.Equals(TipoVeiculo.Trotinete))
                .OrderByDescending(t => t.Designacao)
                .Select(t => UInt32.Parse(Regex.Match(t.Designacao, @"\d+").Value))
                .FirstOrDefault() : 0;

            novaTrotinete.Id = lastVeiculoID + 1;
            novaTrotinete.SetDesignacao(lastTrotineteID + 1);

            //trotinete não pode ser null
            if (novaTrotinete is null)
                throw new ItemIsNullException("ProjectPOO.Data.Veiculos.AddVeiculo() - Novo trotinete é null");

            //trotinete tem que ser unico
            if (Veiculos.veiculos.Exists(t => t.Designacao.Equals(novaTrotinete.Designacao)))
                throw new ItemAlreadyExistsException("ProjectPOO.Data.Veiculos.AddVeiculo() - Já existe um trotinete com essa designação");

            //adicionar trotinete
            Veiculos.veiculos.Add(novaTrotinete);
        }

        /// <summary>
        /// Metodo para adicionar uma nova bicicleta na lista de veiculos
        /// </summary>
        /// <param name="novaBicicleta">nova Bicicleta a adicionar</param>
        /// <exception cref="ItemIsNullException">No caso de a Bicicleta ser null</exception>
        /// <exception cref="ItemAlreadyExistsException">No caso de a novo designação ser igual a um antigo</exception>
        public void AddVeiculo(Bicicleta novaBicicleta)
        {
            //defenir os id e as designações corretamente
            lastVeiculoID = Veiculos.veiculos.Any() ? Veiculos.veiculos.Max(v => v.Id) : 0;
            lastBicicletaID = Veiculos.veiculos.Any() ? Veiculos.veiculos
                .Where(v => v.TipoVeiculo.Equals(TipoVeiculo.Bicicleta))
                .OrderByDescending(t => t.Designacao)
                .Select(t => UInt32.Parse(Regex.Match(t.Designacao, @"\d+").Value))
                .FirstOrDefault() : 0;

            novaBicicleta.Id = lastVeiculoID + 1;
            novaBicicleta.SetDesignacao(lastBicicletaID + 1);

            //bicicleta não pode ser null
            if (novaBicicleta is null)
                throw new ItemIsNullException("ProjectPOO.Data.Veiculos.AddVeiculo() - Nova bicicleta é null");

            //bicicleta tem que ser unico
            if (Veiculos.veiculos.Exists(t => t.Designacao.Equals(novaBicicleta.Designacao)))
                throw new ItemAlreadyExistsException("ProjectPOO.Data.Veiculos.AddVeiculo() - Já existe uma bicicleta com essa designação");

            //adicionar bicicleta
            Veiculos.veiculos.Add(novaBicicleta);
        }

        /// <summary>
        /// Metodo para dar update a uma trotinete na lista de veiculos
        /// </summary>
        /// <param name="trotinete">trotinete a editar</param>
        /// <exception cref="ItemIsNullException">No caso de a trotinete ser null</exception>
        /// <exception cref="ItemDoesNotExistsException">No caso de a trotinete não existir na lista</exception>
        public void UpdateVeiculo(Trotinete trotinete)
        {
            //variaveis
            int index;

            //Trotinete não pode ser null
            if (trotinete is null)
                throw new ItemIsNullException("ProjectPOO.Data.Veiculos.UpdateVeiculo() - Trotinete é null");

            //Verificar se a trotinete existe na lista
            if (Veiculos.veiculos.Exists(v => v.Id.Equals(trotinete.Id)))
                throw new ItemDoesNotExistsException("ProjectPOO.Data.Veiculos.UpdateVeiculo() - trotinete não existe na lista");

            //get index da trotinete
            index = Veiculos.veiculos.FindIndex(v => v.Designacao.Equals(trotinete.Designacao));

            //update Trotinete
            Veiculos.veiculos[index] = trotinete;
        }

        /// <summary>
        /// Metodo para dar update a uma Bicicleta na lista de veiculos
        /// </summary>
        /// <param name="bicicleta">Bicicleta a editar</param>
        /// <exception cref="ItemIsNullException">No caso de a Bicicleta ser null</exception>
        /// <exception cref="ItemDoesNotExistsException">No caso de a Bicicleta não existir na lista</exception>
        public void UpdateVeiculo(Bicicleta bicicleta)
        {
            //variaveis
            int index;

            //Bicicleta não pode ser null
            if (bicicleta is null)
                throw new ItemIsNullException("ProjectPOO.Data.Veiculos.UpdateVeiculo() - Bicicleta é null");

            //Verificar se a Bicicleta existe na lista
            if (Veiculos.veiculos.Exists(v => v.Id.Equals(bicicleta.Id)))
                throw new ItemDoesNotExistsException("ProjectPOO.Data.Veiculos.UpdateVeiculo() - Bicicleta não existe na lista");

            //get index da Bicicleta
            index = Veiculos.veiculos.FindIndex(v => v.Designacao.Equals(bicicleta.Designacao));

            //update Bicicleta
            Veiculos.veiculos[index] = bicicleta;
        }

        /// <summary>
        /// Metodo para eliminar uma trotinete na lista de veiculos
        /// </summary>
        /// <param name="trotinete">trotinete a eliminar</param>
        /// <exception cref="ItemIsNullException">No caso de a trotinete ser null</exception>
        /// <exception cref="ItemDoesNotExistsException">No caso de a trotinete não existir na lista</exception>
        public void DeleteVeiculo(Trotinete trotinete)
        {
            //variaveis
            int index;

            //Trotinete nao pode ser null
            if (trotinete is null)
                throw new ItemIsNullException("ProjectPOO.Data.Reservas.DeleteVeiculo() - trotinete é null");

            //Verificar se a trotinete existe na lista
            if (Veiculos.veiculos.Exists(t => t.Id.Equals(trotinete.Id)))
                throw new ItemDoesNotExistsException("ProjectPOO.Data.Reservas.DeleteVeiculo() - trotinete não existe na lista");

            //get index do trotinete
            index = Veiculos.veiculos.FindIndex(t => t.Designacao.Equals(trotinete.Designacao));

            //remover a trotinete
            Veiculos.veiculos.RemoveAt(index);
        }

        /// <summary>
        /// Metodo para eliminar uma bicicleta na lista de veiculos
        /// </summary>
        /// <param name="bicicleta">bicicleta a eliminar</param>
        /// <exception cref="ItemIsNullException">No caso de a bicicleta ser null</exception>
        /// <exception cref="ItemDoesNotExistsException">No caso de a bicicleta não existir na lista</exception>
        public void DeleteVeiculo(Bicicleta bicicleta)
        {
            //variaveis
            int index;

            //bicicleta nao pode ser null
            if (bicicleta is null)
                throw new ItemIsNullException("ProjectPOO.Data.Reservas.DeleteVeiculo() - bicicleta é null");

            //Verificar se a bicicleta existe na lista
            if (Veiculos.veiculos.Exists(t => t.Id.Equals(bicicleta.Id)))
                throw new ItemDoesNotExistsException("ProjectPOO.Data.Reservas.DeleteVeiculo() - bicicleta não existe na lista");

            //get index do bicicleta
            index = Veiculos.veiculos.FindIndex(v => v.Designacao.Equals(bicicleta.Designacao));

            //remover a bicicleta
            Veiculos.veiculos.RemoveAt(index);
        }

        /// <summary>
        /// Metodo para listar todos os veiculos da lista
        /// </summary>
        /// <returns> retorna a lista de veiculos</returns>
        public List<IVeiculo> ListVeiculos() => Veiculos.veiculos;

        /// <summary>
        /// Metodo para listar todos os veiculos do tipo TipoVeiculo recebido por parametro, da lista
        /// </summary>
        /// <param name="tipo">Tipo de Veiculo a procurar</param>
        /// <returns>Retorna a lista com o tipo pretendido</returns>
        public List<IVeiculo> ListVeiculos(TipoVeiculo tipo) => Veiculos.veiculos.Where(v => v.TipoVeiculo.Equals(tipo)).ToList();

        /// <summary>
        /// Metodo para listar todos os veiculos com um determindo EstadoVeiculo recebido por parametro, da lista
        /// </summary>
        /// <param name="estado">Estado do Veiculo a procurar</param>
        /// <returns>Retorna a lista com o estado pretendido</returns>
        public List<IVeiculo> ListVeiculos(EstadoVeiculo estado) => Veiculos.veiculos.Where(v => v.EstadoVeiculo.Equals(estado)).ToList();

        /// <summary>
        /// Metodo para listar todos os veiculos com um determindo EstadoVeiculo e TipoVeiculo recebido por parametro, da lista        
        /// </summary>
        /// <param name="estado">Estado do Veiculo a procurar</param>
        /// <param name="tipo">Tipo de Veiculo a procurar</param>
        /// <returns>Retorna a lista com o estado e o tipo pretendido</returns>
        public List<IVeiculo> ListVeiculos(EstadoVeiculo estado, TipoVeiculo tipo) => Veiculos.veiculos.Where(v => v.EstadoVeiculo.Equals(estado) && v.TipoVeiculo.Equals(tipo)).ToList();

        /// <summary>
        /// Metodo para encontrar um determindo veiculo pelo seu Id
        /// </summary>
        /// <param name="id">Id do veiculo a procurar</param>
        /// <returns>Veiculo pretendido se existir</returns>
        /// <exception cref="ItemDoesNotExistsException">No caso de não existir nenhum veiculo com o determinado Id</exception>
        public IVeiculo FindVeiculo(uint id) => Veiculos.veiculos.FirstOrDefault(v => v.Id.Equals(id)) 
            ?? throw new ItemDoesNotExistsException("Id não existe na lista de veiculos");

        /// <summary>
        /// Metodo para encontrar um determindo veiculo pela sua Designação
        /// </summary>
        /// <param name="designacao">Designação do veiculo a procurar</param>
        /// <returns>Veiculo pretendido se existir</returns>
        /// <exception cref="ItemDoesNotExistsException">No caso de não existir nenhum veiculo com a determinada designacao</exception>
        public IVeiculo FindVeiculo(string designacao) => Veiculos.veiculos.FirstOrDefault(v => v.Designacao.Equals(designacao)) 
            ?? throw new ItemDoesNotExistsException("Nome não existe na lista de veiculos");

        #endregion
    }
}
