using ProjectPOO.Enums;
using ProjectPOO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Data
{
    public class Veiculos
    {
        List<IVeiculo> veiculos = new List<IVeiculo>();
        uint lastTrotineteID = 0;
        uint lastBicicletaID = 0;

        public Veiculos()
        {

        }

        public Veiculos(bool inicializeDummyData)
        {
            this.AddVeiculo(new Trotinete("BoltB4", 0.15, 1.15, 0));
            this.AddVeiculo(new Trotinete("BoltB4", 0.15, 1.15, 0));
            this.AddVeiculo(new Trotinete("BoltB2", 0.20, 1, 0));
            this.AddVeiculo(new Bicicleta("BoltT4", 0.15, 1.15, 0));
            this.AddVeiculo(new Bicicleta("BoltT4", 0.15, 1.15, 0));
            this.AddVeiculo(new Bicicleta("BoltT3", 0.10, 1, 0));
        }

        public void AddVeiculo(Trotinete novaTrotinete) 
        {
            lastTrotineteID = this.veiculos.Any() ? this.veiculos
                .Where(v => v.TipoVeiculo.Equals(TipoVeiculo.Trotinete))
                .OrderByDescending(t => t.Id)
                .Select(t => t.Id)
                .FirstOrDefault() : 0;

            novaTrotinete.Id = lastTrotineteID + 1;
            novaTrotinete.SetDesignacao();

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
            lastBicicletaID = this.veiculos.Any() ? this.veiculos
                .Where(v => v.TipoVeiculo.Equals(TipoVeiculo.Bicicleta))
                .OrderByDescending(t => t.Id)
                .Select(t => t.Id)
                .FirstOrDefault() : 0;

            novaBicicleta.Id = lastBicicletaID + 1;
            novaBicicleta.SetDesignacao();

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


        public List<IVeiculo> ListVeiculosBicicletas() => this.veiculos.Where(v => v.TipoVeiculo.Equals(TipoVeiculo.Bicicleta)).ToList();


        public List<IVeiculo> ListVeiculosTrotinetes() => this.veiculos.Where(v => v.TipoVeiculo.Equals(TipoVeiculo.Trotinete)).ToList();
    }
}
