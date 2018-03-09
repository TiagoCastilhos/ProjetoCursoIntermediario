using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model {
    public sealed class Clientes:Pessoa {
        
        public Clientes(string Name, DateTime Date, string Telephone, string CPF, string RG, string CEP, string State, string City, string Adress)
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
        }
    }
}
