using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model {
    public sealed class Funcionario:Pessoa {
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public DateTime DataContratacao { get; set; }

        public Funcionario(string Name, DateTime Date, string Telephone, string CPF, string RG, string CEP, string State, string City, string Adress, string cargo, double salario, DateTime DataContratacao)
        {
            Nome = Name;
            DataNascimento = Date;
            Telefone = Telephone;
            this.CPF = CPF;
            this.RG = RG;
            this.CEP = CEP;
            Estado = State;
            Cidade = City;
            Endereço = Adress;
            Cargo = cargo;
            Salario = salario;
            this.DataContratacao = DataContratacao;

        }
    }
}
