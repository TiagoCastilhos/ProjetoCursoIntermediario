using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Biblioteca.Arquivo {
    public class GerenciadoArquivo {
        public static void GravarArquivo(string nome, string texto)
        {
            string caminho = @"C:\Users\tiago.castilhos\source\repos\ProjetoFinalIntermediário\Biblioteca\Arquivo" + nome + ".txt";
            if (File.Exists(caminho))
            {
                using (StreamWriter wr = File.AppendText(caminho))
                {
                    wr.WriteLine(texto);
                }
            }
            else
            {
                using (StreamWriter wr = new StreamWriter(caminho))
                {
                    wr.WriteLine(texto);
                }
            }
        }

        public static string[] LerArquivo(string nome)
        {
            string caminho = @"C:\Users\tiago.castilhos\source\repos\ProjetoFinalIntermediário\Biblioteca\Arquivo" + nome + ".txt";
            return File.ReadAllLines(caminho);
        }
    }
}
