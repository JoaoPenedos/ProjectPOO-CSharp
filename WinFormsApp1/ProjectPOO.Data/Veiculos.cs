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
        List<IVeiculo> veiculos = new List<IVeiculo>();
        uint lastVeiculoID = 0;
        uint lastTrotineteID = 0;
        uint lastBicicletaID = 0;


        //public Veiculos(bool inicializeDummyData)
        //{
        //    this.AddVeiculo(new Trotinete("BoltT4", 0.15, 1.15));
        //    this.AddVeiculo(new Trotinete("BoltT4", 0.15, 1.15));
        //    this.AddVeiculo(new Trotinete("BoltT2", 0.20, 1, 100));
        //    this.AddVeiculo(new Bicicleta("BoltB4", 0.15, 1.15));
        //    this.AddVeiculo(new Bicicleta("BoltB4", 0.15, 1.15, 35));
        //    this.AddVeiculo(new Bicicleta("BoltB3", 0.10, 1));
        //    this.AddVeiculo(new Trotinete("BoltT4", 0.15, 1.15));
        //    this.AddVeiculo(new Bicicleta("BoltB4", 0.15, 1.15));
        //    this.AddVeiculo(new Bicicleta("BoltB3", 0.10, 1));
        //}

        public void AddVeiculo(Trotinete novaTrotinete) 
        {
            lastVeiculoID = this.veiculos.Any() ? this.veiculos.Max(v => v.Id) : 0;

            lastTrotineteID = this.veiculos.Any() ? this.veiculos
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
            this.veiculos.Add(novaTrotinete);
        }

        public void AddVeiculo(Bicicleta novaBicicleta)
        {
            lastVeiculoID = this.veiculos.Any() ? this.veiculos.Max(v => v.Id) : 0;

            lastBicicletaID = this.veiculos.Any() ? this.veiculos
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
            this.veiculos.Add(novaBicicleta);
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

            index = this.veiculos.FindIndex(v => v.Designacao.Equals(trotinete.Designacao));

            //update teachers with the new teacher
            this.veiculos[index] = trotinete;
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
            index = this.veiculos.FindIndex(v => v.Designacao.Equals(bicicleta.Designacao));

            //update teachers with the new teacher
            this.veiculos[index] = bicicleta;
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
            index = this.veiculos.FindIndex(v => v.Designacao.Equals(trotinete.Designacao));

            //remove the wanted teacher
            this.veiculos.RemoveAt(index);
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
            index = this.veiculos.FindIndex(v => v.Designacao.Equals(bicicleta.Designacao));

            //remove the wanted teacher
            this.veiculos.RemoveAt(index);
        }

        /// <summary>
        /// Method to List all the utilizadores in the list
        /// </summary>
        /// <returns> return the teachers list </returns>
        public List<IVeiculo> ListVeiculos() => this.veiculos;

        public List<IVeiculo> ListVeiculos(TipoVeiculo tipo) => this.veiculos.Where(v => v.TipoVeiculo.Equals(tipo)).ToList();

        public List<IVeiculo> ListVeiculos(EstadoVeiculo estado) => this.veiculos.Where(v => v.EstadoVeiculo.Equals(estado)).ToList();

        public List<IVeiculo> ListVeiculos(EstadoVeiculo estado, TipoVeiculo tipo) => this.veiculos.Where(v => v.EstadoVeiculo.Equals(estado) && v.TipoVeiculo.Equals(tipo)).ToList();


        public IVeiculo FindVeiculo(uint id) => this.veiculos.FirstOrDefault(v => v.Id.Equals(id)) ?? throw new Exception("Id não existe na lista de veiculos");

        public IVeiculo FindVeiculo(string designacao) => this.veiculos.FirstOrDefault(v => v.Designacao.Equals(designacao)) ?? throw new Exception("Nome não existe na lista de veiculos");

    }
}
