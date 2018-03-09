using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public abstract class Pessoa
    {
        protected string Nome { get; set; }
        protected DateTime DataNascimento { get; set; }
        protected string Telefone { get; set; }
        protected string CPF { get; set; }
        protected string RG { get; set; }
        protected string CEP { get; set; }
        protected string Estado { get; set; }
        protected string Cidade { get; set; }
        protected string Endereço { get; set; }
        
        
        

    }
}
