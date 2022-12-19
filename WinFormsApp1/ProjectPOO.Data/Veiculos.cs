using ProjectPOO.Enums;
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
        public static List<IVeiculo> veiculos = new();
        uint lastVeiculoID = 0;
        uint lastTrotineteID = 0;
        uint lastBicicletaID = 0;

        public void AddVeiculo(Trotinete novaTrotinete) 
        {
            lastVeiculoID = Veiculos.veiculos.Any() ? Veiculos.veiculos.Max(v => v.Id) : 0;

            lastTrotineteID = Veiculos.veiculos.Any() ? Veiculos.veiculos
                .Where(v => v.TipoVeiculo.Equals(TipoVeiculo.Trotinete))
                .OrderByDescending(t => t.Designacao)
                .Select(t => UInt32.Parse(Regex.Match(t.Designacao, @"\d+").Value))
                .FirstOrDefault() : 0;

            novaTrotinete.Id = lastVeiculoID + 1;
            novaTrotinete.SetDesignacao(lastTrotineteID + 1);

            //Utilizador cannot be null
            //if (novoUtilizador is null)
            //    throw new TeacherIsNullException("School2.Data.Teachers.Add()");

            //teacher must be unique
            //if (this.teachers.Exists(t => t.Contribuinte.Equals(newTeacher.Contribuinte)))
            //    throw new TeacherAlreadyExistsException("School2.Data.Teachers.Add()");

            //add teacher
            Veiculos.veiculos.Add(novaTrotinete);
        }

        public void AddVeiculo(Bicicleta novaBicicleta)
        {
            lastVeiculoID = Veiculos.veiculos.Any() ? Veiculos.veiculos.Max(v => v.Id) : 0;

            lastBicicletaID = Veiculos.veiculos.Any() ? Veiculos.veiculos
                .Where(v => v.TipoVeiculo.Equals(TipoVeiculo.Bicicleta))
                .OrderByDescending(t => t.Designacao)
                .Select(t => UInt32.Parse(Regex.Match(t.Designacao, @"\d+").Value))
                .FirstOrDefault() : 0;

            novaBicicleta.Id = lastVeiculoID + 1;
            novaBicicleta.SetDesignacao(lastBicicletaID + 1);

            //Utilizador cannot be null
            //if (novoUtilizador is null)
            //    throw new TeacherIsNullException("School2.Data.Teachers.Add()");

            //teacher must be unique
            //if (this.teachers.Exists(t => t.Contribuinte.Equals(newTeacher.Contribuinte)))
            //    throw new TeacherAlreadyExistsException("School2.Data.Teachers.Add()");

            //add teacher
            Veiculos.veiculos.Add(novaBicicleta);
        }

        public void UpdateVeiculo(Trotinete trotinete)
        {
            //variables
            int index = 0;

            //teacher cannot be null
            //if (teacher is null)
            //    throw new TeacherIsNullException("School2.Data.Teachers.Update()");

            //find if teacher exists in the list
            //if (this.teachers.Exists(t => t.Contribuinte.Equals(teacher.Contribuinte)))
            //    throw new TeacherDoesNotExistsException("School2.Data.Teachers.Update()");

            //get index of the wanted teacher
            //trotinetes.Find(t => t.TrotineteID.Equals(trotinete.));

            index = Veiculos.veiculos.FindIndex(v => v.Designacao.Equals(trotinete.Designacao));

            //update teachers with the new teacher
            Veiculos.veiculos[index] = trotinete;
        }

        public void UpdateVeiculo(Bicicleta bicicleta)
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
            index = Veiculos.veiculos.FindIndex(v => v.Designacao.Equals(bicicleta.Designacao));

            //update teachers with the new teacher
            Veiculos.veiculos[index] = bicicleta;
        }

        public void DeleteVeiculo(Trotinete trotinete)
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
            index = Veiculos.veiculos.FindIndex(v => v.Designacao.Equals(trotinete.Designacao));

            //remove the wanted teacher
            Veiculos.veiculos.RemoveAt(index);
        }

        public void DeleteVeiculo(Bicicleta bicicleta)
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
            index = Veiculos.veiculos.FindIndex(v => v.Designacao.Equals(bicicleta.Designacao));

            //remove the wanted teacher
            Veiculos.veiculos.RemoveAt(index);
        }

        /// <summary>
        /// Method to List all the utilizadores in the list
        /// </summary>
        /// <returns> return the utilizadores list </returns>
        public List<IVeiculo> ListVeiculos() => Veiculos.veiculos;

        public List<IVeiculo> ListVeiculos(TipoVeiculo tipo) => Veiculos.veiculos.Where(v => v.TipoVeiculo.Equals(tipo)).ToList();
            
        public List<IVeiculo> ListVeiculos(EstadoVeiculo estado) => Veiculos.veiculos.Where(v => v.EstadoVeiculo.Equals(estado)).ToList();

        public List<IVeiculo> ListVeiculos(EstadoVeiculo estado, TipoVeiculo tipo) => Veiculos.veiculos.Where(v => v.EstadoVeiculo.Equals(estado) && v.TipoVeiculo.Equals(tipo)).ToList();

        public IVeiculo FindVeiculo(uint id) => Veiculos.veiculos.FirstOrDefault(v => v.Id.Equals(id)) ?? throw new Exception("Id não existe na lista de veiculos");

        public IVeiculo FindVeiculo(string designacao) => Veiculos.veiculos.FirstOrDefault(v => v.Designacao.Equals(designacao)) ?? throw new Exception("Nome não existe na lista de veiculos");

    }
}
