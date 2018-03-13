using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFinalIntermediário.Menus;
using Biblioteca;

namespace ProjetoFinalIntermediário {
    class Program {
       
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
                        Menus.Menus.ListarClientes();
                        break;

                    case 3:
                        Menus.Menus.CadastrarFuncionario();
                        break;

                    case 4:
                        Menus.Menus.ListarFuncionarios();
                        break;

                    default:
                        Console.WriteLine("Comando não encontrado!");
                        break;
                }
            }
            
        }
    }
}
