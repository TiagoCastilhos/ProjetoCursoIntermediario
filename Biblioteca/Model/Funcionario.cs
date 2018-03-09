using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model {
    public sealed class Funcionario:Pessoa {
        private string Cargo { get; set; }
        private double Salario { get; set; }
        private DateTime DataContratacao { get; set; }

    }
}
