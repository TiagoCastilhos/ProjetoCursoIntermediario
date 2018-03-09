using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFinalIntermediário;
using Biblioteca.Model;

namespace ProjetoFinalIntermediário.Menus {
    public class Menus {
        public static void MostrarMenuPrincipal()
        {
            Console.Write("Selecione uma opção abaixo:\n" +
                "1 - Cadastrar cliente\n" +
                "2 - Listar clientes\n" +
                "3 - Cadastrar Funcionario\n" +
                "4 - Listar funcionários\n" +
                "5 - Fechar programa\n");
        }

        public static void CadastrarCliente()
        {
            
            Console.Clear();

            Console.Write("CADASTRAR CLIENTE:\n" +
                "Nome: ");
            string NewClientName = Console.ReadLine();

            Console.Write("Data de nascimento: ");
            DateTime DataNascimento;
            DateTime.TryParse(Console.ReadLine(), out DataNascimento);

           
            Console.Write("Telefone: ");
            string NewClientTelephone = Console.ReadLine();
            
            Console.Write("CPF: ");
            string CPF = Console.ReadLine();

            Console.Write("RG: ");
            string RG = Console.ReadLine();

         
            Console.Write("CEP: ");
            string CEP = Console.ReadLine();
          

            Console.Write("Estado: ");
            string NewClientState = Console.ReadLine();

            Console.Write("Cidade: ");
            string NewClientCity = Console.ReadLine();

            Console.Write("Endereço: ");
            string NewClientAdress = Console.ReadLine();
            

            Clientes NewClient = new Clientes(NewClientName, DataNascimento, NewClientTelephone, CPF, RG, CEP, NewClientState, NewClientCity, NewClientAdress);
            Program.ListaDeClientes.Add(NewClient);


        }

        public static void ListarClientes()
        {

        }

        public static void CadastrarFuncionario()
        {

        }

        public static void ListarFuncionarios()
        {

        }
    }
}
