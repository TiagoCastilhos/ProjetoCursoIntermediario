using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFinalIntermediário;
using Biblioteca.Model;
using ProjetoFinalIntermediário.Conversores;
using Biblioteca.Arquivo;

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

            Console.Write("Data de nascimento (DD/MM/AAAA): ");
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
            GerenciadoArquivo.GravarArquivo("Cliente", ClienteTexto.ConverterParaTexto(NewClient));

            Console.WriteLine("Cliente cadastrado com sucesso!");
            Console.ReadLine();
            Console.Clear();

        }

        public static void ListarClientes()
        {
            Console.Clear();
            Console.WriteLine("Listagem de clientes:");
            string[] linhas = GerenciadoArquivo.LerArquivo("Cliente");

            foreach (string linha in linhas)
            {
                //Por String
                Console.WriteLine(linha);

                /*Por objeto Cliente:
                 * Cliente cliente = Conversores.ClienteTexto.ConverterParaCliente(linha);
                 * Console.Writeline("Nome: " + cliente.Nome); - Exemplo por nome*/
            }
            Console.WriteLine("Pressione enter para continuar...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void CadastrarFuncionario()
        {
            Console.Clear();

            Console.Write("CADASTRAR FUNCIONÁRIO:\n" +
                "Nome: ");
            string NewEmpName = Console.ReadLine();

            Console.Write("Data de nascimento (DD/MM/AAAA): ");
            DateTime DataNascimento;
            DateTime.TryParse(Console.ReadLine(), out DataNascimento);


            Console.Write("Telefone: ");
            string NewEmpTelephone = Console.ReadLine();

            Console.Write("CPF: ");
            string CPF = Console.ReadLine();

            Console.Write("RG: ");
            string RG = Console.ReadLine();


            Console.Write("CEP: ");
            string CEP = Console.ReadLine();


            Console.Write("Estado: ");
            string NewEmpState = Console.ReadLine();

            Console.Write("Cidade: ");
            string NewEmpCity = Console.ReadLine();

            Console.Write("Endereço: ");
            string NewEmpAdress = Console.ReadLine();

            Console.Write("Cargo: ");
            string NewEmpC = Console.ReadLine();

            Console.Write("Salario: R$");
            double EmpS = double.Parse(Console.ReadLine());

            Console.Write("Data de contratação (DD/MM/AAAA): ");
            DateTime DateCont;
            DateTime.TryParse(Console.ReadLine(), out DateCont);

            Funcionario NewEmp = new Funcionario(NewEmpName, DataNascimento, NewEmpTelephone, CPF, RG, CEP, NewEmpState, NewEmpCity, NewEmpAdress, NewEmpC, EmpS, DateCont);
            GerenciadoArquivo.GravarArquivo("Funcionario", FuncionarioTexto.ConverterParaTexto(NewEmp));

            Console.WriteLine("Funcionario cadastrado com sucesso!");
            Console.ReadLine();
            Console.Clear();
        }

        public static void ListarFuncionarios()
        {
            Console.Clear();
            Console.WriteLine("Listagem de funcionarios: ");
            string[] linhas = GerenciadoArquivo.LerArquivo("Funcionario");

            foreach (string linha in linhas)
            {
                
                Console.WriteLine(linha);

            }
            Console.WriteLine("Pressione enter para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
        
    }
}
