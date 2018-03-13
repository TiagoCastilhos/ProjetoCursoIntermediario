using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;

namespace ProjetoFinalIntermediário.Conversores {
    class FuncionarioTexto {
        public static string ConverterParaTexto(Funcionario funcionario)
        {
            string texto = String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}", funcionario.Nome, funcionario.DataNascimento, funcionario.Telefone, funcionario.CPF, funcionario.RG, funcionario.CEP, funcionario.Estado, funcionario.Cidade, funcionario.Endereço, funcionario.Cargo, funcionario.Salario, funcionario.DataContratacao);
            return texto;
        }

        public static Funcionario ConverterParaFuncionario(string linha)
        {
            string[] elementos = linha.Split(',');

            Funcionario funcionario = new Funcionario(elementos[0], DateTime.Parse(elementos[1]), elementos[2], elementos[3], elementos[4], elementos[5], elementos[6], elementos[7], elementos[8], elementos[9], double.Parse(elementos[10]), DateTime.Parse(elementos[11]));
            return funcionario;
        }
    }
}
