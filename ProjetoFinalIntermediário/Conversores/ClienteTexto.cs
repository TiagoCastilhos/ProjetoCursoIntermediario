using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;

namespace ProjetoFinalIntermediário.Conversores {
    class ClienteTexto {
        public static string ConverterParaTexto(Clientes cliente)
        {
            string texto = String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}", cliente.Nome, cliente.DataNascimento, cliente.Telefone, cliente.CPF, cliente.RG, cliente.CEP, cliente.Estado, cliente.Cidade, cliente.Endereço);
            return texto;
        }

        public static Clientes ConverterParaCliente(string linha)
        {
            string[] elementos = linha.Split(',');

            Clientes cliente = new Clientes(elementos[0], DateTime.Parse(elementos[1]), elementos[2], elementos[3], elementos[4], elementos[5], elementos[6], elementos[7], elementos[8]);
            return cliente;
        }
    }
}
