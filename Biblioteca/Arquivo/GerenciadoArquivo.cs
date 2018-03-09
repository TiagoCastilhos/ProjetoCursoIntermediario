using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Biblioteca.Arquivo {
    public class GerenciadoArquivo {
        public void GravarArquivo(string nome, string texto)
        {
            string caminho = @"C:\Users\tiago.castilhos\source\repos\ProjetoFinalIntermediário\Biblioteca\Arquivo" + nome + ".txt";
            if (File.Exists(caminho))
            {
                
            }
            else
            {
                using (StreamWriter wr = new StreamWriter(caminho))
                {
                    wr.WriteLine(texto);
                }
            }
        }
    }
}
