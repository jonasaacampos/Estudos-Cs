using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoMain
{
    class Program
    {
        static void Main(string[] args)
        {
            //para executar, rodar via cmd. e informar
            //nomeDoArquivoCompilado Param1 senha

            string senha = "abc123";

            if (senha != args[1])
            {
                Console.WriteLine("Acesso Negado !");
            }
            else
            {
                Console.WriteLine("Ola " + args[0]);
            }
        }
    }
}
