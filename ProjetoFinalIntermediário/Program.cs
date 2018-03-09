using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFinalIntermediário.Menus;
using Biblioteca;

namespace ProjetoFinalIntermediário {
    class Program {
        public static List<Biblioteca.Model.Funcionario> ListaDeFuncionario = new List<Biblioteca.Model.Funcionario>();
        public static List<Biblioteca.Model.Clientes> ListaDeClientes = new List<Biblioteca.Model.Clientes>();

        static void Main(string[] args)
        {
            int opcao = 0;
            

            while (opcao != 5)
            {
                Menus.Menus.MostrarMenuPrincipal();
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Menus.Menus.CadastrarCliente();
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("Comando não encontrado!");
                        break;
                }
            }

            
        }
    }
}
